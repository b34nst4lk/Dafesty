﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransactionForm
{
    public partial class TransactionForm : Form
    {
        DafestyEntities context;

        BindingSource loanOutput;
        BindingSource returnOutput;

        DateTime today;
        DateTime dueDate;

        public TransactionForm()
        {
            InitializeComponent();

            context = new DafestyEntities();

            // Initialize Loan form
            TransactionID.Text = GenNewTransactionID();
            today = DateTime.Today;
            dueDate = today.AddDays(3);
            BorrowDate.Text = today.ToString("dd/MM/yy");
            DueDate.Text = dueDate.ToString("dd/MM/yy");

            loanOutput = new BindingSource();
            LoanOutput.DataSource = loanOutput;
            LoanOutput.AutoGenerateColumns = false;

            // Initialize Return form
            returnOutput = new BindingSource();
            ReturnOutput.DataSource = returnOutput;
            ReturnOutput.AutoGenerateColumns = false;
        }

        // Helper Functions

        public string GenNewTransactionID()
        {
            int transId = context.IssueTrans.Select(x => x.TransactionID).ToList().Max() + 1;
            return transId.ToString();
        }

        public Customer GetCustomerById(string custId)
        {
            Customer cust = context.Customers.FirstOrDefault(x => x.CustomerID == custId);
            if (cust is null)
            {
                throw new ItemNotFound(String.Format("No Customer with Id {0}", custId));
            }
            return cust;
        }

        public Movie GetMovieById(string movieIdStr)
        {
            if (Int16.TryParse(movieIdStr, out short movieId))
            {
                Movie movie = context.Movies.FirstOrDefault(x => x.VideoCode == movieId);
                if (movie is null)
                    throw new ItemNotFound(String.Format("No Movie with Id {0}", movieIdStr));
                else
                    return movie;
            }
            else
            {
                throw new InvalidID(String.Format("{0} is an invalid ID.", movieIdStr));
            }

        }

        public void ClearForms()
        {
            LoanCustomerID.Clear();
            VideoCode.Clear();
            loanOutput.Clear();

            ReturnCustomerID.Clear();
            returnOutput.Clear();
            TransactionID.Text = GenNewTransactionID();
        }

        // Shared Event Handlers

        private void ClearForm_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "";

            ClearForms();
        }

        // Loan Event Handlers

        private void AddVideo_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "";

            try
            {
                Movie m = GetMovieById(VideoCode.Text);
                loanOutput.Add(m);
                LoanOutput.Refresh();
                LoanOutput.Rows[LoanOutput.Rows.Count - 1].Cells["LoanStock"].Value = m.TotalStock - m.NumberRented;
                LoanOutput.Rows[LoanOutput.Rows.Count - 1].Cells["LoanDelete"].Value = "Remove";

                StatusLabel.Text = String.Format("{0} successfully added.", m.MovieTitle.Trim());
            }
            catch (InvalidID err)
            {
                StatusLabel.Text = err.Message;
            }
            catch (ItemNotFound err)
            {
                StatusLabel.Text = err.Message;
            }
            catch
            {
                StatusLabel.Text = "Unknown error has occured.";
            }
        }

        private void LoanOutput_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StatusLabel.Text = "";

            short movieId = short.Parse(LoanOutput.Rows[e.RowIndex].Cells["LoanVideoCode"].Value.ToString());
            
            foreach (Movie m in loanOutput)
            {
                if (m.VideoCode == movieId)
                {
                    loanOutput.Remove(m);
                    break;
                }
            }
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "";

            // Verify Customer
            try
            {
                Customer c = GetCustomerById(LoanCustomerID.Text);
                int transactionId = Int32.Parse(TransactionID.Text) - 1;

                List<DataGridViewRow> checkedOutMovies = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in LoanOutput.Rows)
                {
                    // Check stock
                    short movieId = (short)row.Cells["LoanVideoCode"].Value;
                    Movie m = context.Movies.First(x => movieId == x.VideoCode);

                    if (m.TotalStock - m.NumberRented > 0)
                    {
                        // Create new IssueTran object
                        IssueTran tran = new IssueTran();
                        tran.TransactionID = (short)transactionId++;
                        tran.CustomerID = LoanCustomerID.Text;
                        tran.VideoCode = movieId;
                        tran.DateIssue = today;
                        tran.DateDue = dueDate;
                        tran.DateActualReturn = null;
                        tran.RentalStatus = "out";

                        if (!(row.Cells["LoanRemarks"].Value is null))
                            tran.Remarks = row.Cells["LoanRemarks"].Value.ToString();
                        else
                            tran.Remarks = "";

                        context.IssueTrans.Add(tran);
                        m.NumberRented++;
                        context.SaveChanges();
                        checkedOutMovies.Add(row);
                    }
                }

                foreach (DataGridViewRow row in checkedOutMovies)
                {
                    LoanOutput.Rows.Remove(row);
                }

                if (LoanOutput.Rows.Count > 0)
                {
                    StatusLabel.Text = "There should not be any stock remaining for the above movies. Please double check.";
                }
                else
                {
                    ClearForms();
                    StatusLabel.Text = String.Format("Successfully checkedout movies for {0}.", c.CustomerName);
                }
            }
            catch (ItemNotFound err)
            {
                StatusLabel.Text = err.Message;
            }
        }

        // Return Event Handlers

        private void ReturnSearchCustomer_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "";
            try
            {
                Customer c = GetCustomerById(ReturnCustomerID.Text);

                foreach (IssueTran tran in c.IssueTrans)
                {
                    returnOutput.Add(tran);
                    DataGridViewRow row = ReturnOutput.Rows[ReturnOutput.Rows.Count - 1];
                    row.Cells["MovieTitle"].Value = context.Movies.First(x => x.VideoCode == tran.VideoCode).MovieTitle;
                    if (!(tran.DateDue is null))
                    {
                        DateTime dt = (DateTime)tran.DateDue;
                        row.Cells["ReturnDueDate"].Value = dt.ToString("dd/MM/yy"); 
                    }
                }
            }
            catch (ApplicationException err)
            {
                StatusLabel.Text = err.Message;
            }
        }

        private void ReturnOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ReturnOutput.Columns[e.ColumnIndex].Name == "ToReturn" && e.RowIndex > -1)
            {
                DataGridViewCell cell = ReturnOutput.Rows[e.RowIndex].Cells["ToReturn"];
                if (cell.Value is null)
                    cell.Value = "Return";
                else
                    cell.Value = null;
            }
        }

        private void ReturnVideos_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> returnedMovies = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in ReturnOutput.Rows)
            {
                if (!(row.Cells["ToReturn"].Value is null))
                {
                    short transId = Int16.Parse(row.Cells["ReturnTransactionId"].Value.ToString());
                    IssueTran tran = context.IssueTrans.First(x => x.TransactionID == transId);
                    tran.DateActualReturn = DateTime.Now;
                    if (!(row.Cells["ReturnRemarks"].Value is null))
                        tran.Remarks = row.Cells["ReturnRemarks"].Value.ToString();
                    tran.RentalStatus = "in";

                    tran.Movie.NumberRented--;
                    context.SaveChanges();
                    returnedMovies.Add(row);
                }
            }

            foreach (DataGridViewRow row in returnedMovies)
            {
                ReturnOutput.Rows.Remove(row);
            }
        }
    }
}

using System;
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
    public partial class CustomerLookupForm : Form
    {
        Form caller;
        TextBox idTextBox;
        TextBox nameTextBox;

        DafestyEntities context;

        BindingSource lookupOutput;

        public CustomerLookupForm()
        {
            InitializeComponent();
            context = new DafestyEntities();

            lookupOutput = new BindingSource();
            lookupOutput.DataSource = context.Customers.ToList();
            RefreshLookupOutput();
            LookupOutput.DataSource = lookupOutput;
        }

        public CustomerLookupForm(Form caller, TextBox idTextBox, TextBox nameTextBox): this()
        {
            this.caller = caller;
            this.idTextBox = idTextBox;
            this.nameTextBox = nameTextBox;
        }

        // Helper functions
        private void RefreshLookupOutput()
        {
            lookupOutput.DataSource = context.Customers.ToList();
        }

        // Search events

        private void LookUp_KeyUp(object sender, KeyEventArgs e)
        {
            string idSubStr = CustomerID.Text;
            string nameSubStr = CustomerName.Text;

            lookupOutput.DataSource = context.Customers.Where(x =>
                                        x.CustomerName.Contains(nameSubStr)
                                        && x.CustomerID.Contains(idSubStr)).ToList();

            StatusLabel.Text = String.Format("{0} results found.", lookupOutput.Count);
        }

        // Button events

        private void ClearSearch_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "";

            CustomerID.Clear();
            CustomerName.Clear();
            RefreshLookupOutput();

            StatusLabel.Text = "Search cleared.";
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "";

            if (!(LookupOutput.SelectedCells is null))
            {
                DataGridViewRow row = LookupOutput.Rows[LookupOutput.SelectedCells[0].RowIndex];
                idTextBox.Text = row.Cells["LookupCustomerID"].Value.ToString();
                nameTextBox.Text = row.Cells["LookupCustomerName"].Value.ToString();
                Dispose();
            }
            else
            {
                StatusLabel.Text = "Please select one customer, or press Cancel to return to the Loan form";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            caller.Show();
            Dispose();
        }
    }
}

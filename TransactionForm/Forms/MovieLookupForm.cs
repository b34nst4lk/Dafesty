using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using TransactionForm.Models;

namespace TransactionForm
{
    public partial class MovieLookupForm: Form
    {
        Form caller;
        TextBox idTextBox;
        TextBox nameTextBox;

        DafestyEntities context;

        BindingSource lookupOutput;

        public MovieLookupForm()
        {
            InitializeComponent();
            LookupOutput.AutoGenerateColumns = false;

            context = new DafestyEntities();

            lookupOutput = new BindingSource();
            RefreshLookupOutput();
            LookupOutput.DataSource = lookupOutput;
        }

        public MovieLookupForm(Form caller, TextBox idTextBox, TextBox nameTextBox): this()
        {
            this.caller = caller;
            this.idTextBox = idTextBox;
            this.nameTextBox = nameTextBox;
        }

        // Helper functions
        private void RefreshLookupOutput()
        {
            lookupOutput.DataSource = context.Movies.ToList();
        }

        // Search events

        private void LookUp_KeyUp(object sender, KeyEventArgs e)
        {
            string idSubStr = VideoCode.Text;
            string nameSubStr = MovieTitle.Text;

            lookupOutput.DataSource = context.Movies.Where(x =>
                                        x.MovieTitle.Contains(nameSubStr)
                                        && x.VideoCode.ToString().Contains(idSubStr)).ToList();

            StatusLabel.Text = String.Format("{0} results found.", lookupOutput.Count);
        }

        // Button events

        private void ClearSearch_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "";

            VideoCode.Clear();
            MovieTitle.Clear();
            RefreshLookupOutput();

            StatusLabel.Text = "Search cleared.";
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "";

            if (!(LookupOutput.SelectedCells is null))
            {
                DataGridViewRow row = LookupOutput.Rows[LookupOutput.SelectedCells[0].RowIndex];
                idTextBox.Text = row.Cells["LookupVideoCode"].Value.ToString();
                nameTextBox.Text = row.Cells["LookupMovieTitle"].Value.ToString();
                Dispose();
            }
            else
            {
                StatusLabel.Text = "Please select one movie, or press Cancel to return to the Loan form";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            caller.Show();
            Dispose();
        }
    }
}

using LibraryManagmentSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_UI.ChildrenForms
{
    public partial class LendBook : Form
    {
        public LendBook()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {
            BorrowerModel Borrower = new BorrowerModel();
            Borrower.BookCode = txtBookCode.Text;
            Borrower.PatronId = Int32.Parse(txtPatronId.Text);
            Borrower.ReleaseDate = txtReleaseDate.Text;
            Borrower.DueDate = txtDueDate.Text;
            SqliteDataAccess.AddBorrower(Borrower);
            SqliteDataAccess.DecrementBookNumber(txtBookCode.Text);
            txtBookCode.Text = default;
            txtPatronId.Text = default;
            txtReleaseDate.Text = default;
            txtDueDate.Text = default;
        }
    }
}
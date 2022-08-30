using System;
using System.Collections.Generic;
using LibraryManagmentSystem;
using System.Windows.Forms;

namespace LMS_UI.ChildrenForms
{
    public partial class RemoveBook : Form
    {
        public RemoveBook()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (txtBookCode.Text != default)
            {
                SqliteDataAccess.RemoveBook(txtBookCode.Text);
                txtBookCode.Text = "Deleted";
            }
            else
            {
                txtBookCode.Text = "Could not find";
            }
        }
    }
}
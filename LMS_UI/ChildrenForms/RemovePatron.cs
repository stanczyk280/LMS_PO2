using System;
using System.Collections.Generic;
using LibraryManagmentSystem;
using System.Windows.Forms;

namespace LMS_UI.ChildrenForms
{
    public partial class RemovePatron : Form
    {
        public RemovePatron()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnRemoveId_Click(object sender, EventArgs e)
        {
            if (txtPatronId.Text != default)
            {
                SqliteDataAccess.RemovePatron(txtPatronId.Text);
                txtPatronId.Text = "Deleted";
            }
            else
            {
                txtPatronId.Text = "Could not find";
            }
        }
    }
}
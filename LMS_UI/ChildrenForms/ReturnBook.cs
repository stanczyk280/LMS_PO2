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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnRemoveBorrower_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.RemoveBorrower(txtPatronId.Text);
            txtPatronId.Text = "Deleted";
            txtBookCode.Text = default;
            SqliteDataAccess.IncrementBookNumber(txtBookCode.Text);
            //TO DO
            //RETURN BASED ON RELEASE DATE!
        }
    }
}
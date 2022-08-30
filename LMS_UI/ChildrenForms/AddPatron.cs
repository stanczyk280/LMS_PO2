using System;
using System.Windows.Forms;
using LibraryManagmentSystem;

namespace LMS_UI
{
    public partial class AddPatron : Form
    {
        public AddPatron()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAddPatron_Click(object sender, EventArgs e)
        {
            PatronModel Patron = new PatronModel();
            Patron.Name = txtName.Text;
            Patron.Surname = txtSurname.Text;
            Patron.City = txtCity.Text;
            Patron.Address = txtAddress.Text;
            Patron.BirthDate = txtBirthDate.Text;
            Patron.ContactNumber = txtContactNumber.Text;
            SqliteDataAccess.AddPatron(Patron);
            txtName.Text = default;
            txtSurname.Text = default;
            txtCity.Text = default;
            txtAddress.Text = default;
            txtBirthDate.Text = default;
            txtContactNumber.Text = default;
        }
    }
}
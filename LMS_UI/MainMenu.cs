using LibraryManagmentSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LMS_UI.ChildrenForms;

namespace LMS_UI
{
    public partial class MainMenu : Form
    {
        private Form childForm;
        public List<BookModel> Books { get; set; }
        public List<PatronModel> Patrons { get; set; }
        public List<BorrowerModel> Borrowers { get; set; }

        public enum Model
        {
            Books, Patrons, Borrowers
        }

        public MainMenu()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void CloseForms()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "MainMenu")
                    Application.OpenForms[i].Close();
            }
        }

        #region ListHandling

        public void LoadList(Model m)
        {
            switch (m)
            {
                case Model.Books:
                    {
                        DisplayBooksList();
                        break;
                    }

                case Model.Patrons:
                    {
                        DisplayPatronsList();
                        break;
                    }
                case Model.Borrowers:
                    {
                        DisplayBorrowersList();
                        break;
                    }
            }
        }

        public void ForceColumnLayout()
        {
            dbgList.AutoGenerateColumns = true;
            foreach (DataGridViewColumn column in dbgList.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dbgList.Columns["Id"].Visible = false;
        }

        public void DisplayBooksList()
        {
            Books = SqliteDataAccess.LoadBookModel();
            dbgList.DataSource = null;
            dbgList.DataSource = Books;
            ForceColumnLayout();
        }

        public void DisplayPatronsList()
        {
            Patrons = SqliteDataAccess.LoadPatronModel();
            dbgList.DataSource = null;
            dbgList.DataSource = Patrons;
            dbgList.AutoGenerateColumns = true;
            foreach (DataGridViewColumn column in dbgList.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            };
            dbgList.Columns["BirthDate"].HeaderText = "Birth Date";
            dbgList.Columns["ContactNumber"].HeaderText = "Contact Number";
        }

        public void DisplayBorrowersList()
        {
            Borrowers = SqliteDataAccess.LoadBorrowerModel();
            dbgList.DataSource = null;
            dbgList.DataSource = Borrowers;
            ForceColumnLayout();
            dbgList.Columns["BookCode"].HeaderText = "Book Code";
            dbgList.Columns["PatronId"].HeaderText = "Patron Id";
            dbgList.Columns["ReleaseDate"].HeaderText = "Release Date";
            dbgList.Columns["DueDate"].HeaderText = "Due Date";
        }

        #endregion ListHandling

        #region ButtonHandling

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            CloseForms();
            childForm = new FormAddBook();
            childForm.Show();
        }

        private void btnAddPatron_Click(object sender, EventArgs e)
        {
            CloseForms();
            childForm = new AddPatron();
            childForm.Show();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            CloseForms();
            childForm = new SearchBook();
            childForm.Show();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            CloseForms();
            childForm = new RemoveBook();
            childForm.Show();
        }

        private void btnRemovePatron_Click(object sender, EventArgs e)
        {
            CloseForms();
            childForm = new RemovePatron();
            childForm.Show();
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            LoadList(Model.Books);
        }

        private void btnPatronList_Click(object sender, EventArgs e)
        {
            LoadList(Model.Patrons);
        }

        private void btnBorrowerList_Click(object sender, EventArgs e)
        {
            LoadList(Model.Borrowers);
        }

        private void btnLendBook_Click(object sender, EventArgs e)
        {
            CloseForms();
            childForm = new LendBook();
            childForm.Show();
        }

        #endregion ButtonHandling
    }
}
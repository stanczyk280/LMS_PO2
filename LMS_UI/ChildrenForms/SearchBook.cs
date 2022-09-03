using System;
using System.Collections.Generic;
using LibraryManagmentSystem;
using System.Windows.Forms;

namespace LMS_UI
{
    public partial class SearchBook : Form
    {
        public List<BookModel> Books { get; set; }

        public void ForceColumnLayout()
        {
            dbgSearchResult.AutoGenerateColumns = true;
            foreach (DataGridViewColumn column in dbgSearchResult.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dbgSearchResult.Columns["Id"].Visible = false;
        }

        public SearchBook()
        {
            InitializeComponent();
            HidePanels();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void HidePanels()
        {
            pnlByAuthorSubMenu.Visible = false;
            pnlByBookCodeSubMenu.Visible = false;
            pnlByCategorySubMenu.Visible = false;
            pnlByTitleSubMenu.Visible = false;
        }

        private void TogglePanel(Panel panel)
        {
            HidePanels();
            panel.Visible = !panel.Visible;
        }

        private void buttonByTitle_Click(object sender, EventArgs e)
        {
            TogglePanel(pnlByTitleSubMenu);
        }

        private void btnByAuthor_Click(object sender, EventArgs e)
        {
            TogglePanel(pnlByAuthorSubMenu);
        }

        private void btnByCategory_Click(object sender, EventArgs e)
        {
            TogglePanel(pnlByCategorySubMenu);
        }

        private void btnByBookCode_Click(object sender, EventArgs e)
        {
            TogglePanel(pnlByBookCodeSubMenu);
        }

        private void btnSearchTitle_Click(object sender, EventArgs e)
        {
            dbgSearchResult.DataSource = null;
            if (txtByTitle.Text != default)
            {
                Books = SqliteDataAccess.SearchByTitle(txtByTitle.Text);
                dbgSearchResult.DataSource = Books;
                ForceColumnLayout();
            }
            txtByTitle.Text = default;
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            dbgSearchResult.DataSource = null;
            if (txtByAuthor.Text != default)
            {
                Books = SqliteDataAccess.SearchByAuthor(txtByAuthor.Text);
                dbgSearchResult.DataSource = Books;
                ForceColumnLayout();
            }
            txtByAuthor.Text = default;
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            dbgSearchResult.DataSource = null;
            if (txtByCategory.Text != default)
            {
                Books = SqliteDataAccess.SearchByCategory(txtByCategory.Text);
                dbgSearchResult.DataSource = Books;
                ForceColumnLayout();
            }
            txtByCategory.Text = default;
        }

        private void btnSearchBookCode_Click(object sender, EventArgs e)
        {
            dbgSearchResult.DataSource = null;
            if (txtByBookCode.Text != default)
            {
                Books = SqliteDataAccess.SearchByCode(txtByBookCode.Text);
                dbgSearchResult.DataSource = Books;
                ForceColumnLayout();
            }
            txtByBookCode.Text = default;
        }
    }
}
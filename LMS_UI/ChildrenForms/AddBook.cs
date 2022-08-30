using LibraryManagmentSystem;
using System;
using System.Windows.Forms;

namespace LMS_UI
{
    public partial class FormAddBook : Form
    {
        public FormAddBook()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            BookModel book = new BookModel();
            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.Publisher = txtPublisher.Text;
            book.Category = txtCategory.Text;
            book.Copies = int.Parse(txtCopies.Text);
            book.Code = txtCode.Text;
            SqliteDataAccess.AddBook(book);
            txtTitle.Text = default;
            txtAuthor.Text = default;
            txtPublisher.Text = default;
            txtCategory.Text = default;
            txtCopies.Text = default;
            txtCode.Text = default;
        }
    }
}
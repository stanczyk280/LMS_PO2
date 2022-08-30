namespace LMS_UI
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnRemovePatron = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnBorrowerList = new System.Windows.Forms.Button();
            this.btnPatronList = new System.Windows.Forms.Button();
            this.btnBookList = new System.Windows.Forms.Button();
            this.btnViewBook = new System.Windows.Forms.Button();
            this.btnLendBook = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnAddPatron = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.dbgList = new System.Windows.Forms.DataGridView();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSideMenu.Controls.Add(this.btnRemovePatron);
            this.pnlSideMenu.Controls.Add(this.btnRemoveBook);
            this.pnlSideMenu.Controls.Add(this.btnBorrowerList);
            this.pnlSideMenu.Controls.Add(this.btnPatronList);
            this.pnlSideMenu.Controls.Add(this.btnBookList);
            this.pnlSideMenu.Controls.Add(this.btnViewBook);
            this.pnlSideMenu.Controls.Add(this.btnLendBook);
            this.pnlSideMenu.Controls.Add(this.btnSearchBook);
            this.pnlSideMenu.Controls.Add(this.btnAddPatron);
            this.pnlSideMenu.Controls.Add(this.btnAddBook);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(303, 636);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnRemovePatron
            // 
            this.btnRemovePatron.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemovePatron.FlatAppearance.BorderSize = 0;
            this.btnRemovePatron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePatron.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRemovePatron.Location = new System.Drawing.Point(0, 564);
            this.btnRemovePatron.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemovePatron.Name = "btnRemovePatron";
            this.btnRemovePatron.Size = new System.Drawing.Size(303, 46);
            this.btnRemovePatron.TabIndex = 10;
            this.btnRemovePatron.Text = "Remove Patron";
            this.btnRemovePatron.UseVisualStyleBackColor = true;
            this.btnRemovePatron.Click += new System.EventHandler(this.btnRemovePatron_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveBook.FlatAppearance.BorderSize = 0;
            this.btnRemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveBook.Location = new System.Drawing.Point(0, 518);
            this.btnRemoveBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(303, 46);
            this.btnRemoveBook.TabIndex = 9;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnBorrowerList
            // 
            this.btnBorrowerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowerList.FlatAppearance.BorderSize = 0;
            this.btnBorrowerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowerList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBorrowerList.Location = new System.Drawing.Point(0, 472);
            this.btnBorrowerList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrowerList.Name = "btnBorrowerList";
            this.btnBorrowerList.Size = new System.Drawing.Size(303, 46);
            this.btnBorrowerList.TabIndex = 8;
            this.btnBorrowerList.Text = "Borrower List";
            this.btnBorrowerList.UseVisualStyleBackColor = true;
            this.btnBorrowerList.Click += new System.EventHandler(this.btnBorrowerList_Click);
            // 
            // btnPatronList
            // 
            this.btnPatronList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatronList.FlatAppearance.BorderSize = 0;
            this.btnPatronList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatronList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPatronList.Location = new System.Drawing.Point(0, 426);
            this.btnPatronList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPatronList.Name = "btnPatronList";
            this.btnPatronList.Size = new System.Drawing.Size(303, 46);
            this.btnPatronList.TabIndex = 7;
            this.btnPatronList.Text = "Patron List";
            this.btnPatronList.UseVisualStyleBackColor = true;
            this.btnPatronList.Click += new System.EventHandler(this.btnPatronList_Click);
            // 
            // btnBookList
            // 
            this.btnBookList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookList.FlatAppearance.BorderSize = 0;
            this.btnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBookList.Location = new System.Drawing.Point(0, 380);
            this.btnBookList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(303, 46);
            this.btnBookList.TabIndex = 6;
            this.btnBookList.Text = "Book List";
            this.btnBookList.UseVisualStyleBackColor = true;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // btnViewBook
            // 
            this.btnViewBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewBook.FlatAppearance.BorderSize = 0;
            this.btnViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewBook.Location = new System.Drawing.Point(0, 334);
            this.btnViewBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewBook.Name = "btnViewBook";
            this.btnViewBook.Size = new System.Drawing.Size(303, 46);
            this.btnViewBook.TabIndex = 5;
            this.btnViewBook.Text = "Return Book";
            this.btnViewBook.UseVisualStyleBackColor = true;
            // 
            // btnLendBook
            // 
            this.btnLendBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLendBook.FlatAppearance.BorderSize = 0;
            this.btnLendBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLendBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLendBook.Location = new System.Drawing.Point(0, 288);
            this.btnLendBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLendBook.Name = "btnLendBook";
            this.btnLendBook.Size = new System.Drawing.Size(303, 46);
            this.btnLendBook.TabIndex = 4;
            this.btnLendBook.Text = "Lend Book";
            this.btnLendBook.UseVisualStyleBackColor = true;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchBook.FlatAppearance.BorderSize = 0;
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchBook.Location = new System.Drawing.Point(0, 242);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(303, 46);
            this.btnSearchBook.TabIndex = 3;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnAddPatron
            // 
            this.btnAddPatron.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPatron.FlatAppearance.BorderSize = 0;
            this.btnAddPatron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatron.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddPatron.Location = new System.Drawing.Point(0, 196);
            this.btnAddPatron.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddPatron.Name = "btnAddPatron";
            this.btnAddPatron.Size = new System.Drawing.Size(303, 46);
            this.btnAddPatron.TabIndex = 2;
            this.btnAddPatron.Text = "Add Patron";
            this.btnAddPatron.UseVisualStyleBackColor = true;
            this.btnAddPatron.Click += new System.EventHandler(this.btnAddPatron_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddBook.Location = new System.Drawing.Point(0, 150);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(303, 46);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(303, 150);
            this.pnlLogo.TabIndex = 0;
            // 
            // dbgList
            // 
            this.dbgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgList.Location = new System.Drawing.Point(303, 0);
            this.dbgList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dbgList.Name = "dbgList";
            this.dbgList.Size = new System.Drawing.Size(658, 636);
            this.dbgList.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(961, 636);
            this.Controls.Add(this.dbgList);
            this.Controls.Add(this.pnlSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(977, 675);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dusty Library Managment System";
            this.pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnBorrowerList;
        private System.Windows.Forms.Button btnPatronList;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Button btnViewBook;
        private System.Windows.Forms.Button btnLendBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnAddPatron;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.DataGridView dbgList;
        private System.Windows.Forms.Button btnRemovePatron;
    }
}
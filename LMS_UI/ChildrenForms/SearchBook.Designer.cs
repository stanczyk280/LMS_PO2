namespace LMS_UI
{
    partial class SearchBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBook));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlByBookCodeSubMenu = new System.Windows.Forms.Panel();
            this.btnSearchBookCode = new System.Windows.Forms.Button();
            this.txtByBookCode = new System.Windows.Forms.TextBox();
            this.btnByBookCode = new System.Windows.Forms.Button();
            this.pnlByCategorySubMenu = new System.Windows.Forms.Panel();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.txtByCategory = new System.Windows.Forms.TextBox();
            this.btnByCategory = new System.Windows.Forms.Button();
            this.pnlByAuthorSubMenu = new System.Windows.Forms.Panel();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.txtByAuthor = new System.Windows.Forms.TextBox();
            this.btnByAuthor = new System.Windows.Forms.Button();
            this.pnlByTitleSubMenu = new System.Windows.Forms.Panel();
            this.btnSearchTitle = new System.Windows.Forms.Button();
            this.txtByTitle = new System.Windows.Forms.TextBox();
            this.buttonByTitle = new System.Windows.Forms.Button();
            this.dbgSearchResult = new System.Windows.Forms.DataGridView();
            this.pnlSideMenu.SuspendLayout();
            this.pnlByBookCodeSubMenu.SuspendLayout();
            this.pnlByCategorySubMenu.SuspendLayout();
            this.pnlByAuthorSubMenu.SuspendLayout();
            this.pnlByTitleSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Controls.Add(this.pnlByBookCodeSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnByBookCode);
            this.pnlSideMenu.Controls.Add(this.pnlByCategorySubMenu);
            this.pnlSideMenu.Controls.Add(this.btnByCategory);
            this.pnlSideMenu.Controls.Add(this.pnlByAuthorSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnByAuthor);
            this.pnlSideMenu.Controls.Add(this.pnlByTitleSubMenu);
            this.pnlSideMenu.Controls.Add(this.buttonByTitle);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(199, 341);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // pnlByBookCodeSubMenu
            // 
            this.pnlByBookCodeSubMenu.Controls.Add(this.btnSearchBookCode);
            this.pnlByBookCodeSubMenu.Controls.Add(this.txtByBookCode);
            this.pnlByBookCodeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlByBookCodeSubMenu.Location = new System.Drawing.Point(0, 275);
            this.pnlByBookCodeSubMenu.Name = "pnlByBookCodeSubMenu";
            this.pnlByBookCodeSubMenu.Size = new System.Drawing.Size(199, 25);
            this.pnlByBookCodeSubMenu.TabIndex = 7;
            // 
            // btnSearchBookCode
            // 
            this.btnSearchBookCode.BackColor = System.Drawing.Color.Silver;
            this.btnSearchBookCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearchBookCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchBookCode.FlatAppearance.BorderSize = 0;
            this.btnSearchBookCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBookCode.Location = new System.Drawing.Point(143, 0);
            this.btnSearchBookCode.Name = "btnSearchBookCode";
            this.btnSearchBookCode.Size = new System.Drawing.Size(56, 25);
            this.btnSearchBookCode.TabIndex = 2;
            this.btnSearchBookCode.Text = "Search";
            this.btnSearchBookCode.UseVisualStyleBackColor = false;
            this.btnSearchBookCode.Click += new System.EventHandler(this.btnSearchBookCode_Click);
            // 
            // txtByBookCode
            // 
            this.txtByBookCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtByBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtByBookCode.Location = new System.Drawing.Point(0, 0);
            this.txtByBookCode.Name = "txtByBookCode";
            this.txtByBookCode.Size = new System.Drawing.Size(143, 23);
            this.txtByBookCode.TabIndex = 1;
            // 
            // btnByBookCode
            // 
            this.btnByBookCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnByBookCode.FlatAppearance.BorderSize = 0;
            this.btnByBookCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnByBookCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnByBookCode.Location = new System.Drawing.Point(0, 225);
            this.btnByBookCode.Name = "btnByBookCode";
            this.btnByBookCode.Size = new System.Drawing.Size(199, 50);
            this.btnByBookCode.TabIndex = 6;
            this.btnByBookCode.Text = "Search by Book Code";
            this.btnByBookCode.UseVisualStyleBackColor = true;
            this.btnByBookCode.Click += new System.EventHandler(this.btnByBookCode_Click);
            // 
            // pnlByCategorySubMenu
            // 
            this.pnlByCategorySubMenu.Controls.Add(this.btnSearchCategory);
            this.pnlByCategorySubMenu.Controls.Add(this.txtByCategory);
            this.pnlByCategorySubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlByCategorySubMenu.Location = new System.Drawing.Point(0, 200);
            this.pnlByCategorySubMenu.Name = "pnlByCategorySubMenu";
            this.pnlByCategorySubMenu.Size = new System.Drawing.Size(199, 25);
            this.pnlByCategorySubMenu.TabIndex = 5;
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.BackColor = System.Drawing.Color.Silver;
            this.btnSearchCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearchCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchCategory.FlatAppearance.BorderSize = 0;
            this.btnSearchCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCategory.Location = new System.Drawing.Point(143, 0);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(56, 25);
            this.btnSearchCategory.TabIndex = 2;
            this.btnSearchCategory.Text = "Search";
            this.btnSearchCategory.UseVisualStyleBackColor = false;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // txtByCategory
            // 
            this.txtByCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtByCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtByCategory.Location = new System.Drawing.Point(0, 0);
            this.txtByCategory.Name = "txtByCategory";
            this.txtByCategory.Size = new System.Drawing.Size(143, 23);
            this.txtByCategory.TabIndex = 1;
            // 
            // btnByCategory
            // 
            this.btnByCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnByCategory.FlatAppearance.BorderSize = 0;
            this.btnByCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnByCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnByCategory.Location = new System.Drawing.Point(0, 150);
            this.btnByCategory.Name = "btnByCategory";
            this.btnByCategory.Size = new System.Drawing.Size(199, 50);
            this.btnByCategory.TabIndex = 4;
            this.btnByCategory.Text = "Search by Category";
            this.btnByCategory.UseVisualStyleBackColor = true;
            this.btnByCategory.Click += new System.EventHandler(this.btnByCategory_Click);
            // 
            // pnlByAuthorSubMenu
            // 
            this.pnlByAuthorSubMenu.Controls.Add(this.btnSearchAuthor);
            this.pnlByAuthorSubMenu.Controls.Add(this.txtByAuthor);
            this.pnlByAuthorSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlByAuthorSubMenu.Location = new System.Drawing.Point(0, 125);
            this.pnlByAuthorSubMenu.Name = "pnlByAuthorSubMenu";
            this.pnlByAuthorSubMenu.Size = new System.Drawing.Size(199, 25);
            this.pnlByAuthorSubMenu.TabIndex = 3;
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.BackColor = System.Drawing.Color.Silver;
            this.btnSearchAuthor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearchAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchAuthor.FlatAppearance.BorderSize = 0;
            this.btnSearchAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAuthor.Location = new System.Drawing.Point(143, 0);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(56, 25);
            this.btnSearchAuthor.TabIndex = 2;
            this.btnSearchAuthor.Text = "Search";
            this.btnSearchAuthor.UseVisualStyleBackColor = false;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // txtByAuthor
            // 
            this.txtByAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtByAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtByAuthor.Location = new System.Drawing.Point(0, 0);
            this.txtByAuthor.Name = "txtByAuthor";
            this.txtByAuthor.Size = new System.Drawing.Size(143, 23);
            this.txtByAuthor.TabIndex = 1;
            // 
            // btnByAuthor
            // 
            this.btnByAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnByAuthor.FlatAppearance.BorderSize = 0;
            this.btnByAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnByAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnByAuthor.Location = new System.Drawing.Point(0, 75);
            this.btnByAuthor.Name = "btnByAuthor";
            this.btnByAuthor.Size = new System.Drawing.Size(199, 50);
            this.btnByAuthor.TabIndex = 2;
            this.btnByAuthor.Text = "Search by Author";
            this.btnByAuthor.UseVisualStyleBackColor = true;
            this.btnByAuthor.Click += new System.EventHandler(this.btnByAuthor_Click);
            // 
            // pnlByTitleSubMenu
            // 
            this.pnlByTitleSubMenu.Controls.Add(this.btnSearchTitle);
            this.pnlByTitleSubMenu.Controls.Add(this.txtByTitle);
            this.pnlByTitleSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlByTitleSubMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlByTitleSubMenu.Name = "pnlByTitleSubMenu";
            this.pnlByTitleSubMenu.Size = new System.Drawing.Size(199, 25);
            this.pnlByTitleSubMenu.TabIndex = 1;
            // 
            // btnSearchTitle
            // 
            this.btnSearchTitle.BackColor = System.Drawing.Color.Silver;
            this.btnSearchTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearchTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchTitle.FlatAppearance.BorderSize = 0;
            this.btnSearchTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTitle.Location = new System.Drawing.Point(143, 0);
            this.btnSearchTitle.Name = "btnSearchTitle";
            this.btnSearchTitle.Size = new System.Drawing.Size(56, 25);
            this.btnSearchTitle.TabIndex = 1;
            this.btnSearchTitle.Text = "Search";
            this.btnSearchTitle.UseVisualStyleBackColor = false;
            this.btnSearchTitle.Click += new System.EventHandler(this.btnSearchTitle_Click);
            // 
            // txtByTitle
            // 
            this.txtByTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtByTitle.Location = new System.Drawing.Point(0, 0);
            this.txtByTitle.Name = "txtByTitle";
            this.txtByTitle.Size = new System.Drawing.Size(143, 23);
            this.txtByTitle.TabIndex = 0;
            // 
            // buttonByTitle
            // 
            this.buttonByTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonByTitle.FlatAppearance.BorderSize = 0;
            this.buttonByTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonByTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonByTitle.Location = new System.Drawing.Point(0, 0);
            this.buttonByTitle.Name = "buttonByTitle";
            this.buttonByTitle.Size = new System.Drawing.Size(199, 50);
            this.buttonByTitle.TabIndex = 0;
            this.buttonByTitle.Text = "Search by Title";
            this.buttonByTitle.UseVisualStyleBackColor = true;
            this.buttonByTitle.Click += new System.EventHandler(this.buttonByTitle_Click);
            // 
            // dbgSearchResult
            // 
            this.dbgSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgSearchResult.Location = new System.Drawing.Point(199, 0);
            this.dbgSearchResult.Name = "dbgSearchResult";
            this.dbgSearchResult.Size = new System.Drawing.Size(498, 341);
            this.dbgSearchResult.TabIndex = 1;
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(697, 341);
            this.Controls.Add(this.dbgSearchResult);
            this.Controls.Add(this.pnlSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Book";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlByBookCodeSubMenu.ResumeLayout(false);
            this.pnlByBookCodeSubMenu.PerformLayout();
            this.pnlByCategorySubMenu.ResumeLayout(false);
            this.pnlByCategorySubMenu.PerformLayout();
            this.pnlByAuthorSubMenu.ResumeLayout(false);
            this.pnlByAuthorSubMenu.PerformLayout();
            this.pnlByTitleSubMenu.ResumeLayout(false);
            this.pnlByTitleSubMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlByTitleSubMenu;
        private System.Windows.Forms.TextBox txtByTitle;
        private System.Windows.Forms.Button buttonByTitle;
        private System.Windows.Forms.Panel pnlByCategorySubMenu;
        private System.Windows.Forms.TextBox txtByCategory;
        private System.Windows.Forms.Button btnByCategory;
        private System.Windows.Forms.Panel pnlByAuthorSubMenu;
        private System.Windows.Forms.TextBox txtByAuthor;
        private System.Windows.Forms.Button btnByAuthor;
        private System.Windows.Forms.Panel pnlByBookCodeSubMenu;
        private System.Windows.Forms.TextBox txtByBookCode;
        private System.Windows.Forms.Button btnByBookCode;
        private System.Windows.Forms.DataGridView dbgSearchResult;
        private System.Windows.Forms.Button btnSearchBookCode;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.Button btnSearchTitle;
    }
}
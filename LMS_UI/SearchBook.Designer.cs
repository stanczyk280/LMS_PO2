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
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlByBookCodeSubMenu = new System.Windows.Forms.Panel();
            this.txtByBookCode = new System.Windows.Forms.TextBox();
            this.btnByBookCode = new System.Windows.Forms.Button();
            this.pnlByCategorySubMenu = new System.Windows.Forms.Panel();
            this.txtByCategory = new System.Windows.Forms.TextBox();
            this.btnByCategory = new System.Windows.Forms.Button();
            this.pnlByAuthorSubMenu = new System.Windows.Forms.Panel();
            this.txtByAuthor = new System.Windows.Forms.TextBox();
            this.btnByAuthor = new System.Windows.Forms.Button();
            this.pnlByTitleSubMenu = new System.Windows.Forms.Panel();
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
            this.pnlSideMenu.Controls.Add(this.btnSearch);
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
            this.pnlSideMenu.Size = new System.Drawing.Size(127, 341);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(0, 300);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 30);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlByBookCodeSubMenu
            // 
            this.pnlByBookCodeSubMenu.Controls.Add(this.txtByBookCode);
            this.pnlByBookCodeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlByBookCodeSubMenu.Location = new System.Drawing.Point(0, 275);
            this.pnlByBookCodeSubMenu.Name = "pnlByBookCodeSubMenu";
            this.pnlByBookCodeSubMenu.Size = new System.Drawing.Size(127, 25);
            this.pnlByBookCodeSubMenu.TabIndex = 7;
            // 
            // txtByBookCode
            // 
            this.txtByBookCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtByBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtByBookCode.Location = new System.Drawing.Point(0, 0);
            this.txtByBookCode.Name = "txtByBookCode";
            this.txtByBookCode.Size = new System.Drawing.Size(127, 23);
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
            this.btnByBookCode.Size = new System.Drawing.Size(127, 50);
            this.btnByBookCode.TabIndex = 6;
            this.btnByBookCode.Text = "Search by Book Code";
            this.btnByBookCode.UseVisualStyleBackColor = true;
            this.btnByBookCode.Click += new System.EventHandler(this.btnByBookCode_Click);
            // 
            // pnlByCategorySubMenu
            // 
            this.pnlByCategorySubMenu.Controls.Add(this.txtByCategory);
            this.pnlByCategorySubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlByCategorySubMenu.Location = new System.Drawing.Point(0, 200);
            this.pnlByCategorySubMenu.Name = "pnlByCategorySubMenu";
            this.pnlByCategorySubMenu.Size = new System.Drawing.Size(127, 25);
            this.pnlByCategorySubMenu.TabIndex = 5;
            // 
            // txtByCategory
            // 
            this.txtByCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtByCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtByCategory.Location = new System.Drawing.Point(0, 0);
            this.txtByCategory.Name = "txtByCategory";
            this.txtByCategory.Size = new System.Drawing.Size(127, 23);
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
            this.btnByCategory.Size = new System.Drawing.Size(127, 50);
            this.btnByCategory.TabIndex = 4;
            this.btnByCategory.Text = "Search by Category";
            this.btnByCategory.UseVisualStyleBackColor = true;
            this.btnByCategory.Click += new System.EventHandler(this.btnByCategory_Click);
            // 
            // pnlByAuthorSubMenu
            // 
            this.pnlByAuthorSubMenu.Controls.Add(this.txtByAuthor);
            this.pnlByAuthorSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlByAuthorSubMenu.Location = new System.Drawing.Point(0, 125);
            this.pnlByAuthorSubMenu.Name = "pnlByAuthorSubMenu";
            this.pnlByAuthorSubMenu.Size = new System.Drawing.Size(127, 25);
            this.pnlByAuthorSubMenu.TabIndex = 3;
            // 
            // txtByAuthor
            // 
            this.txtByAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtByAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtByAuthor.Location = new System.Drawing.Point(0, 0);
            this.txtByAuthor.Name = "txtByAuthor";
            this.txtByAuthor.Size = new System.Drawing.Size(127, 23);
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
            this.btnByAuthor.Size = new System.Drawing.Size(127, 50);
            this.btnByAuthor.TabIndex = 2;
            this.btnByAuthor.Text = "Search by Author";
            this.btnByAuthor.UseVisualStyleBackColor = true;
            this.btnByAuthor.Click += new System.EventHandler(this.btnByAuthor_Click);
            // 
            // pnlByTitleSubMenu
            // 
            this.pnlByTitleSubMenu.Controls.Add(this.txtByTitle);
            this.pnlByTitleSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlByTitleSubMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlByTitleSubMenu.Name = "pnlByTitleSubMenu";
            this.pnlByTitleSubMenu.Size = new System.Drawing.Size(127, 25);
            this.pnlByTitleSubMenu.TabIndex = 1;
            // 
            // txtByTitle
            // 
            this.txtByTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtByTitle.Location = new System.Drawing.Point(0, 0);
            this.txtByTitle.Name = "txtByTitle";
            this.txtByTitle.Size = new System.Drawing.Size(127, 23);
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
            this.buttonByTitle.Size = new System.Drawing.Size(127, 50);
            this.buttonByTitle.TabIndex = 0;
            this.buttonByTitle.Text = "Search by Title";
            this.buttonByTitle.UseVisualStyleBackColor = true;
            this.buttonByTitle.Click += new System.EventHandler(this.buttonByTitle_Click);
            // 
            // dbgSearchResult
            // 
            this.dbgSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgSearchResult.Location = new System.Drawing.Point(127, 0);
            this.dbgSearchResult.Name = "dbgSearchResult";
            this.dbgSearchResult.Size = new System.Drawing.Size(237, 341);
            this.dbgSearchResult.TabIndex = 1;
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(364, 341);
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
        private System.Windows.Forms.Button btnSearch;
    }
}
namespace LMS_UI.ChildrenForms
{
    partial class LendBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendBook));
            this.lblBookCode = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.lblPatronId = new System.Windows.Forms.Label();
            this.txtPatronId = new System.Windows.Forms.TextBox();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.pnlPublisher = new System.Windows.Forms.Panel();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.btnAddBorrower = new System.Windows.Forms.Button();
            this.pnlPublisher.SuspendLayout();
            this.pnlAuthor.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookCode
            // 
            this.lblBookCode.AutoSize = true;
            this.lblBookCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBookCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBookCode.Location = new System.Drawing.Point(13, 0);
            this.lblBookCode.Name = "lblBookCode";
            this.lblBookCode.Size = new System.Drawing.Size(81, 17);
            this.lblBookCode.TabIndex = 1;
            this.lblBookCode.Text = "Book Code:";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReleaseDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblReleaseDate.Location = new System.Drawing.Point(-4, 0);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(98, 17);
            this.lblReleaseDate.TabIndex = 2;
            this.lblReleaseDate.Text = "Release Date:";
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReleaseDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtReleaseDate.Location = new System.Drawing.Point(94, 0);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(200, 20);
            this.txtReleaseDate.TabIndex = 1;
            // 
            // lblPatronId
            // 
            this.lblPatronId.AutoSize = true;
            this.lblPatronId.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPatronId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPatronId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPatronId.Location = new System.Drawing.Point(23, 0);
            this.lblPatronId.Name = "lblPatronId";
            this.lblPatronId.Size = new System.Drawing.Size(71, 17);
            this.lblPatronId.TabIndex = 2;
            this.lblPatronId.Text = "Patron ID:";
            // 
            // txtPatronId
            // 
            this.txtPatronId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatronId.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPatronId.Location = new System.Drawing.Point(94, 0);
            this.txtPatronId.Name = "txtPatronId";
            this.txtPatronId.Size = new System.Drawing.Size(200, 20);
            this.txtPatronId.TabIndex = 1;
            // 
            // txtBookCode
            // 
            this.txtBookCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtBookCode.Location = new System.Drawing.Point(94, 0);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(200, 20);
            this.txtBookCode.TabIndex = 0;
            // 
            // pnlPublisher
            // 
            this.pnlPublisher.Controls.Add(this.lblReleaseDate);
            this.pnlPublisher.Controls.Add(this.txtReleaseDate);
            this.pnlPublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPublisher.Location = new System.Drawing.Point(0, 42);
            this.pnlPublisher.Name = "pnlPublisher";
            this.pnlPublisher.Size = new System.Drawing.Size(294, 21);
            this.pnlPublisher.TabIndex = 5;
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.Controls.Add(this.lblPatronId);
            this.pnlAuthor.Controls.Add(this.txtPatronId);
            this.pnlAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAuthor.Location = new System.Drawing.Point(0, 21);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(294, 21);
            this.pnlAuthor.TabIndex = 4;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblBookCode);
            this.pnlTitle.Controls.Add(this.txtBookCode);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(294, 21);
            this.pnlTitle.TabIndex = 3;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDueDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDueDate.Location = new System.Drawing.Point(22, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(72, 17);
            this.lblDueDate.TabIndex = 2;
            this.lblDueDate.Text = "Due Date:";
            // 
            // txtDueDate
            // 
            this.txtDueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDueDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDueDate.Location = new System.Drawing.Point(94, 0);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(200, 20);
            this.txtDueDate.TabIndex = 1;
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.lblDueDate);
            this.pnlCategory.Controls.Add(this.txtDueDate);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 63);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(294, 21);
            this.pnlCategory.TabIndex = 6;
            // 
            // btnAddBorrower
            // 
            this.btnAddBorrower.BackColor = System.Drawing.Color.Silver;
            this.btnAddBorrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBorrower.Location = new System.Drawing.Point(0, 84);
            this.btnAddBorrower.Name = "btnAddBorrower";
            this.btnAddBorrower.Size = new System.Drawing.Size(294, 46);
            this.btnAddBorrower.TabIndex = 7;
            this.btnAddBorrower.Text = "Lend Book";
            this.btnAddBorrower.UseVisualStyleBackColor = false;
            this.btnAddBorrower.Click += new System.EventHandler(this.btnAddBorrower_Click);
            // 
            // LendBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(294, 130);
            this.Controls.Add(this.btnAddBorrower);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.pnlPublisher);
            this.Controls.Add(this.pnlAuthor);
            this.Controls.Add(this.pnlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LendBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LendBook";
            this.pnlPublisher.ResumeLayout(false);
            this.pnlPublisher.PerformLayout();
            this.pnlAuthor.ResumeLayout(false);
            this.pnlAuthor.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.TextBox txtReleaseDate;
        private System.Windows.Forms.Label lblPatronId;
        private System.Windows.Forms.TextBox txtPatronId;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Panel pnlPublisher;
        private System.Windows.Forms.Panel pnlAuthor;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Button btnAddBorrower;
    }
}
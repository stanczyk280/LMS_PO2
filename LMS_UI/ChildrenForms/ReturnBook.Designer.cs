﻿namespace LMS_UI.ChildrenForms
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.lblBookCode = new System.Windows.Forms.Label();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.txtPatronId = new System.Windows.Forms.TextBox();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.lblPatronId = new System.Windows.Forms.Label();
            this.btnRemoveBorrower = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlAuthor.SuspendLayout();
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
            // txtBookCode
            // 
            this.txtBookCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtBookCode.Location = new System.Drawing.Point(94, 0);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(200, 20);
            this.txtBookCode.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblBookCode);
            this.pnlTitle.Controls.Add(this.txtBookCode);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(294, 21);
            this.pnlTitle.TabIndex = 4;
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
            // pnlAuthor
            // 
            this.pnlAuthor.Controls.Add(this.lblPatronId);
            this.pnlAuthor.Controls.Add(this.txtPatronId);
            this.pnlAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAuthor.Location = new System.Drawing.Point(0, 21);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(294, 21);
            this.pnlAuthor.TabIndex = 5;
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
            // btnRemoveBorrower
            // 
            this.btnRemoveBorrower.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveBorrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBorrower.Location = new System.Drawing.Point(0, 42);
            this.btnRemoveBorrower.Name = "btnRemoveBorrower";
            this.btnRemoveBorrower.Size = new System.Drawing.Size(294, 44);
            this.btnRemoveBorrower.TabIndex = 8;
            this.btnRemoveBorrower.Text = "Return Book";
            this.btnRemoveBorrower.UseVisualStyleBackColor = false;
            this.btnRemoveBorrower.Click += new System.EventHandler(this.btnRemoveBorrower_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(294, 86);
            this.Controls.Add(this.btnRemoveBorrower);
            this.Controls.Add(this.pnlAuthor);
            this.Controls.Add(this.pnlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlAuthor.ResumeLayout(false);
            this.pnlAuthor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.TextBox txtPatronId;
        private System.Windows.Forms.Panel pnlAuthor;
        private System.Windows.Forms.Label lblPatronId;
        private System.Windows.Forms.Button btnRemoveBorrower;
    }
}
namespace LMS_UI.ChildrenForms
{
    partial class RemoveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveBook));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblBookCode = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblBookCode);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(284, 35);
            this.pnlTop.TabIndex = 0;
            // 
            // lblBookCode
            // 
            this.lblBookCode.AutoSize = true;
            this.lblBookCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBookCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBookCode.Location = new System.Drawing.Point(0, 0);
            this.lblBookCode.Name = "lblBookCode";
            this.lblBookCode.Padding = new System.Windows.Forms.Padding(68, 0, 0, 0);
            this.lblBookCode.Size = new System.Drawing.Size(222, 25);
            this.lblBookCode.TabIndex = 0;
            this.lblBookCode.Text = "Enter book code";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnRemoveBook);
            this.pnlBottom.Controls.Add(this.txtBookCode);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 35);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(284, 54);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBook.Location = new System.Drawing.Point(0, 23);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(284, 31);
            this.btnRemoveBook.TabIndex = 7;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = false;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // txtBookCode
            // 
            this.txtBookCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBookCode.Location = new System.Drawing.Point(0, 0);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(284, 23);
            this.txtBookCode.TabIndex = 0;
            // 
            // RemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(284, 89);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveBook";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Book";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Button btnRemoveBook;
    }
}
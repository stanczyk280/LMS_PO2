namespace LMS_UI.ChildrenForms
{
    partial class RemovePatron
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemovePatron));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblPatronId = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnRemoveId = new System.Windows.Forms.Button();
            this.txtPatronId = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblPatronId);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(284, 35);
            this.pnlTop.TabIndex = 1;
            // 
            // lblPatronId
            // 
            this.lblPatronId.AutoSize = true;
            this.lblPatronId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPatronId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPatronId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPatronId.Location = new System.Drawing.Point(0, 0);
            this.lblPatronId.Name = "lblPatronId";
            this.lblPatronId.Padding = new System.Windows.Forms.Padding(68, 0, 0, 0);
            this.lblPatronId.Size = new System.Drawing.Size(209, 25);
            this.lblPatronId.TabIndex = 0;
            this.lblPatronId.Text = "Enter Patron Id";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnRemoveId);
            this.pnlBottom.Controls.Add(this.txtPatronId);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 35);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(284, 54);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnRemoveId
            // 
            this.btnRemoveId.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveId.Location = new System.Drawing.Point(0, 23);
            this.btnRemoveId.Name = "btnRemoveId";
            this.btnRemoveId.Size = new System.Drawing.Size(284, 31);
            this.btnRemoveId.TabIndex = 7;
            this.btnRemoveId.Text = "Remove Patron";
            this.btnRemoveId.UseVisualStyleBackColor = false;
            this.btnRemoveId.Click += new System.EventHandler(this.btnRemoveId_Click);
            // 
            // txtPatronId
            // 
            this.txtPatronId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPatronId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPatronId.Location = new System.Drawing.Point(0, 0);
            this.txtPatronId.Name = "txtPatronId";
            this.txtPatronId.Size = new System.Drawing.Size(284, 23);
            this.txtPatronId.TabIndex = 0;
            // 
            // RemovePatron
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
            this.Name = "RemovePatron";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Patron";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblPatronId;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnRemoveId;
        private System.Windows.Forms.TextBox txtPatronId;
    }
}
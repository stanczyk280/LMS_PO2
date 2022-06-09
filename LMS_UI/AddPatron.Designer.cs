namespace LMS_UI
{
    partial class AddPatron
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

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlAuthor;
        private System.Windows.Forms.Panel pnlPublisher;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Panel pnlCopies;
        private System.Windows.Forms.Panel pnlCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Button btnAddPatron;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatron));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.pnlPublisher = new System.Windows.Forms.Panel();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pnlCopies = new System.Windows.Forms.Panel();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.pnlCode = new System.Windows.Forms.Panel();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.btnAddPatron = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlAuthor.SuspendLayout();
            this.pnlPublisher.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlCopies.SuspendLayout();
            this.pnlCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblName);
            this.pnlTitle.Controls.Add(this.txtName);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(294, 21);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(45, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtName.Location = new System.Drawing.Point(94, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.Controls.Add(this.lblSurname);
            this.pnlAuthor.Controls.Add(this.txtSurname);
            this.pnlAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAuthor.Location = new System.Drawing.Point(0, 21);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(294, 21);
            this.pnlAuthor.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSurname.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSurname.Location = new System.Drawing.Point(25, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 17);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSurname.Location = new System.Drawing.Point(94, 0);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // pnlPublisher
            // 
            this.pnlPublisher.Controls.Add(this.lblCity);
            this.pnlPublisher.Controls.Add(this.txtCity);
            this.pnlPublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPublisher.Location = new System.Drawing.Point(0, 42);
            this.pnlPublisher.Name = "pnlPublisher";
            this.pnlPublisher.Size = new System.Drawing.Size(294, 21);
            this.pnlPublisher.TabIndex = 2;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCity.Location = new System.Drawing.Point(59, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 17);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtCity.Location = new System.Drawing.Point(94, 0);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 20);
            this.txtCity.TabIndex = 1;
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.lblAddress);
            this.pnlCategory.Controls.Add(this.txtAddress);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 63);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(294, 21);
            this.pnlCategory.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddress.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAddress.Location = new System.Drawing.Point(30, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtAddress.Location = new System.Drawing.Point(94, 0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // pnlCopies
            // 
            this.pnlCopies.Controls.Add(this.lblBirthDate);
            this.pnlCopies.Controls.Add(this.txtBirthDate);
            this.pnlCopies.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCopies.Location = new System.Drawing.Point(0, 84);
            this.pnlCopies.Name = "pnlCopies";
            this.pnlCopies.Size = new System.Drawing.Size(294, 21);
            this.pnlCopies.TabIndex = 4;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBirthDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBirthDate.Location = new System.Drawing.Point(21, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(73, 17);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Birth date:";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBirthDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtBirthDate.Location = new System.Drawing.Point(94, 0);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(200, 20);
            this.txtBirthDate.TabIndex = 1;
            // 
            // pnlCode
            // 
            this.pnlCode.Controls.Add(this.lblContactNumber);
            this.pnlCode.Controls.Add(this.txtContactNumber);
            this.pnlCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCode.Location = new System.Drawing.Point(0, 105);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.Size = new System.Drawing.Size(294, 21);
            this.pnlCode.TabIndex = 5;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContactNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblContactNumber.Location = new System.Drawing.Point(34, 0);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(60, 17);
            this.lblContactNumber.TabIndex = 2;
            this.lblContactNumber.Text = "Contact:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtContactNumber.Location = new System.Drawing.Point(94, 0);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(200, 20);
            this.txtContactNumber.TabIndex = 1;
            // 
            // btnAddPatron
            // 
            this.btnAddPatron.BackColor = System.Drawing.Color.Silver;
            this.btnAddPatron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPatron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatron.Location = new System.Drawing.Point(0, 126);
            this.btnAddPatron.Name = "btnAddPatron";
            this.btnAddPatron.Size = new System.Drawing.Size(294, 55);
            this.btnAddPatron.TabIndex = 6;
            this.btnAddPatron.Text = "Add Patron";
            this.btnAddPatron.UseVisualStyleBackColor = false;
            // 
            // AddPatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(294, 181);
            this.Controls.Add(this.btnAddPatron);
            this.Controls.Add(this.pnlCode);
            this.Controls.Add(this.pnlCopies);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.pnlPublisher);
            this.Controls.Add(this.pnlAuthor);
            this.Controls.Add(this.pnlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPatron";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlAuthor.ResumeLayout(false);
            this.pnlAuthor.PerformLayout();
            this.pnlPublisher.ResumeLayout(false);
            this.pnlPublisher.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.pnlCopies.ResumeLayout(false);
            this.pnlCopies.PerformLayout();
            this.pnlCode.ResumeLayout(false);
            this.pnlCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
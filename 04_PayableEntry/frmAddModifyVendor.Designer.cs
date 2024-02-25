namespace _04_PayableEntry
{
    partial class frmAddModifyVendor
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
            label1 = new Label();
            txtName = new TextBox();
            txtAddress1 = new TextBox();
            label2 = new Label();
            txtAddress2 = new TextBox();
            txtCity = new TextBox();
            label3 = new Label();
            txtZipCode = new TextBox();
            label4 = new Label();
            cmbStates = new ComboBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            cmbAccounts = new ComboBox();
            label7 = new Label();
            cmbTerms = new ComboBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtLastName = new TextBox();
            label10 = new Label();
            txtFirstName = new TextBox();
            label9 = new Label();
            txtPhone = new TextBox();
            label8 = new Label();
            btnAccept = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(341, 23);
            txtName.TabIndex = 1;
            txtName.Tag = "Name";
            // 
            // txtAddress1
            // 
            txtAddress1.Location = new Point(101, 52);
            txtAddress1.Name = "txtAddress1";
            txtAddress1.Size = new Size(341, 23);
            txtAddress1.TabIndex = 3;
            txtAddress1.Tag = "Address 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 55);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Address:";
            // 
            // txtAddress2
            // 
            txtAddress2.Location = new Point(101, 81);
            txtAddress2.Name = "txtAddress2";
            txtAddress2.Size = new Size(341, 23);
            txtAddress2.TabIndex = 4;
            txtAddress2.Tag = "Address 2";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(101, 110);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(341, 23);
            txtCity.TabIndex = 6;
            txtCity.Tag = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 113);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "City:";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(330, 139);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(112, 23);
            txtZipCode.TabIndex = 8;
            txtZipCode.Tag = "Zip Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 142);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "State:";
            // 
            // cmbStates
            // 
            cmbStates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStates.FormattingEnabled = true;
            cmbStates.Location = new Point(101, 139);
            cmbStates.Name = "cmbStates";
            cmbStates.Size = new Size(139, 23);
            cmbStates.TabIndex = 9;
            cmbStates.Tag = "State";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 142);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 10;
            label5.Text = "Zip code:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbAccounts);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbTerms);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(28, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 95);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Defaults";
            // 
            // cmbAccounts
            // 
            cmbAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccounts.FormattingEnabled = true;
            cmbAccounts.Location = new Point(84, 51);
            cmbAccounts.Name = "cmbAccounts";
            cmbAccounts.Size = new Size(164, 23);
            cmbAccounts.TabIndex = 13;
            cmbAccounts.Tag = "Account";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 54);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 12;
            label7.Text = "Accounts:";
            // 
            // cmbTerms
            // 
            cmbTerms.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTerms.FormattingEnabled = true;
            cmbTerms.Location = new Point(84, 22);
            cmbTerms.Name = "cmbTerms";
            cmbTerms.Size = new Size(164, 23);
            cmbTerms.TabIndex = 11;
            cmbTerms.Tag = "Term";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 25);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 10;
            label6.Text = "Terms:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtFirstName);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(28, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(414, 117);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contact Information";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(84, 80);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(164, 23);
            txtLastName.TabIndex = 7;
            txtLastName.Tag = "Last name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 83);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 6;
            label10.Text = "Last name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(84, 51);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(164, 23);
            txtFirstName.TabIndex = 5;
            txtFirstName.Tag = "First name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 54);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 4;
            label9.Text = "First name:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(84, 22);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(164, 23);
            txtPhone.TabIndex = 3;
            txtPhone.Tag = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 25);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 2;
            label8.Text = "Phone:";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(28, 443);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 13;
            btnAccept.Text = "&Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(367, 443);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddModifyVendor
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(472, 484);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(cmbStates);
            Controls.Add(txtZipCode);
            Controls.Add(label4);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(txtAddress2);
            Controls.Add(txtAddress1);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmAddModifyVendor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddModifyVendor";
            Load += frmAddModifyVendor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtAddress1;
        private Label label2;
        private TextBox txtAddress2;
        private TextBox txtCity;
        private Label label3;
        private TextBox txtZipCode;
        private Label label4;
        private ComboBox cmbStates;
        private Label label5;
        private GroupBox groupBox1;
        private ComboBox cmbTerms;
        private Label label6;
        private ComboBox cmbAccounts;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox txtLastName;
        private Label label10;
        private TextBox txtFirstName;
        private Label label9;
        private TextBox txtPhone;
        private Label label8;
        private Button btnAccept;
        private Button btnCancel;
    }
}
namespace _04_PayableEntry
{
    partial class frmEditLineItem
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
            txtAmount = new TextBox();
            label6 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            cmbAccount = new ComboBox();
            label4 = new Label();
            btnCancel = new Button();
            btnAccept = new Button();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(96, 77);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(219, 23);
            txtAmount.TabIndex = 13;
            txtAmount.Tag = "Amount";
            txtAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 80);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 17;
            label6.Text = "Amount:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(96, 48);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(219, 23);
            txtDescription.TabIndex = 12;
            txtDescription.Tag = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 51);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 15;
            label5.Text = "Description:";
            // 
            // cmbAccount
            // 
            cmbAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(96, 19);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(219, 23);
            cmbAccount.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 22);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 16;
            label4.Text = "Account:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(228, 119);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 23);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(23, 119);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(87, 23);
            btnAccept.TabIndex = 18;
            btnAccept.Text = "&Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // frmEditLineItem
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(349, 160);
            ControlBox = false;
            Controls.Add(txtAmount);
            Controls.Add(label6);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(cmbAccount);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmEditLineItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Line Item";
            Load += frmEditLineItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private Label label6;
        private TextBox txtDescription;
        private Label label5;
        private ComboBox cmbAccount;
        private Label label4;
        private Button btnCancel;
        private Button btnAccept;
    }
}
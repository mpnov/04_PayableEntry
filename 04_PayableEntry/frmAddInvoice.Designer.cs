namespace _04_PayableEntry
{
    partial class frmAddInvoice
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
            txtVendor = new TextBox();
            txtInvoiceNumber = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbTerms = new ComboBox();
            groupBox1 = new GroupBox();
            dgvLineItems = new DataGridView();
            btnAdd = new Button();
            txtInvoiceTotal = new TextBox();
            label7 = new Label();
            txtAmount = new TextBox();
            label6 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            cmbAccount = new ComboBox();
            label4 = new Label();
            btnSaveInvoice = new Button();
            btnCancel = new Button();
            dtpInvoiceDate = new DateTimePicker();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLineItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Vendor:";
            // 
            // txtVendor
            // 
            txtVendor.Location = new Point(102, 18);
            txtVendor.Name = "txtVendor";
            txtVendor.ReadOnly = true;
            txtVendor.Size = new Size(219, 23);
            txtVendor.TabIndex = 0;
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.Location = new Point(102, 47);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.Size = new Size(219, 23);
            txtInvoiceNumber.TabIndex = 1;
            txtInvoiceNumber.Tag = "Invoice Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 50);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Invoice No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 108);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Terms:";
            // 
            // cmbTerms
            // 
            cmbTerms.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTerms.FormattingEnabled = true;
            cmbTerms.Location = new Point(102, 105);
            cmbTerms.Name = "cmbTerms";
            cmbTerms.Size = new Size(219, 23);
            cmbTerms.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvLineItems);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtInvoiceTotal);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbAccount);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(15, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(743, 294);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Line Items";
            // 
            // dgvLineItems
            // 
            dgvLineItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLineItems.Location = new Point(12, 118);
            dgvLineItems.Name = "dgvLineItems";
            dgvLineItems.Size = new Size(716, 141);
            dgvLineItems.TabIndex = 3;
            dgvLineItems.CellClick += dgvLineItems_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(329, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtInvoiceTotal
            // 
            txtInvoiceTotal.Location = new Point(610, 265);
            txtInvoiceTotal.Name = "txtInvoiceTotal";
            txtInvoiceTotal.ReadOnly = true;
            txtInvoiceTotal.Size = new Size(118, 23);
            txtInvoiceTotal.TabIndex = 8;
            txtInvoiceTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(528, 268);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 7;
            label7.Text = "Invoice Total:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(85, 80);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(219, 23);
            txtAmount.TabIndex = 2;
            txtAmount.Tag = "Amount";
            txtAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 83);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 9;
            label6.Text = "Amount:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(85, 51);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(219, 23);
            txtDescription.TabIndex = 1;
            txtDescription.Tag = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 54);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 7;
            label5.Text = "Description:";
            // 
            // cmbAccount
            // 
            cmbAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(85, 22);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(219, 23);
            cmbAccount.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 25);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Account:";
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.Location = new Point(15, 457);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(87, 23);
            btnSaveInvoice.TabIndex = 9;
            btnSaveInvoice.Text = "&Save Invoice";
            btnSaveInvoice.UseVisualStyleBackColor = true;
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(671, 457);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtpInvoiceDate
            // 
            dtpInvoiceDate.Location = new Point(102, 76);
            dtpInvoiceDate.Name = "dtpInvoiceDate";
            dtpInvoiceDate.Size = new Size(219, 23);
            dtpInvoiceDate.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 82);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 12;
            label8.Text = "Invoice Date:";
            // 
            // frmAddInvoice
            // 
            AcceptButton = btnSaveInvoice;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(773, 492);
            ControlBox = false;
            Controls.Add(label8);
            Controls.Add(dtpInvoiceDate);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveInvoice);
            Controls.Add(groupBox1);
            Controls.Add(cmbTerms);
            Controls.Add(label3);
            Controls.Add(txtInvoiceNumber);
            Controls.Add(label2);
            Controls.Add(txtVendor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddInvoice";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Invoice";
            Load += frmAddInvoice_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLineItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVendor;
        private TextBox txtInvoiceNumber;
        private Label label2;
        private Label label3;
        private ComboBox cmbTerms;
        private GroupBox groupBox1;
        private TextBox txtDescription;
        private Label label5;
        private ComboBox cmbAccount;
        private Label label4;
        private TextBox txtAmount;
        private Label label6;
        private Button btnAdd;
        private DataGridView dgvLineItems;
        private TextBox txtInvoiceTotal;
        private Label label7;
        private Button btnSaveInvoice;
        private Button btnCancel;
        private DateTimePicker dtpInvoiceDate;
        private Label label8;
    }
}
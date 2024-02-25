namespace _04_PayableEntry
{
    partial class frmVendorInvoices
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtVendorID = new TextBox();
            btnGetVendor = new Button();
            txtFindVendor = new Button();
            label2 = new Label();
            txtName = new TextBox();
            txtAddress1 = new TextBox();
            label3 = new Label();
            txtAddress2 = new TextBox();
            label4 = new Label();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtZip = new TextBox();
            btnAddVendor = new Button();
            btnModifyVendor = new Button();
            dgvInvoices = new DataGridView();
            btnAddInvoice = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Vendor ID: ";
            // 
            // txtVendorID
            // 
            txtVendorID.Location = new Point(115, 17);
            txtVendorID.Name = "txtVendorID";
            txtVendorID.Size = new Size(100, 23);
            txtVendorID.TabIndex = 1;
            txtVendorID.Tag = "Vendro ID";
            // 
            // btnGetVendor
            // 
            btnGetVendor.Location = new Point(232, 17);
            btnGetVendor.Name = "btnGetVendor";
            btnGetVendor.Size = new Size(99, 23);
            btnGetVendor.TabIndex = 2;
            btnGetVendor.Text = "&Get Vendor";
            btnGetVendor.UseVisualStyleBackColor = true;
            btnGetVendor.Click += btnGetVendor_Click;
            // 
            // txtFindVendor
            // 
            txtFindVendor.Location = new Point(349, 17);
            txtFindVendor.Name = "txtFindVendor";
            txtFindVendor.Size = new Size(99, 23);
            txtFindVendor.TabIndex = 3;
            txtFindVendor.Text = "&Find Vendor";
            txtFindVendor.UseVisualStyleBackColor = true;
            txtFindVendor.Click += txtFindVendor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 63);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 60);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(397, 23);
            txtName.TabIndex = 5;
            // 
            // txtAddress1
            // 
            txtAddress1.Location = new Point(115, 89);
            txtAddress1.Name = "txtAddress1";
            txtAddress1.ReadOnly = true;
            txtAddress1.Size = new Size(397, 23);
            txtAddress1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 92);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Address:";
            // 
            // txtAddress2
            // 
            txtAddress2.Location = new Point(115, 118);
            txtAddress2.Name = "txtAddress2";
            txtAddress2.ReadOnly = true;
            txtAddress2.Size = new Size(397, 23);
            txtAddress2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 150);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 9;
            label4.Text = "City, State, Zip:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(115, 147);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(189, 23);
            txtCity.TabIndex = 10;
            // 
            // txtState
            // 
            txtState.Location = new Point(310, 147);
            txtState.Name = "txtState";
            txtState.ReadOnly = true;
            txtState.Size = new Size(53, 23);
            txtState.TabIndex = 11;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(369, 147);
            txtZip.Name = "txtZip";
            txtZip.ReadOnly = true;
            txtZip.Size = new Size(143, 23);
            txtZip.TabIndex = 12;
            // 
            // btnAddVendor
            // 
            btnAddVendor.Location = new Point(537, 60);
            btnAddVendor.Name = "btnAddVendor";
            btnAddVendor.Size = new Size(99, 23);
            btnAddVendor.TabIndex = 13;
            btnAddVendor.Text = "&Add Vendor";
            btnAddVendor.UseVisualStyleBackColor = true;
            btnAddVendor.Click += btnAddVendor_Click;
            // 
            // btnModifyVendor
            // 
            btnModifyVendor.Location = new Point(537, 89);
            btnModifyVendor.Name = "btnModifyVendor";
            btnModifyVendor.Size = new Size(99, 23);
            btnModifyVendor.TabIndex = 14;
            btnModifyVendor.Text = "&Modify Vendor";
            btnModifyVendor.UseVisualStyleBackColor = true;
            btnModifyVendor.Click += btnModifyVendor_Click;
            // 
            // dgvInvoices
            // 
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Location = new Point(24, 191);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.Size = new Size(870, 172);
            dgvInvoices.TabIndex = 15;
            dgvInvoices.CellClick += dgvInvoices_CellClick;
            // 
            // btnAddInvoice
            // 
            btnAddInvoice.Location = new Point(24, 383);
            btnAddInvoice.Name = "btnAddInvoice";
            btnAddInvoice.Size = new Size(99, 23);
            btnAddInvoice.TabIndex = 16;
            btnAddInvoice.Text = "Add &Invoice";
            btnAddInvoice.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(795, 382);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 23);
            btnExit.TabIndex = 17;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmVendorInvoices
            // 
            AcceptButton = btnGetVendor;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(921, 417);
            Controls.Add(btnExit);
            Controls.Add(btnAddInvoice);
            Controls.Add(dgvInvoices);
            Controls.Add(btnModifyVendor);
            Controls.Add(btnAddVendor);
            Controls.Add(txtZip);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(txtAddress2);
            Controls.Add(txtAddress1);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtFindVendor);
            Controls.Add(btnGetVendor);
            Controls.Add(txtVendorID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmVendorInvoices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendor Invoices";
            Load += frmVendorInvoices_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVendorID;
        private Button btnGetVendor;
        private Button txtFindVendor;
        private Label label2;
        private TextBox txtName;
        private TextBox txtAddress1;
        private Label label3;
        private TextBox txtAddress2;
        private Label label4;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtZip;
        private Button btnAddVendor;
        private Button btnModifyVendor;
        private DataGridView dgvInvoices;
        private Button btnAddInvoice;
        private Button btnExit;
    }
}

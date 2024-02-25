namespace _04_PayableEntry
{
    partial class frmLineItems
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
            txtVendorName = new TextBox();
            txtInvoiceNumber = new TextBox();
            label2 = new Label();
            dgvLineItems = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLineItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Vendor:";
            // 
            // txtVendorName
            // 
            txtVendorName.Location = new Point(90, 23);
            txtVendorName.Name = "txtVendorName";
            txtVendorName.ReadOnly = true;
            txtVendorName.Size = new Size(303, 23);
            txtVendorName.TabIndex = 1;
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.Location = new Point(90, 52);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.ReadOnly = true;
            txtInvoiceNumber.Size = new Size(303, 23);
            txtInvoiceNumber.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 55);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Invoice no:";
            // 
            // dgvLineItems
            // 
            dgvLineItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLineItems.Location = new Point(21, 96);
            dgvLineItems.Name = "dgvLineItems";
            dgvLineItems.Size = new Size(494, 150);
            dgvLineItems.TabIndex = 4;
            // 
            // frmLineItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 266);
            Controls.Add(dgvLineItems);
            Controls.Add(txtInvoiceNumber);
            Controls.Add(label2);
            Controls.Add(txtVendorName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLineItems";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Line Items";
            Load += frmLineItems_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLineItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVendorName;
        private TextBox txtInvoiceNumber;
        private Label label2;
        private DataGridView dgvLineItems;
    }
}
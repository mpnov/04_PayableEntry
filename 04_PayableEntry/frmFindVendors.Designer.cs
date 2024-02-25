namespace _04_PayableEntry
{
    partial class frmFindVendors
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
            txtState = new TextBox();
            label2 = new Label();
            lblInfo = new Label();
            lstVendors = new ListBox();
            btnSearch = new Button();
            btnSelect = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 23);
            txtName.TabIndex = 1;
            // 
            // txtState
            // 
            txtState.Location = new Point(362, 23);
            txtState.Name = "txtState";
            txtState.Size = new Size(65, 23);
            txtState.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 26);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "State:";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(31, 62);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(38, 15);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "label3";
            // 
            // lstVendors
            // 
            lstVendors.FormattingEnabled = true;
            lstVendors.ItemHeight = 15;
            lstVendors.Location = new Point(31, 87);
            lstVendors.Name = "lstVendors";
            lstVendors.Size = new Size(496, 154);
            lstVendors.TabIndex = 5;
            lstVendors.SelectedIndexChanged += lstVendors_SelectedIndexChanged;
            lstVendors.DoubleClick += btnSelect_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(452, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(31, 264);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 7;
            btnSelect.Text = "&Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(452, 264);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmFindVendors
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(550, 308);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnSelect);
            Controls.Add(btnSearch);
            Controls.Add(lstVendors);
            Controls.Add(lblInfo);
            Controls.Add(txtState);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmFindVendors";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Find Vendors";
            Load += frmFindVendors_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtState;
        private Label label2;
        private Label lblInfo;
        private ListBox lstVendors;
        private Button btnSearch;
        private Button btnSelect;
        private Button btnCancel;
    }
}
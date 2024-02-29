using PayableDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_PayableEntry
{
    public partial class frmLineItems : Form
    {
        //fields
        public string VendorName;
        public string InvoiceNumber;
        public List<InvoiceLineItem> LineItems;
        public frmLineItems()
        {
            InitializeComponent();
        }

        private void frmLineItems_Load(object sender, EventArgs e)
        {
            txtVendorName.Text = VendorName;
            txtInvoiceNumber.Text = InvoiceNumber;
            dgvLineItems.DataSource = LineItems.Select(i => new {i.InvoiceSequence, i.AccountDescription, i.Description, i.Amount }).ToList();
            //format grid
            //behavior
            dgvLineItems.AllowUserToAddRows = false;
            dgvLineItems.AllowUserToDeleteRows = false;
            dgvLineItems.AllowUserToOrderColumns = false;
            dgvLineItems.ReadOnly = true;
            //columns
            dgvLineItems.Columns[0].HeaderText = "No";
            dgvLineItems.Columns[0].Width = 50;
            dgvLineItems.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLineItems.Columns[1].HeaderText = "Account";
            dgvLineItems.Columns[1].Width = 190;
            dgvLineItems.Columns[2].Width = 80;
            dgvLineItems.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLineItems.Columns[3].DefaultCellStyle.Format = "c";
        }
    }
}

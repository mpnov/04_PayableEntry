using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayableDAL;

namespace _04_PayableEntry
{
    public partial class frmAddInvoice : Form
    {
        //properties
        public Vendor vendor;
        public List<Term> terms;
        public List<GLAccount> accounts;
        public List<InvoiceLineItem> lineItems = new List<InvoiceLineItem>();

        public frmAddInvoice()
        {
            InitializeComponent();
        }

        private void frmAddInvoice_Load(object sender, EventArgs e)
        {
            LoadCombos();
            txtVendor.Text = vendor.Name;
            cmbTerms.SelectedValue = vendor.DefaultTermsID;
            cmbAccount.SelectedValue = vendor.DefaultAccountNo;
            dtpInvoiceDate.Value = DateTime.Now;
        }

        private void LoadCombos()
        {
            //terms
            if (terms != null)
            {
                cmbTerms.Items.Clear();
                cmbTerms.DataSource = terms;
                cmbTerms.DisplayMember = nameof(Term.Description);
                cmbTerms.ValueMember = nameof(Term.TermsID);
            }
            //accounts
            if (accounts != null)
            {
                cmbAccount.Items.Clear();
                cmbAccount.DataSource = accounts;
                cmbAccount.DisplayMember = nameof(GLAccount.Description);
                cmbAccount.ValueMember = nameof(GLAccount.AccountNo);
            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (IsValidInvoice())
            {
                if (lineItems.Count > 0)
                {
                    try
                    {
                        //create Invoice for inserting
                        Invoice invoice = new Invoice();
                        invoice.VendorID = vendor.VendorID;
                        invoice.InvoiceNumber = txtInvoiceNumber.Text;
                        invoice.InvoiceDate = dtpInvoiceDate.Value;
                        invoice.InvoiceTotal = lineItems.Sum(i => i.Amount);
                        invoice.TermsID = (int)cmbTerms.SelectedValue;
                        int days = terms.Where(t => t.TermsID == invoice.TermsID).Select(t => t.DueDays).FirstOrDefault();
                        invoice.DueDate = invoice.InvoiceDate.AddDays(days);
                        //insert Invoice and LineItems
                        if(Payable_UnitOfWork.AddInvoiceWithLineItems(invoice, lineItems))
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Unable to insert invoice and line items", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        GeneralError(ex);
                    }
                }
                else
                {
                    MessageBox.Show("At least one Line Item should be added to the invoice", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool IsValidInvoice()
        {
            string msg = Validator.IsPresent(txtInvoiceNumber.Text, txtInvoiceNumber.Tag.ToString());
            if (msg.Length > 0)
            {
                MessageBox.Show(msg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidLineItem())
            {
                InvoiceLineItem item = new InvoiceLineItem();
                //get line sequence
                int lineSequence = 0;
                if (lineItems.Count > 0)
                {
                    lineSequence = lineItems.Max(li => li.InvoiceSequence) + 1;
                }
                else
                {
                    lineSequence += 1;
                }
                item.InvoiceSequence = lineSequence;
                item.AccountNo = (int)cmbAccount.SelectedValue;
                item.AccountDescription = cmbAccount.Text;
                item.Description = txtDescription.Text;
                item.Amount = Decimal.Parse(txtAmount.Text);
                //item.InvoiceID - unknow at this stage will be set on the transaction level
                lineItems.Add(item);
                DisplayLineItems();
            }
        }

        private void DisplayLineItems()
        {
            dgvLineItems.Columns.Clear();
            dgvLineItems.DataSource = lineItems.Select(i => new { i.InvoiceSequence, i.AccountDescription, i.Description, i.Amount }).ToList();
            //configure grid
            //behavior
            dgvLineItems.AllowUserToAddRows = false;
            dgvLineItems.AllowUserToDeleteRows = false;
            dgvLineItems.AllowUserToOrderColumns = false;
            dgvLineItems.ReadOnly = true;
            //columns
            dgvLineItems.Columns[0].HeaderText = "No";
            dgvLineItems.Columns[0].Width = 30;
            dgvLineItems.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLineItems.Columns[1].HeaderText = "Account";
            dgvLineItems.Columns[1].Width = 200;
            dgvLineItems.Columns[2].Width = 150;
            dgvLineItems.Columns[3].Width = 70;
            dgvLineItems.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLineItems.Columns[3].DefaultCellStyle.Format = "c";
            //button coluns
            //edit
            DataGridViewButtonColumn buttonEdit = new DataGridViewButtonColumn();
            buttonEdit.Text = "Edit";
            buttonEdit.HeaderText = string.Empty;
            buttonEdit.UseColumnTextForButtonValue = true;
            dgvLineItems.Columns.Add(buttonEdit);
            //delete
            DataGridViewButtonColumn buttonDelete = new DataGridViewButtonColumn();
            buttonDelete.Text = "Delete";
            buttonDelete.HeaderText = string.Empty;
            buttonDelete.UseColumnTextForButtonValue = true;
            dgvLineItems.Columns.Add(buttonDelete);
            //invoice total
            txtInvoiceTotal.Text = lineItems.Sum(i => i.Amount).ToString("c");
        }

        private bool IsValidLineItem()
        {
            string msg = string.Empty;

            msg += Validator.IsPresent(txtDescription.Text, txtDescription.Tag.ToString());
            msg += Validator.IsDecimal(txtAmount.Text, txtAmount.Tag.ToString());
            msg += Validator.IsInRange(txtAmount.Text, txtAmount.Tag.ToString(), 0.01M, 10000M);

            if (msg.Length > 0)
            {
                MessageBox.Show(msg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dgvLineItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)//Edit
            {
                int itemIndex = e.RowIndex;
                EditLineItem(itemIndex);
            }
            if(e.ColumnIndex ==5 )//Delete
            {
                int itemIndex = e.RowIndex;
                DeleteLineItem(itemIndex);
            }
        }

        private void DeleteLineItem(int itemIndex)
        {
            InvoiceLineItem item = lineItems[itemIndex];
            string msg = $"Do you want to delete\n";
            msg += $"{item.Description} item?";
            DialogResult result = MessageBox.Show(msg, "Delete line item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lineItems.Remove(item);
                //recalculate items sequence
                int sequence = 1;
                foreach(var li in lineItems)
                {
                    li.InvoiceSequence = sequence;
                    sequence++;
                }
                DisplayLineItems();
            }
        }

        private void EditLineItem(int itemIndex)
        {
            InvoiceLineItem item = lineItems[itemIndex];
            frmEditLineItem frm = new frmEditLineItem();
            frm.item = item;
            frm.accounts = accounts;
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                DisplayLineItems();
            }
        }
    }
}

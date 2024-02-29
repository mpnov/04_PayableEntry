using Microsoft.IdentityModel.Tokens;
using PayableDAL;

namespace _04_PayableEntry
{
    public partial class frmVendorInvoices : Form
    {
        //fields
        Vendor selectedVendor = null;
        List<Invoice> selectedInvoices = null;
        List<State> states = null;
        List<Term> terms = null;
        List<GLAccount> accounts = null;

        public frmVendorInvoices()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetVendor_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    int vendorID = int.Parse(txtVendorID.Text);
                    selectedVendor = VendorDB.GetVendor(vendorID);
                    selectedInvoices = InvoiceDB.GeVendorInvoices(vendorID);
                    DisplayVendor();
                    DisplayInvoices();
                }
                catch (Exception ex)
                {
                    GeneralError(ex);
                }
            }
        }

        private void DisplayInvoices()
        {
            if (selectedInvoices != null)
            {
                dgvInvoices.Columns.Clear();
                dgvInvoices.DataSource = selectedInvoices.Select(i => new
                {
                    i.InvoiceID,
                    i.InvoiceNumber,
                    i.InvoiceDate,
                    i.InvoiceTotal,
                    i.PaymentTotal,
                    i.CreditTotal,
                    i.BalanceDue,
                    i.DueDate
                }).ToList();
                //behavior
                dgvInvoices.AllowUserToAddRows = false;
                dgvInvoices.AllowUserToDeleteRows = false;
                dgvInvoices.AllowUserToOrderColumns = false;
                dgvInvoices.ReadOnly = true;
                //format columns
                dgvInvoices.Columns[0].Visible = false;//InvoiceID
                dgvInvoices.Columns[1].HeaderText = "Number";
                dgvInvoices.Columns[2].HeaderText = "Invoice Date";
                dgvInvoices.Columns[2].DefaultCellStyle.Format = "dd.MM.yyyy";
                dgvInvoices.Columns[3].HeaderText = "Invoice Total";
                dgvInvoices.Columns[3].DefaultCellStyle.Format = "c";
                dgvInvoices.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvInvoices.Columns[4].HeaderText = "Payment";
                dgvInvoices.Columns[4].DefaultCellStyle.Format = "c";
                dgvInvoices.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvInvoices.Columns[5].HeaderText = "Credit Total";
                dgvInvoices.Columns[5].DefaultCellStyle.Format = "c";
                dgvInvoices.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvInvoices.Columns[6].HeaderText = "Balance Due";
                dgvInvoices.Columns[6].DefaultCellStyle.Format = "c";
                dgvInvoices.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvInvoices.Columns[7].HeaderText = "Due Date";
                dgvInvoices.Columns[7].DefaultCellStyle.Format = "dd.MM.yyyy";

                //format headers
                //dgvInvoices.EnableHeadersVisualStyles = false;
                //dgvInvoices.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
                //dgvInvoices.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
                //dgvInvoices.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                //add button column
                DataGridViewButtonColumn itemsColumn = new DataGridViewButtonColumn();
                itemsColumn.HeaderText = string.Empty;
                itemsColumn.UseColumnTextForButtonValue = true;
                itemsColumn.Text = "View Line Items";
                dgvInvoices.Columns.Add(itemsColumn);
            }
        }

        private void GeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool IsValid()
        {
            string msg = string.Empty;

            msg += Validator.IsInt(txtVendorID.Text, txtVendorID.Tag.ToString());
            if (msg.Length > 0)
            {
                MessageBox.Show(msg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void DisplayVendor()
        {
            if (selectedVendor != null)
            {
                txtVendorID.Text = selectedVendor.VendorID.ToString();
                txtName.Text = selectedVendor.Name;
                txtAddress1.Text = selectedVendor.Address1;
                txtAddress2.Text = selectedVendor.Address2;
                txtCity.Text = selectedVendor.City;
                txtState.Text = selectedVendor.State;
                txtZip.Text = selectedVendor.ZipCode;
                btnAddInvoice.Enabled = true;
                btnModifyVendor.Enabled = true;
            }

        }

        private void txtFindVendor_Click(object sender, EventArgs e)
        {
            frmFindVendors frm = new frmFindVendors();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedVendor = frm.selectedVendor;
                selectedInvoices = InvoiceDB.GeVendorInvoices(selectedVendor.VendorID);
                DisplayVendor();
                DisplayInvoices();
            }
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            frmAddModifyVendor frm = new frmAddModifyVendor();
            frm.AddVendor = true;
            frm.states = states;
            frm.terms = terms;
            frm.accounts = accounts;
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    //add vendor
                    ClearControls();
                    selectedVendor = frm.vendor;
                    if (VendorDB.AddVendor(selectedVendor))
                    {
                        DisplayVendor();
                        DisplayInvoices();
                    }
                }
                catch (Exception ex)
                {
                    GeneralError(ex);
                }
            }
        }

        private void ClearControls()
        {
            txtVendorID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress1.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtZip.Text = string.Empty;
            dgvInvoices.DataSource = null;
            dgvInvoices.Columns.Clear();
            btnAddInvoice.Enabled = false;
            btnModifyVendor.Enabled = false;
        }

        private void frmVendorInvoices_Load(object sender, EventArgs e)
        {
            try
            {
                states = StateDB.GetStates();
                terms = TermDB.GetTerms();
                accounts = GLAccountDB.GetAccounts();
            }
            catch (Exception ex)
            {
                GeneralError(ex);
            }
        }

        private void btnModifyVendor_Click(object sender, EventArgs e)
        {
            frmAddModifyVendor frm = new frmAddModifyVendor();
            frm.AddVendor = false;
            frm.states = states;
            frm.terms = terms;
            frm.accounts = accounts;
            frm.vendor = selectedVendor;
            Vendor oldVendor = CloneVendor(selectedVendor);
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    //modify vendor
                    selectedVendor = frm.vendor;
                    if (VendorDB.UpdateVendor(oldVendor, selectedVendor))
                    {
                        DisplayVendor();
                        DisplayInvoices();
                    }
                    else
                    {
                        ConcurrencyError();
                    }
                }
                catch (Exception ex)
                {
                    GeneralError(ex);
                }
            }
        }

        private void ConcurrencyError()
        {
            string msg = string.Empty;
            Vendor vendor = VendorDB.GetVendor(selectedVendor.VendorID);
            if (vendor == null)
            {
                msg += $"Vendor {selectedVendor.Name} has been deleted by other customer";
                ClearControls();
            }
            else
            {
                msg += $"Vendor {vendor.Name} has been updated by other user\n";
                msg += "Current values will be shown";
                selectedVendor = vendor;
                DisplayVendor();
                DisplayInvoices();
            }
            MessageBox.Show(msg, "Concurrency Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Vendor CloneVendor(Vendor selectedVendor)
        {
            Vendor old = new Vendor();
            old.VendorID = selectedVendor.VendorID;
            old.Name = selectedVendor.Name;
            old.Address1 = selectedVendor.Address1;
            old.Address2 = selectedVendor.Address2;
            old.City = selectedVendor.City;
            old.State = selectedVendor.State;
            old.ZipCode = selectedVendor.ZipCode;
            old.DefaultTermsID = selectedVendor.DefaultTermsID;
            old.DefaultAccountNo = selectedVendor.DefaultAccountNo;
            old.Phone = selectedVendor.Phone;
            old.ContactFName = selectedVendor.ContactFName;
            old.ContactLName = selectedVendor.ContactLName;
            return old;
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)//button
            {
                try
                {
                    int invoiceID = (int)dgvInvoices.Rows[e.RowIndex].Cells[0].Value;
                    List<InvoiceLineItem> items = InvoiceLineItemDB.GetInvoiceLineItems(invoiceID);
                    frmLineItems frm = new frmLineItems();
                    frm.VendorName = selectedVendor.Name;
                    frm.InvoiceNumber = dgvInvoices.Rows[e.RowIndex].Cells[1].Value.ToString();
                    frm.LineItems = items;
                    DialogResult result = frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    GeneralError(ex);
                }
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {

            frmAddInvoice frm = new frmAddInvoice();
            frm.vendor = selectedVendor;
            frm.terms = terms;
            frm.accounts = accounts;
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedInvoices = InvoiceDB.GeVendorInvoices(selectedVendor.VendorID);
                    DisplayVendor();
                    DisplayInvoices();
                }
                catch (Exception ex)
                {
                    GeneralError(ex);
                }
            }
        }
    }
}

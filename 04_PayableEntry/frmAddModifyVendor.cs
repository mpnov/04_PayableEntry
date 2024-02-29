using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using PayableDAL;

namespace _04_PayableEntry
{
    public partial class frmAddModifyVendor : Form
    {
        //propertis
        public bool AddVendor { get; set; }
        public List<State> states = null;
        public List<Term> terms = null;
        public List<GLAccount> accounts = null;
        public Vendor vendor = null;

        public frmAddModifyVendor()
        {
            InitializeComponent();
        }

        private void frmAddModifyVendor_Load(object sender, EventArgs e)
        {
            LoadCombos();
            if (AddVendor)
            {
                this.Text = "Add Vendor";
            }
            else
            {
                this.Text = "Modify Vendor";
                DisplayVendor();
            }
        }

        private void DisplayVendor()
        {
            if (vendor != null)
            {
                txtName.Text = vendor.Name;
                txtAddress1.Text = vendor.Address1;
                txtAddress2.Text = vendor.Address2;
                txtCity.Text = vendor.City;
                cmbStates.SelectedValue = vendor.State;
                txtZipCode.Text = vendor.ZipCode;
                cmbTerms.SelectedValue = vendor.DefaultTermsID;
                cmbAccounts.SelectedValue = vendor.DefaultAccountNo;
                txtPhone.Text = vendor.Phone;
                txtFirstName.Text = vendor.ContactFName;
                txtLastName.Text = vendor.ContactLName;
            }
        }

        private void LoadCombos()
        {
            if (states != null)
            {
                cmbStates.DataSource = states;
                cmbStates.DisplayMember = nameof(State.StateName);
                cmbStates.ValueMember = nameof(State.StateCode);
                cmbStates.SelectedIndex = -1;
            }
            if (terms != null)
            {
                cmbTerms.DataSource = terms;
                cmbTerms.DisplayMember = nameof(Term.Description);
                cmbTerms.ValueMember = nameof(Term.TermsID);
                cmbTerms.SelectedIndex = -1;
            }
            if (accounts != null)
            {
                cmbAccounts.DataSource = accounts;
                cmbAccounts.DisplayMember = nameof(GLAccount.Description);
                cmbAccounts.ValueMember = nameof(GLAccount.AccountNo);
                cmbAccounts.SelectedIndex = -1;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                if(AddVendor)
                {
                    vendor = new Vendor();
                }
                SetVendor();
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool IsValid()
        {
            string msg = string.Empty;
            msg += Validator.IsPresent(txtName.Text, txtName.Tag.ToString());
            msg += Validator.IsPresent(txtAddress1.Text, txtAddress1.Tag.ToString());
            //msg += Validator.IsPresent(txtAddress2.Text, txtAddress2.Tag.ToString());
            msg += Validator.IsPresent(txtCity.Text, txtCity.Tag.ToString());
            msg += Validator.IsPresent(cmbStates.Text, cmbStates.Tag.ToString());
            msg += Validator.IsPresent(txtZipCode.Text, txtZipCode.Tag.ToString());
            msg += Validator.IsPresent(cmbTerms.Text, cmbTerms.Tag.ToString());
            msg += Validator.IsPresent(cmbAccounts.Text, cmbAccounts.Tag.ToString());
            //msg += Validator.IsPresent(txtPhone.Text, txtPhone.Tag.ToString());
            //msg += Validator.IsPresent(txtFirstName.Text, txtFirstName.Tag.ToString());
            //msg += Validator.IsPresent(txtLastName.Text, txtLastName.Tag.ToString());

            if(msg.Length > 0)
            {
                MessageBox.Show(msg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void SetVendor()
        {
            vendor.Name = txtName.Text;
            vendor.Address1 = txtAddress1.Text;
            vendor.Address2 = txtAddress2.Text;
            vendor.City = txtCity.Text;
            vendor.State = cmbStates.SelectedValue.ToString();
            vendor.ZipCode = txtZipCode.Text;
            vendor.DefaultTermsID = (int)cmbTerms.SelectedValue;
            vendor.DefaultAccountNo = (int)cmbAccounts.SelectedValue;
            vendor.Phone = txtPhone.Text;
            vendor.ContactFName = txtFirstName.Text;
            vendor.ContactLName = txtLastName.Text;
        }
    }
}

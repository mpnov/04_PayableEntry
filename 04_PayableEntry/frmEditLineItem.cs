using Microsoft.IdentityModel.Tokens;
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
    public partial class frmEditLineItem : Form
    {
        //fields
        public List<GLAccount> accounts;
        public InvoiceLineItem item;
        public frmEditLineItem()
        {
            InitializeComponent();
        }

        private void frmEditLineItem_Load(object sender, EventArgs e)
        {
            if (item != null)
            {
                if (accounts != null)
                {
                    cmbAccount.Items.Clear();
                    cmbAccount.DataSource = accounts;
                    cmbAccount.DisplayMember = nameof(GLAccount.Description);
                    cmbAccount.ValueMember = nameof(GLAccount.AccountNo);
                    cmbAccount.SelectedValue = item.AccountNo;
                }
                txtDescription.Text = item.Description;
                txtAmount.Text = item.Amount.ToString();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                //save new values
                item.AccountNo = (int)cmbAccount.SelectedValue;
                item.AccountDescription = cmbAccount.Text;
                item.Description = txtDescription.Text;
                item.Amount = decimal.Parse(txtAmount.Text);
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool IsValid()
        {
            string msg = string.Empty;

            msg += Validator.IsPresent(txtDescription.Text, txtDescription.Tag.ToString());
            msg += Validator.IsDecimal(txtAmount.Text, txtAmount.Tag.ToString());
            msg += Validator.IsInRange(txtAmount.Text, txtAmount.Tag.ToString(), 0.01M, 10000M);

            if(msg.Length > 0)
            {
                MessageBox.Show(msg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}

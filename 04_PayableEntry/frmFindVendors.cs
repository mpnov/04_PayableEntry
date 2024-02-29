using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayableDAL;

namespace _04_PayableEntry
{
    public partial class frmFindVendors : Form
    {
        //fields
        public List<Vendor> foundVendors = null;
        public Vendor selectedVendor = null;
        public frmFindVendors()
        {
            InitializeComponent();
        }

        private void frmFindVendors_Load(object sender, EventArgs e)
        {
            btnSelect.Enabled = false;
            lblInfo.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                foundVendors = VendorDB.FindVendors(txtName.Text, txtState.Text);
                int numberVendors = foundVendors.Count();
                UpdateUI(numberVendors);
            }
            catch (Exception ex)
            {
                GeneralError(ex);
            }
        }

        private void UpdateUI(int numberVendors)
        {
            //update info
            lblInfo.Text = numberVendors switch
            {
                0 => "Vendors not found",
                _ => $"Found {numberVendors} vendors"
            };
            //show vendors
            if (numberVendors > 0)
            {
                lstVendors.DataSource = foundVendors;
                lstVendors.DisplayMember = nameof(Vendor.LongAddress);
                lstVendors.SelectedIndex = -1;
            }
            else
            {
                lstVendors.DataSource = null;
            }
            btnSelect.Enabled = false;
        }

        private void GeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lstVendors_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectedVendor = foundVendors[lstVendors.SelectedIndex];
            this.DialogResult = DialogResult.OK;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobilesystem.AllUserControl
{
    public partial class UC_AddNewPhone : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddNewPhone()
        {
            InitializeComponent();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text != "" && txtModel.Text != "" && txtRam.Text != "" && txtInternal.Text != "" && txtExpandable.Text != "" && txtDisplay.Text != "" && txtRear.Text != "" && txtFront.Text != "" && txtFingerprint.Text != "" && txtSim.Text != "" && txtNetwork.Text != "" && txtPrice.Text != "")
            {
                string company = txtCompany.Text;
                string model = txtModel.Text;
                string ram = txtRam.Text;
                string intel = txtInternal.Text;
                string expandable = txtExpandable.Text;
                string display = txtDisplay.Text;
                string rear = txtRear.Text;
                string front = txtFront.Text;
                string fingerprint = txtFingerprint.Text;
                string sim = txtSim.Text;
                string network = txtNetwork.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into newMobile (cname,mname,ram,internal,expandable,display,rear,front,finger,sim,network,price) values ('" + company + "','" + model + "','" + ram + "','" + intel + "','" + expandable + "','" + display + "','" + rear + "','" + front + "','" + fingerprint + "','" + sim + "','" + network + "'," + price + ")";
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("Fill All Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCompany.Clear();
            txtModel.Clear();
            txtRam.Text = string.Empty;
            txtInternal.Text = string.Empty;
            txtExpandable.Text = string.Empty;
            txtDisplay.Text = string.Empty;
            txtRear.Text = string.Empty;
            txtFront.Text = string.Empty;
            txtFingerprint.Text = string.Empty;
            txtSim.Text = string.Empty;
            txtNetwork.Text = string.Empty;
            txtPrice.Clear();
        }
    }
}

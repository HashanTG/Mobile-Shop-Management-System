using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mobilesystem.AllUserControl
{
    public partial class UC_Customer : UserControl
    {
        function fn = new function();
        String query;
        public UC_Customer()
        {
            InitializeComponent();
        }


    //================= REQUIRED METHODS ========================
    public void setComboBOX(String query , ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query); // select model from newMobile
            while (sdr.Read())
            {
                for (int i=0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UC_Customer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void UC_Customer_Enter(object sender, EventArgs e)
        {
            txtCompany.Items.Clear();
            query = "select distinct cname from newMobile";
            setComboBOX(query, txtCompany);
        }

        private void txtCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModel.Items.Clear();
            string cname= txtCompany.Text;
            query = "select mname from newMobile where cname ='" +cname+ "'";
            setComboBOX(query, txtModel);
        }

        private void txtModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select * from newMobile where mname = '" + txtModel.Text + "'";
            DataSet ds = fn.getData(query);

            ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            expandablelabel.Text = ds.Tables[0].Rows[0][5].ToString();
            rearlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            frontlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            fingerprintlabel.Text = ds.Tables[0].Rows[0][9].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][12].ToString();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtGender.Text != "" && txtContact.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtCompany.Text != "" && txtModel.Text != "" && txtIMEI.Text != "")
            {
                string name = txtName.Text;
                string gender = txtGender.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                string email = txtEmail.Text;
                string address = txtAddress.Text;
                string company = txtCompany.Text;
                string model = txtModel.Text;
                string imei = txtIMEI.Text;

                query = "insert into customerPurchase (cname,gender,contact,email,caddress,company,model,imei) values('" + name + "','" + gender + "'," + contact + ",'" + email + "','" + address + "','" + company + "','" + model + "','" + imei + "')";
                fn.setData(query);

                txtName.Clear();
                txtGender.Text = string.Empty;
                txtContact.Clear();
                txtEmail.Clear();
                txtAddress.Clear();
                txtIMEI.Clear();
            }
            else
            {
                MessageBox.Show("Fill all the Fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

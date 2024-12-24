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
    public partial class UC_DeletePhoneRecord : UserControl
    {
        function fn = new function();
        string query;
        public UC_DeletePhoneRecord()
        {
            InitializeComponent();
        }

        private void labelTOSET_Click(object sender, EventArgs e)
        {

        }

        private void UC_DeletePhoneRecord_Enter(object sender, EventArgs e)
        {
            query = "select * from newMobile";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from newMobile where cname like '" + txtSearch.Text + "%' or mname like '" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                query = "delete from newMobile where mid = " + bid + "";
                if (MessageBox.Show("Deleting Record of " + bid + "", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    fn.setData(query);
                }
                else
                {
                    MessageBox.Show("you cancellecd the Operation.", "Back <-", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("error");
            }
        }
    }
}

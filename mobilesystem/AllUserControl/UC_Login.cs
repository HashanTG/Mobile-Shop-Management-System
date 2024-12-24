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
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
            ToShowLabel.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            panel1.Visible = false;
        }
        int abc = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            abc++;
            if (abc == 10)
            {
                abc = 0;
                if (txtUsername.Text == "sandy" && txtPassword.Text == "visual")
                {
                    this.Hide();
                    timer1.Stop();
                }
                else
                {
                    panel1.Visible = true;
                    ToShowLabel.Visible = true;
                    timer1.Stop();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.SignIn
{
    public partial class SignInUserControl : UserControl
    {

        MainForm m;

        public SignInUserControl(MainForm m)
        {
            this.m = m;
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {



            if (txtUsername.Text == "1")
            {
                m.Controls.Remove(this);
                m.Controls.Add(new Admin.AdminUserControl(m));
            }


            ///////////////////////////////////
            else if (txtUsername.Text == "2")
            {
                m.Controls.Remove(this);
                m.Controls.Add(new EmpBuyer.EmpBuyerUserControl(m));
            }


            ///////////////////////////////////////
            else if (txtUsername.Text == "3")
            {
                m.Controls.Remove(this);
                m.Controls.Add(new EmpSeller.EmpSellerUserControl(m));
            }
            else
                MessageBox.Show("wrong input");

        }

        private void SignInUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}

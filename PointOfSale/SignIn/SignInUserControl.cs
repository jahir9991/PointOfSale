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


            DataSet ds = DataBase.DataAccess.GetDataSet("select * from users where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'");
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Please Enter a Valid Username and Password");
            }
            else
            {
                if (ds.Tables[0].Rows[0][3].ToString() == "1")//admin
                {
                    m.Controls.Remove(this);
                    m.Controls.Add(new Admin.AdminUserControl(m));



                }
                else if (ds.Tables[0].Rows[0][3].ToString() == "2") //seller
                {
                    m.Controls.Remove(this);
                    m.Controls.Add(new EmpBuyer.EmpBuyerUserControl(m));
                }
                else if (ds.Tables[0].Rows[0][3].ToString() == "3") //buyer
                {
                    m.Controls.Remove(this);
                    m.Controls.Add(new EmpSeller.EmpSellerUserControl(m)); ;
                }
                else if (ds.Tables[0].Rows[0][3].ToString() == "0") //block
                {
                    MessageBox.Show(ds.Tables[0].Rows[0][1].ToString() + " Has Been Blocked By Admin. \n *******Please Contact With Admin*******");
                }
                else
                    MessageBox.Show("wrong input");
            }


            //if (txtUsername.Text == "1")
            //{
            //    m.Controls.Remove(this);
            //    m.Controls.Add(new Admin.AdminUserControl(m));
            //}


            /////////////////////////////////////
            //else if (txtUsername.Text == "2")
            //{
            //    m.Controls.Remove(this);
            //    m.Controls.Add(new EmpBuyer.EmpBuyerUserControl(m));
            //}


            /////////////////////////////////////////
            //else if (txtUsername.Text == "3")
            //{
            //    m.Controls.Remove(this);
            //    m.Controls.Add(new EmpSeller.EmpSellerUserControl(m));
            //}
            //else
            //    MessageBox.Show("wrong input");

        }

        private void SignInUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}

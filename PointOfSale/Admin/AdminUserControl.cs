using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Admin
{
    public partial class AdminUserControl : UserControl
    {
        private MainForm m;




        public AdminUserControl(MainForm m)
        {
            InitializeComponent();
            this.m = m;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            m.Controls.Remove(this);
            m.Controls.Add(new SignIn.SignInUserControl(m));


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

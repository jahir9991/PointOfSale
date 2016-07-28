using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.EmpSeller
{
    public partial class EmpSellerUserControl : UserControl
    {
        MainForm m;
        public EmpSellerUserControl(MainForm mainform)
        {
            this.m = mainform;
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            m.Controls.Remove(this);
            m.Controls.Add(new SignIn.SignInUserControl(m));
        }

        private void EmpSellerUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}

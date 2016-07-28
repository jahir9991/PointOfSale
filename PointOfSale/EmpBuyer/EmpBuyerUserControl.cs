using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.EmpBuyer
{
    public partial class EmpBuyerUserControl : UserControl
    {
        private MainForm m;



        public EmpBuyerUserControl(MainForm m)
        {
            InitializeComponent();
            this.m = m;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            m.Controls.Remove(this);
            m.Controls.Add(new SignIn.SignInUserControl(m));
        }

        private void EmpBuyerUserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}

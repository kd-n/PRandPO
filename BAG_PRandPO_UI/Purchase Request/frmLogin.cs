using BAG_PRandPO_UI.Purchase_Order;
using System;
using System.Windows.Forms;

namespace BAG_PRandPO_UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLanding landing = new frmLanding();
            landing.Show();
            Hide();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            if (txtURL.Text == "https://bagpurchasing.com/PO")
            {
                frmLoginPO LoginPO = new frmLoginPO();
                LoginPO.Show();
                Hide();
            }
            else if (txtURL.Text == "https://bagpurchasing.com/PR")
            {
                frmLogin loginPR = new frmLogin();
                loginPR.Show();
                Hide();
            }
        }
    }
}

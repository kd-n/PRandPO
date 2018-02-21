using System;
using System.Windows.Forms;

namespace BAG_PRandPO_UI.Purchase_Order
{
    public partial class frmLoginPO : Form
    {
        public frmLoginPO()
        {
            InitializeComponent();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            if(txtURL.Text == "https://bagpurchasing.com/PO")
            {
                frmLoginPO LoginPO = new frmLoginPO();
                LoginPO.Show();
                Hide();
            }
            else if(txtURL.Text == "https://bagpurchasing.com/PR")
            {
                frmLogin loginPR = new frmLogin();
                loginPR.Show();
                Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLandingPO frmLandingPO = new frmLandingPO();
            frmLandingPO.Show();
            Hide();
        }
    }
}

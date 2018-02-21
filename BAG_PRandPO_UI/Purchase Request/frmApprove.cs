using BAG_PRandPO_UI.Purchase_Order;
using System;
using System.Windows.Forms;

namespace BAG_PRandPO_UI.Purchase_Request
{
    public partial class frmApprove : Form
    {
        public frmApprove()
        {
            InitializeComponent();
        }

        private void btnDisapprove_Click(object sender, EventArgs e)
        {
            frmDisapprove disapprove = new frmDisapprove();
            disapprove.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmLanding landing = new frmLanding();
            landing.Show();
            Close();
        }

        private void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApprove approve = new frmApprove();
            approve.Show();
            Close();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            if (txtURL.Text == "https://bagpurchasing.com/PO")
            {
                frmLoginPO LoginPO = new frmLoginPO();
                LoginPO.Show();
                Close();
            }
            else if (txtURL.Text == "https://bagpurchasing.com/PR")
            {
                frmLogin loginPR = new frmLogin();
                loginPR.Show();
                Close();
            }
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserReg userReg = new frmUserReg();
            userReg.Show();
            Close();
        }
    }
}

using BAG_PRandPO_UI.Purchase_Request;
using System;
using System.Windows.Forms;

namespace BAG_PRandPO_UI.Purchase_Order
{
    public partial class frmNewPO : Form
    {
        public frmNewPO()
        {
            InitializeComponent();
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginPO loginPO = new frmLoginPO();
            loginPO.Show();
            Close();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPO newPO = new frmNewPO();
            newPO.Show();
            Close();
        }

        private void orderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderList orderList = new frmOrderList();
            orderList.Show();
            Close();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetails details = new frmDetails();
            details.Show();
            Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory history = new frmHistory();
            history.Show();
        }

        private void btnHistory1_Click(object sender, EventArgs e)
        {
            frmHistory hist = new frmHistory();
            hist.Show();
        }

        private void pRToPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPRtoPO pRtoPO = new frmPRtoPO();
            pRtoPO.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLoginPO loginPO = new frmLoginPO();
            loginPO.Show();
            Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmLandingPO landingPO = new frmLandingPO();
            landingPO.Show();
            Close();
        }

        private void orderDetails2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderDetails orderDetails = new frmOrderDetails();
            orderDetails.Show();
            Close();
        }

        private void receivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceiving receiving = new frmReceiving();
            receiving.Show();
            Close();
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserReg userReg = new frmUserReg();
            userReg.Show();
            Close();
        }
    }
}

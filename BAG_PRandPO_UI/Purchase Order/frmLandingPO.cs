using BAG_PRandPO_UI.Purchase_Request;
using System;
using System.Windows.Forms;

namespace BAG_PRandPO_UI.Purchase_Order
{
    public partial class frmLandingPO : Form
    {
        public frmLandingPO()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginPO login = new frmLoginPO();
            login.Show();
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

using BAG_PRandPO_UI.Purchase_Order;
using BAG_PRandPO_UI.Purchase_Request;
using System;
using System.Windows.Forms;

namespace BAG_PRandPO_UI
{
    public partial class frmLanding : Form
    {
        public frmLanding()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            Close();
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            frmNewPR newPR = new frmNewPR();
            newPR.Show();
            Close();
        }

        private void btnPendingRequest_Click(object sender, EventArgs e)
        {
            frmReqList reqList = new frmReqList();
            reqList.Show();
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

        private void linkRequests_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReqList reqList = new frmReqList();
            reqList.Show();
            Close();
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

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserReg userReg = new frmUserReg();
            userReg.Show();
            Close();
        }
    }
}

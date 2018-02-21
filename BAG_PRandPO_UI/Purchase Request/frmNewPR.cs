using BAG_PRandPO_UI.Purchase_Order;
using BAG_PRandPO_UI.Purchase_Request;
using System;
using System.Windows.Forms;

namespace BAG_PRandPO_UI
{
    public partial class frmNewPR : Form
    {
        public frmNewPR()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            Close();
        }

        private void btnPendingRequest_Click(object sender, EventArgs e)
        {
            frmReqList reqList = new frmReqList();
            reqList.Show();
            Close();
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            frmNewPR newPR = new frmNewPR();
            newPR.Show();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmCancelPopup cancelPopup = new frmCancelPopup();
            cancelPopup.Show();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnAttach.Enabled = false;
            btnSave.Enabled = false;
            btnComplete.Enabled = false;
            btnSubmit.Enabled = false;
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

        private void chkUrgent_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUrgent.Checked)
            {
                txtReason.Enabled = true;
            }
            else
            {
                txtReason.Clear();
                txtReason.Enabled = false;
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            frmAttach attach = new frmAttach();
            attach.Show();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (rdFinalPurchase.Checked)
            {
                popupCompletePO popup = new popupCompletePO();
                popup.Show();
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

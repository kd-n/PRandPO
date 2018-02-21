using System;
using System.Windows.Forms;

namespace BAG_PRandPO_UI.Purchase_Request
{
    public partial class popupCompletePO : Form
    {
        public popupCompletePO()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            frmNewPR PR = new frmNewPR();          

            foreach (Control item in PR.Controls)
            {
                if (item is Button)
                {
                    if (item.Name != "btnPrint")
                    {
                        item.Enabled = false;
                    }
                }
            }

            PR.Show();
            Close();
        }
    }
}

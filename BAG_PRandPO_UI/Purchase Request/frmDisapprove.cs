using System;
using System.Windows.Forms;

namespace BAG_PRandPO_UI.Purchase_Request
{
    public partial class frmDisapprove : Form
    {
        public frmDisapprove()
        {
            InitializeComponent();
        }

        private void btnCorrection_Click(object sender, EventArgs e)
        {
            ChangeStatus("correction");
        }

        private void btnDisapprove_Click(object sender, EventArgs e)
        {

            ChangeStatus("disapprove");
        }

        private void ChangeStatus(string btn)
        {
            frmNewPR PRform = new frmNewPR();

            foreach (Control item in PRform.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = false;
                }
                else if (item is Label)
                {
                    if (item.Name == "lblStatus")
                    {
                        item.Visible = true;

                        if (btn == "correction")
                        {
                            item.Text = "For Correction";
                        }
                        else if (btn == "disapprove")
                        {
                            item.Text = "Disapproved";
                        }

                    }
                }
            }

            PRform.Show();
            Close();
        }
    }
}

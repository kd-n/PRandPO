using System;
using System.Windows.Forms;

namespace BAG_PRandPO_UI.Purchase_Request
{
    public partial class frmCancelPopup : Form
    {
        public frmCancelPopup()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

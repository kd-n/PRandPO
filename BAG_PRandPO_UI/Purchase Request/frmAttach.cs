using System;
using System.Windows.Forms;

namespace BAG_PRandPO_UI.Purchase_Request
{
    public partial class frmAttach : Form
    {
        public frmAttach()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = dialog.FileName;
            }
        }
    }
}

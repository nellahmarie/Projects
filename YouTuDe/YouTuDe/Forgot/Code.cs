using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTuDe.Forgot
{
    public partial class Code : Form
    {
        public Code()
        {
            InitializeComponent();
        }

        private void Code_Load(object sender, EventArgs e)
        {

        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtcode.Text) == true)
            {
                btnproceed.Enabled = false;
            }
            else
            {
                btnproceed.Enabled = true;
            }
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {

        }
    }
}

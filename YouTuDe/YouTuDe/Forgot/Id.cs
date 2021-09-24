using System;
using System.IO;
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
    public partial class Id : Form
    {
        public Id()
        {
            InitializeComponent();
        }

        private void Id_Load(object sender, EventArgs e)
        {
            var YouTude = Path.GetDirectoryName(Application.ExecutablePath) + "\\Image\\YouTuDe.png";
            pbLogo.Image = Image.FromFile(YouTude);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            int convertedId;

            if (String.IsNullOrWhiteSpace(txtId.Text) == true)
            {
                btnreset.Enabled = false;
            }
            else
            {
                btnreset.Enabled = true;
                
                if (!(Int32.TryParse(txtId.Text, out convertedId)))
                {
                    btnreset.Enabled = false;
                }
                else
                {
                    btnreset.Enabled = true;
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {

        }
    }
}

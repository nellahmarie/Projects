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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void Password_Load(object sender, EventArgs e)
        {

        }

        private void txtpassword2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtpassword2.Text) == true)
            {
                lblstatus.Visible = false;
                btnchangepassword.Enabled = false;
            }
            else
            {
                if (txtpassword2.Text == txtpassword1.Text)
                {
                    lblstatus.Visible = true;
                    lblstatus.Text = "✔";
                    lblstatus.ForeColor = Color.Green;
                    btnchangepassword.Enabled = true;
                }
                else
                {
                    lblstatus.Visible = true;
                    lblstatus.Text = "✖";
                    lblstatus.ForeColor = Color.Red;
                }
            }
        }

        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            
        }
    }
}

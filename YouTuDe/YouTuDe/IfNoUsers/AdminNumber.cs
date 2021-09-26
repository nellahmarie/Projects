using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTuDe.IfNoUsers
{
    public partial class AdminNumber : Form
    {
        public AdminNumber()
        {
            InitializeComponent();
        }

        private void AdminNumber_Load(object sender, EventArgs e)
        {

        }

        private void txtadminnumber_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtadminnumber.Text) == true)
            {
                btnsave.Enabled = false;
            }
            else
            {
                if (!(Int32.TryParse(txtadminnumber.Text, out int convertedNumber)))
                {
                    btnsave.Enabled = false;
                }
                else
                {
                    btnsave.Enabled = true;
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "INSERT INTO users() VALUES() ";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                Function.Function.command.ExecuteNonQuery();



                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTuDe
{
    public partial class PendingDriverUserControl : UserControl
    {
        public string userid;
        public string firstname;
        public string lastname;
        public string age;
        public string number;
        public string Profile;
        public string Username;
        public string Password;
        public string Rolename;

        public PendingDriverUserControl()
        {
            InitializeComponent();
        }

        private void PendingDriverUserControl_Load(object sender, EventArgs e)
        {
            lblfullname.Text = firstname + " " + lastname;
            lblage.Text = age;
            lblphonenumber.Text = number;
            DisplayProfile();
        }

        private void DisplayProfile()
        {
            try
            {
                var image = Path.GetDirectoryName(Application.ExecutablePath) + "\\Profile\\" + Profile;
                pbprofile.Image = Image.FromFile(image);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            try
            {
                
                Connection.Connection.DB();
                Function.Function.gen = "INSERT INTO users(firstname, lastname, age, profile, userNumber, username, password, rolename) VALUES('"+firstname+"', '"+lastname+"', '"+age+"', '"+Profile+"', '"+number+"', '"+Username+"', '"+Password+"', '"+Rolename+"') ";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                Function.Function.command.ExecuteNonQuery();

                try
                {
                    Connection.Connection.DB();
                    Function.Function.gen = "DELETE FROM pendingDriver WHERE userid = '"+userid+"' ";
                    Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                    Function.Function.command.ExecuteNonQuery();

                    MessageBox.Show("Driver Accepted, please check it in your Driver's List", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Admin.Drivers drivers = new Admin.Drivers();
                    drivers.RefreshFlowLayout();

                    Connection.Connection.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndeny_Click(object sender, EventArgs e)
        {
            string text = "Are you sure you want to delete this drivers application?";
            string caption = "Delete";
            DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Connection.Connection.DB();
                    Function.Function.gen = "DELETE FROM pendingDriver WHERE userid = '" + userid + "' ";
                    Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.conn);
                    Function.Function.command.ExecuteNonQuery();

                    Admin.Drivers drivers = new Admin.Drivers();
                    drivers.RefreshFlowLayout();

                    Connection.Connection.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YouTuDe.Connection
{
    class Connection
    {
        public static SqlConnection conn;
        private static string connect = "Data Source=DESKTOP-Q4Sl8VR;Initial Catalog=YouTuDe;Integrated Security=True";

        public static void DB()
        {
            try
            {
                conn = new SqlConnection(connect);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTuDe
{
    public partial class TouristUserControl : UserControl
    {
        public string Fullname;
        public TouristUserControl()
        {
            InitializeComponent();
        }

        private void TouristUserControl_Load(object sender, EventArgs e)
        {
            lblfullname.Text = Fullname;
        }
    }
}

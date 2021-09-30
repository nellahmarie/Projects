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
    public partial class AdminViewSpotsUserControl : UserControl
    {
        public string attractionId;
        public string touristAttraction;
        public string touristDestination;
        public string attractionImage;
        public string attractionCost;
        public string attractionDescription;

        public AdminViewSpotsUserControl()
        {
            InitializeComponent();
        }

        private void AdminViewSpotsUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}

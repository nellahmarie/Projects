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
            lblattraction.Text = touristAttraction;
            lbldestination.Text = touristDestination;
            lblcost.Text = attractionCost;
            lbldescription.Text = attractionDescription;

            DisplayProfile();
        }

        private void DisplayProfile()
        {
            try
            {
                var image = Path.GetDirectoryName(Application.ExecutablePath) + "\\Attractions\\" + attractionImage;
                pbprofile.Image = Image.FromFile(image);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

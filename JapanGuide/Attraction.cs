using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapanGuide
{
    public partial class Attraction : Form
    {
        //
        // ΚΟΝΣΤΡΑΚΤΟΡΑΣ ΚΑΙ ΑΛΛΑΓΗ ΟΝΟΜΑΤΟΣ ΚΑΡΤΕΛΑΣ
        //
        public Attraction(String attractionName)
        {
            InitializeComponent();
            this.Text = attractionName;
        }
        //
        // ΦΟΡΤΩΣΗ ΣΤΟΙΧΕΙΩΝ ΚΑΤΑ ΤΗΝ ΔΗΜΙΟΥΡΓΙΑ ΤΗΣ ΦΟΡΜΑΣ
        //
        private void Attraction_Load(object sender, EventArgs e)
        {
            LoadInfo();
            lbl_Title.Text = this.Text;
        }
        //
        // ΦΟΡΤΩΣΗ ΠΛΗΡΟΦΟΡΙΩΝ ΚΑΙ ΕΙΚΟΝΩΝ / ΔΗΜΙΟΥΡΓΙΑ SLIDESHOW
        //
        private void LoadInfo()
        {
            try
            {
                //
                // ΦΟΡΤΩΣΗ ΕΙΚΟΝΩΝ ΚΑΙ ΚΕΙΜΕΝΟΥ
                //
                rtxt_Info.Rtf = (String)Properties.Resources.ResourceManager.GetObject($"{this.Text}_INFO");
                pct_Map.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{this.Text}_MAP");
                //
                // ΔΗΜΙΟΥΡΓΙΑ SLIDESHOW
                //
                List<Image> images = new List<Image>();
                for (int i = 1; i <= 3; i++)
                {
                    images.Add((Bitmap)Properties.Resources.ResourceManager.GetObject($"{this.Text}_IMAGE{i}"));
                }
                Slideshow slideshow = new Slideshow(images.ToArray());
                pnl_Slideshow.Controls.Add(slideshow);
                slideshow.StartSlider();
            }
            catch (Exception) { }
        }
        //
        // ΚΑΤΑ ΤΗΝ ΕΣΤΙΑΣΗ ΣΤΗ ΦΟΡΜΑ ΤΟ ΜΕΝΟΥ ΜΕΤΑΦΕΡΕΤΑΙ ΣΤΗ ΦΟΡΜΑ
        //
        private void Attraction_Activated(object sender, EventArgs e)
        {
            pnl_Tools.Controls.Clear();
            pnl_Tools.Controls.Add(CustomMenuStrip.activeMenu);
            Owner.Hide();
        }
        //
        // ΚΟΥΜΠΙ ΕΞΟΔΟΥ
        //
        private void btn_Exit_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = Properties.Resources.exit_animated;
        }
        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = Properties.Resources.exit_static;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        // ΚΟΥΜΠΙ ΕΠΙΣΤΡΟΦΗΣ "ΠΙΣΩ"
        //
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
        //
        // ΚΛΕΙΣΙΜΟ ΦΟΡΜΑΣ ΜΕΣΩ ΕΛΕΓΧΟΥ ΠΑΡΑΘΥΡΟΥ
        //
        private void Attraction_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

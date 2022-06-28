using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapanGuide
{
    public partial class JapanMap : Form
    {
        //
        // ΚΟΝΣΤΡΑΚΤΟΡΑΣ
        //
        public JapanMap()
        {
            InitializeComponent();
        }
        //
        // ΦΟΡΤΩΣΗ ΦΟΡΜΑΣ / ΚΛΕΙΔΩΜΑ ΣΕ ΠΕΡΙΠΤΩΣΗ GUEST / ΑΡΧΙΚΟΠΟΙΗΣΗ ΕΠΙΛΟΓΗΣ ΠΕΡΙΟΧΗΣ / ΟΡΙΣΜΟΣ ΠΗΓΗΣ ΚΕΙΜΕΝΟΥ ΕΚΤΥΠΩΣΗΣ
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            // ΣΕ ΠΕΡΙΠΤΩΣΗ ΕΠΙΣΚΕΠΤΗ
            if (LoginForm.user.Equals("Guest"))
            {
                foreach(LinkLabel linkLabel in pnl_Links.Controls.OfType<LinkLabel>())
                {
                    linkLabel.Enabled = false;
                }
            }
            // ΑΡΧΙΚΗ ΕΠΙΛΕΓΜΕΝΗ ΠΕΡΙΟΧΗ
            SetLinks("Kanto");
            // ΑΛΛΑΓΗ ΠΗΓΗΣ ΚΕΙΜΕΝΟΥ ΠΡΟΣ ΕΚΤΥΠΩΣΗ
            CustomMenuStrip.activeMenu.SetSource(rtxt_Info);
        }
        //
        // ΚΙΝΗΣΗ ΠΟΝΤΙΚΙΟΥ ΠΑΝΩ ΣΤΟ ΧΑΡΤΗ ΚΑΙ ΑΛΛΑΓΗ ΠΕΡΙΟΧΗΣ
        //
        private void pct_map_MouseMove(object sender, MouseEventArgs e)
        {
            int positionX = MousePosition.X - this.Location.X;
            int positionY = MousePosition.Y - this.Location.Y;
            if (positionX >= 370 && positionX <= 455 && positionY >= 385 && positionY <= 475)
            {
                //MessageBox.Show("KANTO");
                SetLinks("Kanto");
            }
            else if (positionX >= 100 && positionX <= 200 && positionY >= 465 && positionY <= 625)
            {
                //MessageBox.Show("KYUSHU");
                SetLinks("Kyushu");
            }
            else if (positionX >= 400 && positionX <= 590 && positionY >= 85 && positionY <= 250)
            {
                //MessageBox.Show("HOKKAIDO");
                SetLinks("Hokkaido");
            }
            else if (positionX >= 260 && positionX <= 345 && positionY >= 435 && positionY <= 520)
            {
                //MessageBox.Show("KANSAI");
                SetLinks("Kansai");
            }
        }
        //
        // ΜΕΘΟΔΟΣ ΓΙΑ ΑΛΛΑΓΗ ΠΛΗΡΟΦΟΡΙΩΝ ΚΑΙ ΕΙΚΟΝΩΝ ΜΕΤΑ ΤΗΝ ΑΛΛΑΓΗ ΠΕΡΙΟΧΗΣ
        //
        private void SetLinks(String str)
        {
            //
            // ΟΡΙΣΜΟΣ ΤΙΤΛΟΥ ΠΕΡΙΟΧΗΣ ΚΑΙ ΣΥΜΠΛΗΡΩΣΗ ΚΕΝΩΝ ΓΙΑ ΣΩΣΤΟ ΚΕΝΤΡΑΡΙΣΜΑ (ΙΣΟΣ ΑΡΙΘΜΟΣ ΧΑΡΑΚΤΗΡΩΝ)
            //
            String title = String.Empty;
            for(int i = 0; i < 8 - str.Length; i++)
            {
                title += ' ';
            }
            title += str;
            lbl_title.Text = title;
            //
            // ΠΛΗΡΟΦΟΡΙΕΣ ΠΕΡΙΟΧΗΣ/ ΙΔΙΟΤΗΤΕΣ ΣΥΝΔΕΣΜΩΝ
            //
            try
            {
                //
                // ΣΥΜΠΛΗΡΩΣΗ ΠΛΗΡΟΦΟΡΙΩΝ ΠΕΡΙΟΧΗΣ ΣΤΟ RICH TEXT BOX
                //
                rtxt_Info.Rtf = Properties.Resources.ResourceManager.GetString($"{str}_INFO");
                rtxt_Info.Tag = str;

                //
                // ΟΡΙΣΜΟΣ ΙΔΙΟΤΗΤΩΝ ΣΥΝΔΕΣΜΩΝ (LINK LABEL) / ΕΛΕΓΧΟΣ ΓΙΑ ΑΥΤΑ ΠΟΥ ΕΧΕΙ ΓΙΝΕΙ ΗΔΗ ΕΠΙΣΚΕΨΗ
                //
                // 1. ΔΙΑΒΑΣΜΑ ΑΡΧΕΙΟΥ ΜΕ ΟΝΟΜΑΣΙΕΣ ΠΡΟΟΡΙΣΜΩΝ
                String[] attractionNameList = Properties.Resources.ResourceManager.GetString($"{str}_LIST").Split(',');
                // 2. ΕΠΑΝΑΛΗΨΗ ΓΙΑ ΕΙΣΑΓΩΓΗ ΠΛΗΡΟΦΟΡΙΑΣ ΣΤΟΥΣ ΣΥΝΔΕΣΜΟΥΣ
                int i = 0;
                foreach(LinkLabel linkLabel in pnl_Links.Controls.OfType<LinkLabel>())
                {
                    linkLabel.Tag = attractionNameList[i++];
                    // 3. ΕΛΕΓΧΟΣ ΗΔΗ ΕΠΙΣΚΕΨΗΣ
                    if (MainMenu.linksList.Contains(attractionNameList[i]))
                    {
                        linkLabel.LinkVisited = true;
                    }
                    else
                    {
                        linkLabel.LinkVisited = false;
                    }
                    linkLabel.Text = attractionNameList[i++];
                }
                //
                // ΑΛΛΑΓΗ ΕΙΚΟΝΑΣ ΜΕ ΤΗΝ ΕΙΚΟΝΑ ΤΟΥ ΠΡΩΤΟΥ ΠΡΟΟΡΙΣΜΟΥ (ΧΡΗΣΗ ΜΕΘΟΔΟΥ ΑΠΟ ΤΟΝ EVENT HANDLER ΤΩΝ ΣΥΝΔΕΣΜΩΝ
                //
                llbl_attraction_MouseEnter(llbl_attraction1, null);
                //
                // ΑΛΛΑΓΗ ΦΩΤΟΓΡΑΦΙΑΣ ΧΑΡΤΗ ΜΕΤΑ ΤΗΝ ΑΛΛΑΓΗ ΠΕΡΙΟΧΗΣ
                //
                pct_map.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"map_{str.ToLower()}");
                //
                // ΑΛΛΑΓΗ ΧΡΩΜΑΤΟΣ ΕΠΙΛΕΓΜΕΝΗΣ ΤΑΜΠΕΛΑΣ ΣΤΟΝ ΧΑΡΤΗ
                //
                foreach (Label label1 in pnl_Map.Controls.OfType<Label>())
                {
                    if (label1.Text.Equals(str))
                    {
                        label1.ForeColor = Color.Red;
                    }
                    else
                    {
                        label1.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception) { }
        }
        //
        // EVENT HANDLER ΓΙΑ ΕΠΙΛΟΓΗ ΣΥΝΔΕΣΜΟΥ ΠΡΟΟΡΙΣΜΟΥ
        //
        private void llbl_attraction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // CAST ΣΕ ΣΥΝΔΕΣΜΟ
            LinkLabel linkLabel = (LinkLabel)sender;
            // ΑΛΛΑΓΗ ΧΡΩΜΑΤΟΣ ΣΥΝΔΕΣΜΟΥ
            linkLabel.LinkVisited = true;
            // ΔΗΜΙΟΥΡΓΙΑ ΚΑΙ ΑΝΟΙΓΜΑ ΦΟΡΜΑΣ ΓΙΑ ΠΡΟΟΡΙΣΜΟ
            new Attraction(linkLabel.Tag.ToString()).Show(this);
            // ΑΠΟΘΗΚΕΥΣΗ ΕΠΙΣΚΕΨΗΣ ΧΡΗΣΤΗ ΣΤΗ ΦΟΡΜΑ ΤΟΥ ΠΡΟΟΡΙΣΜΟΥ
            CustomMenuStrip.activeMenu.SaveToHistory(linkLabel.Text);
            // ΠΡΟΣΘΗΚΗ ΣΤΗ ΛΙΣΤΑ ΙΣΤΟΡΙΚΟΥ (ΕΑΝ ΔΕΝ ΥΠΑΡΧΕΙ)
            if (!MainMenu.linksList.Contains(linkLabel.Text))
            {
                MainMenu.linksList.Add(linkLabel.Text);
            }
        }
        //
        // EVENT HANDLER ΑΛΛΑΓΗ ΕΙΚΟΝΑΣ ΠΡΟΕΠΙΣΚΟΠΗΣΗΣ ΟΤΑΝ ΤΟ ΠΟΝΤΙΚΙ ΠΕΡΝΑΕΙ ΠΑΝΩ ΑΠΟ ΕΝΑ ΣΥΝΔΕΣΜΟ
        //
        private void llbl_attraction_MouseEnter(object sender, EventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            pct_AttractionPreview.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{link.Tag}_IMAGE1");
        }
        //
        // EVENT HANDLER ΑΛΛΑΓΗ ΕΠΙΛΕΓΜΕΝΗΣ ΠΕΡΙΟΧΗΣ ΜΕΤΑ ΤΟ ΠΑΤΗΜΑ ΣΥΝΔΕΣΜΟΥ ΠΑΝΩ ΣΤΟ ΧΑΡΤΗ
        //
        private void lbl_Region_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            SetLinks(label.Text);
        }
        //
        // EVENT HANDLER ΟΤΑΝ Η ΦΟΡΜΑ ΕΙΝΑΙ Η ΕΣΤΙΑΣΜΕΝΗ ΕΜΦΑΝΙΣΗ ΜΕΝΟΥ
        //
        private void JapanMap_Activated(object sender, EventArgs e)
        {
            pnl_Tools.Controls.Clear();
            pnl_Tools.Controls.Add(CustomMenuStrip.activeMenu);
            Owner.Hide();
        }
        //
        // EVENT HANDLERS ΚΟΥΜΠΙΟΥ ΕΞΟΔΟΥ
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
        // EVENT HANDLER ΓΙΑ ΚΛΕΙΣΙΜΟ ΦΟΡΜΑΣ ΑΠΟ ΤΟΝ ΕΛΕΓΧΟ ΠΑΡΑΘΥΡΟΥ
        //
        private void JapanMap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapanGuide
{
    public partial class MainMenu : Form
    {
        //ΔΗΛΩΣΗ ΜΕΤΑΒΛΗΤΩΝ
        public static List<String> linksList = new List<String>();
        public static List<String> openedEvents = new List<String>();
        String[] info = Properties.Resources.titles.Split('\n');
        //
        //ΚΟΝΣΤΡΑΚΤΟΡΑΣ
        //
        public MainMenu()
        {
            InitializeComponent();
        }
        //
        //ΟΤΑΝ ΦΟΡΤΩΝΕΙ Η ΦΟΡΜΑ
        //
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //ΠΡΟΣΘΗΚΗ SLIDER ΚΑΙ MENUSTRIP
            AddSlider();
            pnl_Tools.Controls.Add(new CustomMenuStrip());
            btn_Focused(btn_Sightseeing, null);
            //ΕΑΝ Ο USER ΕΙΝΑΙ GUEST ΑΠΕΝΕΡΓΟΠΟΙΗΣΗ ΚΟΥΜΠΙΩΝ
            if (LoginForm.user.Equals("Guest"))
            {
                btn_Events.Enabled = false;
                btn_Food.Enabled = false;
                btn_Transportation.Enabled = false;
            }
        }
        //
        //ΕΝΕΡΓΟΠΟΙΗΣΗ SLIDER
        //
        private void AddSlider()
        {
            Slideshow slideshow = new Slideshow(new Image[] { Properties.Resources.SLIDE_IMAGE1, Properties.Resources.SLIDE_IMAGE2, Properties.Resources.SLIDE_IMAGE3 });
            pnl_Top.Controls.Add(slideshow);
            pnl_Top.Controls.OfType<Slideshow>().First().StartSlider();
        }

        //
        // SIDE PANEL BUTTON EVENTS
        //
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            pnl_Tools.Controls.Clear();
            switch (button.TabIndex)
            {
                case 0:
                    CustomMenuStrip.activeMenu.SaveToHistory("Αξιοθέατα");
                    new JapanMap().Show(this);
                    break;
                case 1:
                    CustomMenuStrip.activeMenu.SaveToHistory("Εκδηλώσεις");
                    new Events().Show(this);
                    break;
                case 2:
                    CustomMenuStrip.activeMenu.SaveToHistory("Φαγητό");
                    new Food().Show(this);
                    break;
                case 3:
                    CustomMenuStrip.activeMenu.SaveToHistory("Μετακίνηση");
                    new Transportation().Show(this);
                    break;
            }
        }

        //
        //ΕΦΕ ΚΟΥΜΠΙΟΥ ΣΤΟ ΟΠΟΙΟ ΕΧΕΙ ΕΣΤΙΑΣΕΙ Ο ΧΡΗΣΤΗΣ
        //
        private void btn_Focused(object sender, EventArgs e)
        {
            foreach (Button button1 in pnl_NavMenu.Controls.OfType<Button>())
            {
                button1.Image = null;
                button1.BackColor = Color.Transparent;
            }

            Button button = (Button)sender;
            button.Image = Properties.Resources.leaves;
            button.BackColor = Color.FromArgb(193, 172, 199);

            lbl_title.Text = info[button.TabIndex];
            txt_info.Text = info[button.TabIndex+1];
        }
        //
        //ΕΣΤΙΑΖΕΤΑΙ ΤΟ ΚΟΥΜΠΙ ΑΠΟ ΤΟ MOUSE ENTER
        //
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Focus();
        }
        //
        ///ΟΤΑΝ ΕΣΤΙΑΖΕΙ ΤΟ ΠΡΟΓΡΑΜΜΑ ΣΤΗΝ ΦΟΡΜΑ
        //
        private void MainMenu_Activated(object sender, EventArgs e)
        {
            pnl_Tools.Controls.Add(CustomMenuStrip.activeMenu);
            CustomMenuStrip.activeMenu.SetSource(new RichTextBox());
        }
        //
        //ΚΟΥΜΠΙ ΕΞΟΔΟΥ
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
        // ΚΛΕΙΣΙΜΟ ΦΟΡΜΑΣ ΜΕΣΩ ΕΛΕΓΧΟΥ ΠΑΡΑΘΥΡΟΥ
        //
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

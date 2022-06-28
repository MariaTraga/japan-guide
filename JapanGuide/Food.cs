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
    public partial class Food : Form
    {
        //
        //ΚΟΝΣΤΡΑΚΤΟΡΑΣ
        //
        public Food()
        {
            InitializeComponent();
        }
        //
        //ΚΟΥΜΠΙΑ ΕΠΙΛΟΓΗΣ ΦΑΓΗΤΟΥ
        //
        private void btn_Food_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{button.Tag}_animated");
        }
        private void btn_Food_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.FlatStyle == FlatStyle.Flat)
            {
                return;
            }
            button.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{button.Tag}_static");
        }
        private void btn_Food_Click(object sender, EventArgs e)
        {
            //ΟΛΑ ΤΑ ΚΟΥΜΠΙΑ ΓΙΝΟΝΤΑΙ STATIC ANIMATED
            foreach (Button button1 in pnl_Buttons.Controls.OfType<Button>())
            {
                button1.FlatStyle = FlatStyle.Standard;
                button1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{button1.Tag}_static");
            }
            //ΤΟ ΚΟΥΜΠΙ ΠΟΥ ΕΣΤΕΙΛΕ ΤΟ EVENT ΓΙΝΕΤΑΙ ANIMATED
            Button button = (Button)sender;
            button.FlatStyle = FlatStyle.Flat;
            button.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{button.Tag}_animated");

            //ΠΡΟΣΘΗΚΗ ΤΟΥ ΑΡΧΕΙΟΥ RTF ΣΤΗΝ ΦΟΡΜΑ
            richTextBox1.Rtf = Properties.Resources.ResourceManager.GetString(button.Tag.ToString());
            richTextBox1.Tag = button.Text;
        }
        //
        //ΟΤΑΝ ΕΣΤΙΑΖΕΙ ΤΟ ΠΡΟΓΡΑΜΜΑ ΣΤΗΝ ΦΟΡΜΑ
        //
        private void Food_Activated(object sender, EventArgs e)
        {
            pnl_Tools.Controls.Clear();
            pnl_Tools.Controls.Add(CustomMenuStrip.activeMenu);
            Owner.Hide();
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
        //ΟΤΑΝ ΦΟΡΤΩΝΕΙ Η ΦΟΡΜΑ
        //
        private void Food_Load(object sender, EventArgs e)
        {
            CustomMenuStrip.activeMenu.SetSource(richTextBox1);
        }
        //
        // ΚΛΕΙΣΙΜΟ ΦΟΡΜΑΣ ΜΕΣΩ ΕΛΕΓΧΟΥ ΠΑΡΑΘΥΡΟΥ
        //
        private void Food_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

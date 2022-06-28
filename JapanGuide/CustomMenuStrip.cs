using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace JapanGuide
{
    public partial class CustomMenuStrip : UserControl
    {
        //
        //ΔΗΛΩΣΗ ΜΕΤΑΒΛΗΤΩΝ
        //
        public static CustomMenuStrip activeMenu;
        private RichTextBox richTextBox = new RichTextBox();
        private List<String> history = new List<string>();
        //
        //ΚΟΝΣΤΡΑΚΤΟΡΑΣ / ΘΕΤΟΥΜΕ ΣΕ ΜΙΑ ΣΤΑΤΙΚΗ ΜΕΤΑΒΛΗΤΗ ΤΟ ΕΝΕΡΓΟ INSTANCE ΤΗΣ ΚΛΑΣΗΣ ΚΑΙ ΕΤΣΙ ΕΧΟΥΜΕ ΠΡΟΣΒΑΣΗ ΣΕ ΑΥΤΟ ΟΠΟΙΑΔΗΠΟΤΕ ΣΤΙΓΜΗ ΜΕΣΩ ΤΗΣ ΚΛΑΣΗΣ 
        //
        public CustomMenuStrip()
        {
            InitializeComponent();
            activeMenu = this;
        }
        //
        //ΚΑΤΑΧΩΡΗΣΗ ΤΟΥ RICHTEXTBOX ΤΟ ΟΠΟΙΟ ΕΧΕΙ ΕΜΦΑΝΙΣΤΕΙ ΣΤΟΜΝ ΧΡΗΣΤΗ
        //
        public void SetSource(RichTextBox newRichTextBox)
        {
            richTextBox = newRichTextBox;
        }
        //
        //ΜΕ ΤΗΝ ΦΟΡΤΩΣΗ ΤΟΥ MENUSTRIP ΤΟΠΟΘΕΤΗΣΗ ΣΤΗΝ ΦΟΡΜΑ ΚΑΙ ΤΟΠΟΘΕΤΗΣΗ ΤΟΥ SOUNDCONTROL
        //
        private void MenuStrip_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            SoundControl sc = new SoundControl();
            sc.Location = new Point(170, 0);
            pnl_SoundANDInfo.Controls.Add(sc);
            sc.BringToFront();
            sc.Anchor = AnchorStyles.Right;
            label1.Text = LoginForm.user;
        }
        //
        //ΑΠΟΘΗΚΕΥΣΗ ΣΤΟ ΙΣΤΟΡΙΚΟ (ΔΙΑΤΗΡΗΣΗ ΣΕΙΡΑΣ ΚΑΙ ΟΧΙ ΔΙΠΛΗ ΕΚΧΩΡΗΣΗ)
        //
        public void SaveToHistory(String newHistoryEntry)
        {
            if (history.Contains(newHistoryEntry))
            {
                history.Remove(newHistoryEntry);
            }
            history.Add(newHistoryEntry);
            LoadHistory();
        }
        //
        //ΚΑΘΑΡΙΣΜΟΣ ΙΣΤΟΡΙΚΟΥ
        //
        public void ClearHistory()
        {
            history.Clear();
            recentHistoryToolStripMenuItem.DropDownItems.Clear();
            MainMenu.linksList.Clear();
            MainMenu.openedEvents.Clear();
        }
        //
        //ΔΙΑΓΡΑΦΕΙ ΤΑ ΠΡΟΗΓΟΥΜΕΝΑ ΚΑΙ ΒΑΖΕΙ ΤΙΣ 10 ΠΡΩΤΕΣ ΕΚΧΩΡΗΣΕΙΣ ΣΤΟ ΙΣΤΟΡΙΚΟ (ΕΝΗΜΕΡΩΝΕΙ ΤΟ ΙΣΤΟΡΙΚΟ)
        //
        public void LoadHistory()
        {
            recentHistoryToolStripMenuItem.DropDownItems.Clear();
            int index = history.Count;
            for (int i = index - 1; i>= 0; i--)
            {
                recentHistoryToolStripMenuItem.DropDownItems.Add(history[i]);
                if(index - i == 10)
                {
                    break;
                }
            }
        }

        //
        //ΕΞΑΓΩΓΗ ΣΤΟΙΧΕΙΩΝ ΟΠΟΥ ΕΞΑΓΕΙ ΤΟ ΕΠΙΛΕΓΜΕΝΟ RICHTEXTBOX (ΑΠΟ ΜΕΘΟΔΟ GETSOURCE) 
        //
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox.Tag == null || richTextBox.Tag.ToString().Length.Equals(0))
                {
                    throw new Exception();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Δεν υπάρχει κάτι επιλεγμένο προς εξαγωγή");
                return;
            }
            saveFileDialog1.Title = "Αποθήκευση των επιλεγμένων πληροφοριών.";
            saveFileDialog1.Filter = "txt files(*.txt) | *.txt";
            saveFileDialog1.ShowDialog();
        }
        //
        //ΚΑΛΕΣΜΑ ΜΕΘΟΔΟΥ ΚΑΘΑΡΙΣΜΟΥ ΙΣΤΟΡΙΚΟΥ
        //
        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearHistory();
        }
        //
        //ΕΠΙΣΤΡΟΦΗ ΣΤΗΝ ΑΡΧΙΚΗ ΣΕΛΙΔΑ
        //
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = Application.OpenForms.OfType<MainMenu>().Last();
            //ΕΛΕΓΧΟΣ ΕΑΝ Η ΑΡΧΙΚΗ ΣΕΛΙΔΑ ΕΙΝΑΙ ΕΜΦΑΝΗΣ Ή ΟΧΙ
            if(mainMenu.Visible)
            {
                MessageBox.Show("Είστε ήδη στην αρχική σελίδα!");
            }
            else
            {
                ParentForm.Hide();
                mainMenu.Show();
            }
        }
        //
        //ΑΠΟΣΥΝΔΕΣΗ ΧΡΗΣΤΗ
        //
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    form.Hide();
                }
                Application.OpenForms.OfType<LoginForm>().First().Show();
            }
            catch { }
        }
        //
        //ΑΠΟΘΗΚΕΥΣΗ ΑΡΧΕΙΟΥ ΠΟΥ ΔΙΑΛΕΞΕ Ο ΧΡΗΣΤΗΣ ΓΙΑ ΕΞΑΓΩΓΗ
        //
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            String fileName = saveFileDialog1.FileName;
            String plainText = richTextBox.Text;
            File.WriteAllText(fileName, richTextBox.Tag + Environment.NewLine + plainText);
        }
        //
        //ΚΟΥΜΠΙ ABOUT
        //
        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή αυτή δημιουργήθηκε από τους:\nΜαρία Τράγα\nΜΠΠΛ19058\n\nΔημήτρη Μάλλιαρη\nΜΠΠΛ19034");
        }
    }
}

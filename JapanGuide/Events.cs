using Microsoft.VisualBasic.FileIO;
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
    public partial class Events : Form
    {
        //ΔΗΛΩΣΗ ΜΕΤΑΒΛΗΤΩΝ
        DataTable dt = new DataTable();
        
        int index = -1;
        //
        //ΚΟΝΣΤΡΑΚΤΟΡΑΣ
        //
        public Events()
        {
            InitializeComponent();
        }
        //
        //ΟΤΑΝ ΦΟΡΤΩΝΕΙ Η ΦΟΡΜΑ
        //
        private void Events_Load(object sender, EventArgs e)
        {
            ReadCSV();
            CustomMenuStrip.activeMenu.SetSource(rtxt_Info);
            //ΕΑΝ Ο ΧΡΗΣΤΗΣ ΕΧΕΙ ΗΔΗ ΕΠΙΣΚΕΦΘΕΙ ΤΟ LINKLABEL ΤΟΤΕ ΑΛΛΑΖΕΙ ΧΡΩΜΑ
            foreach(LinkLabel llbl in pnl_LinkLabels.Controls.OfType<LinkLabel>())
            {
                if (MainMenu.openedEvents.Contains(llbl.Text))
                {
                    llbl.LinkVisited = true;
                }
            }
        }
        //
        //ΟΤΑΝ ΑΛΛΑΞΕΙ Η ΗΜΕΡΟΜΗΝΙΑ ΣΤΟ ΗΜΕΡΟΛΟΓΙΟ
        //
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //ΕΑΝ Η ΕΠΙΛΕΓΜΕΝΗ ΗΜΕΡΟΜΗΝΙΑ ΥΠΑΡΧΕΙ ΣΤΗΝ ΛΙΣΤΑ ΜΕ ΤΙΣ BOLD ΗΜΕΡΟΜΗΝΙΕΣ ΤΟΤΕ ΚΑΛΕΙΤΑΙ Η ΜΕΘΟΔΟΣ MatchEventsWithDates
            if (monthCalendar1.BoldedDates.Contains(monthCalendar1.SelectionStart.Date))
            {
                MatchEventsWithDates();
            }
            else
            {
                rtxt_Info.Text = "Δεν υπάρχουν διαθέσιμες εκδηλώσεις για την ημερομηνία που έχετε επιλέξει.";
                lbl_Title.Text = "-";
                rtxt_Info.Tag = String.Empty;
            }
        }
        //
        //ΔΙΑΒΑΣΜΑ ΤΟΥ ΑΡΧΕΙΟΥ CSV
        //
        private void ReadCSV()
        {
            var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("JapanGuide.Resources.Festivals.csv");
            using (TextFieldParser tfp = new TextFieldParser(stream))
            {
                tfp.SetDelimiters(",");
                tfp.HasFieldsEnclosedInQuotes = true;
                bool firstline = true;

                while (!tfp.EndOfData)
                {
                    string[] eventsData = tfp.ReadFields();
                    if (firstline)
                    {
                        foreach (var header in eventsData)
                        {
                            dt.Columns.Add(header);
                        }

                        firstline = false;
                        continue;
                    }
                    dt.Rows.Add(eventsData);
                }
            }
        }
        //
        //ΕΛΕΓΟΧΣ ΤΩΝ ΗΜΕΡΟΜΗΝΙΩΝ ΚΑΙ ΑΝΤΙΣΤΟΙΧΙΣΗ ΜΕ ΤΗΝ ΚΑΘΕ ΕΚΔΗΛΩΣΗ
        //
        private void MatchEventsWithDates()
        {
            //ΓΙΑ ΟΛΕΣ ΤΙΣ BOLD ΗΜΕΡΟΜΗΝΙΕΣ
            for(int i = 0; i< monthCalendar1.BoldedDates.Length; i++)
            {
                //ΕΑΝ Η ΕΠΙΛΕΓΜΕΝΗ ΗΜΕΡΟΜΗΝΙΑ ΤΑΥΤΙΖΕΤΑΙ ΜΕ ΤΗΝ ΕΠΙΛΕΓΜΕΝΗ
                if (monthCalendar1.SelectionStart.Date.Equals(monthCalendar1.BoldedDates[i]))
                {
                    //ΚΑΤΑΧΩΡΗΣΗ ΤΩΝ ΠΛΗΡΟΦΟΡΙΩΝ ΣΤΗΝ ΦΟΡΜΑ (ΑΠΟ ΑΡΧΕΙΟ RTF)
                    index = i;
                    lbl_Title.Text = dt.Rows[i]["title"].ToString();
                    rtxt_Info.Tag = lbl_Title.Text;
                    String rtfName = dt.Rows[i]["rtfname"].ToString();

                    //ΔΗΜΙΟΥΡΓΙΑ SLIDESHOW
                    List<Image> images = new List<Image>();
                    for(int j =1; j <= 3; j++)
                    {
                        //ΚΑΤΑΧΩΡΗΣΗ ΕΙΚΟΝΩΝ ΣΕ ΛΙΣΤΑ (ΑΝΤΙΣΤΟΙΧΙΣΗ ΟΝΟΜΑΤΟΣ ΜΕ ΤΑ RESOURCES)
                        images.Add((Bitmap)Properties.Resources.ResourceManager.GetObject($"{rtfName}{j}"));
                    }
                    pnl_Sliedshow.Controls.Clear();
                    var slideshow = new Slideshow(images.ToArray());
                    pnl_Sliedshow.Controls.Add(slideshow);
                    slideshow.StartSlider();

                    var rtf = (String)Properties.Resources.ResourceManager.GetObject(rtfName);
                    rtxt_Info.Rtf = rtf;

                    //ΑΛΛΑΓΗ ΧΡΩΜΑΤΟΣ ΤΟΥ LINKLABEL ΑΝ Η ΗΜΕΡΟΜΗΝΙΑ ΤΟΥ TAG ΕΙΝΑΙ ΙΔΙΑ ΜΕ ΤΗΝ ΕΠΙΛΕΓΜΕΝΗ ΗΜΕΡΟΜΗΝΙΑ
                    foreach (LinkLabel llbl in pnl_LinkLabels.Controls.OfType<LinkLabel>())
                    {
                        if (DateTime.Parse(llbl.Tag.ToString()).Equals(monthCalendar1.SelectionStart.Date))
                        {
                            llbl.LinkVisited = true;
                        }
                    }

                    //ΠΡΟΣΘΗΚΗ ΣΤΟ ΙΣΤΟΡΙΚΟ ΣΤΕΛΝΟΝΤΑΣ ΤΗΝ ΘΕΣΗ ΣΤΟ DATATABLE 
                    AddToHistory(i);
                    break;
                }
            }
        }

        //
        //ΠΡΟΣΘΗΚΗ ΤΟΥ ΙΣΤΟΡΙΚΟΥ ΣΤΟ MENUSTRIP ΚΑΙ ΣΤΗΝ ΛΙΣΤΑ openedEvents
        //
        private void AddToHistory(int index)
        {
                CustomMenuStrip.activeMenu.SaveToHistory(dt.Rows[index]["title"].ToString());
                MainMenu.openedEvents.Add(dt.Rows[index]["title"].ToString());
        }
        //
        //ΑΛΛΑΓΗ ΗΜΕΡΟΜΗΝΙΑΣ ΣΕ ΑΥΤΗΝ ΠΟΥ ΕΙΝΑΙ ΚΑΤΑΧΩΡΗΜΕΝΗ ΣΤΟ TAG ΤΟΥ LINKLABEL
        //
        private void llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var llbl = (LinkLabel)sender;
            monthCalendar1.SetDate(DateTime.Parse(llbl.Tag.ToString()));
        }
        //
        ///ΟΤΑΝ ΕΣΤΙΑΖΕΙ ΤΟ ΠΡΟΓΡΑΜΜΑ ΣΤΗΝ ΦΟΡΜΑ
        //
        private void Events_Activated(object sender, EventArgs e)
        {
            pnl_Tools.Controls.Clear();
            pnl_Tools.Controls.Add(CustomMenuStrip.activeMenu);
            Owner.Hide();
        }
        //
        // ΚΛΕΙΣΙΜΟ ΦΟΡΜΑΣ ΜΕΣΩ ΕΛΕΓΧΟΥ ΠΑΡΑΘΥΡΟΥ
        //
        private void Events_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
}

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
    public partial class Transportation : Form
    {
        public Transportation()
        {
            InitializeComponent();
        }

        private void Transportation_Load(object sender, EventArgs e)
        {
            btn_Planes.Image = Properties.Resources.plane_static;
            btn_Ships.Image = Properties.Resources.boat_static;
            btn_Train.Image = Properties.Resources.train_static;
            rtxt_GeneralInfo.Rtf = Properties.Resources.tr_info;
            rtxt_Info.Tag = String.Empty;
            CustomMenuStrip.activeMenu.SetSource(rtxt_Info);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var rtf = (String)Properties.Resources.ResourceManager.GetObject(btn.Tag.ToString());
            rtxt_Info.Rtf = rtf;

            if (btn.Tag.ToString().Equals("tr_ships"))
            {
                lbl_Title.Text = "Μετακίνηση με πλοία";  
            }
            else if (btn.Tag.ToString().Equals("tr_trains"))
            {
                lbl_Title.Text = "Μετακίνηση με τρένα";
            }
            else
            {
                lbl_Title.Text = "Μετακίνηση με αεροπλάνα";
            }
            rtxt_Info.Tag = lbl_Title.Text;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag.ToString().Equals("tr_ships"))
            {
                btn_Ships.Image = Properties.Resources.boat;
            }
            else if (btn.Tag.ToString().Equals("tr_trains"))
            {
                btn_Train.Image = Properties.Resources.train;
            }
            else
            {
                btn_Planes.Image = Properties.Resources.plane;
            }
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag.ToString().Equals("tr_ships"))
            {
                btn_Ships.Image = Properties.Resources.boat_static;
            }
            else if (btn.Tag.ToString().Equals("tr_trains"))
            {
                btn_Train.Image = Properties.Resources.train_static;
            }
            else
            {
                btn_Planes.Image = Properties.Resources.plane_static;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String fileName = saveFileDialog1.FileName;
            String plainText = rtxt_Info.Text;
            File.WriteAllText(fileName, lbl_Title.Text + Environment.NewLine + plainText);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbl_Title.Text.Equals("-"))
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Παρακαλώ επιλέξτε τις πληροφορίες που θέλετε να αποθηκεύσετε πρώτα.");
                return;
            }
            saveFileDialog1.Title = "Αποθήκευση των επιλεγμένων πληροφοριών.";
            saveFileDialog1.Filter = "txt files(*.txt) | *.txt";
            saveFileDialog1.ShowDialog();
        }
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

        private void Transportation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Transportation_Activated(object sender, EventArgs e)
        {
            pnl_Tools.Controls.Clear();
            pnl_Tools.Controls.Add(CustomMenuStrip.activeMenu);
            Owner.Hide();
        }
    }
}

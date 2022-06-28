using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.FileIO;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapanGuide
{
    public partial class LoginForm : Form
    {
        // ΔΗΛΩΣΗ ΜΕΤΑΒΛΗΤΩΝ
        public static String user = String.Empty;
        DataTable dt;
        //
        // ΚΟΝΣΤΡΑΚΤΟΡΑΣ
        //
        public LoginForm()
        {
            InitializeComponent();
        }
        //
        // EVENT HANDLER ΦΟΡΤΩΣΗΣ ΦΟΡΜΑΣ / ΑΝΑΓΝΩΣΗ ΔΕΔΟΜΕΝΩΝ ΧΡΗΣΤΩΝ / ΠΡΟΣΘΗΚΗ ΕΛΕΓΧΟΥ ΜΟΥΣΙΚΗΣ
        // 
        private void LoginForm_Load(object sender, EventArgs e)
        {
            ReadCSV();

            btn_Login.Select();

            SoundControl sc = new SoundControl();
            sc.Location = new Point(420, 12);
            panel1.Controls.Add(sc);
        }
        //
        // ΠΡΟΣΘΗΚΗ ΚΑΙ ΑΦΑΙΡΕΣΗ PLACEHOLDER (Guest ΛΟΓΑΡΙΑΣΜΟΣ) ΑΝΑΛΟΓΑ ΜΕ ΤΗΝ ΕΣΤΙΑΣΗ 
        //
        private void txb_Username_Enter(object sender, EventArgs e)
        {
            if (txb_Username.Text.Equals("Guest"))
            {
                txb_Username.ForeColor = Color.Black;
                txb_Username.Text = "";
            }
        }
        private void txb_Username_Leave(object sender, EventArgs e)
        {
            if (txb_Username.Text.Equals(""))
            {
                txb_Username.ForeColor = Color.Silver;
                txb_Username.Text = "Guest";
            }
        }
        private void txb_Password_Enter(object sender, EventArgs e)
        {
            if (txb_Password.Text.Equals("1234"))
            {
                txb_Password.ForeColor = Color.Black;
                txb_Password.Text = "";
            }
        }
        private void txb_Password_Leave(object sender, EventArgs e)
        {
            if (txb_Password.Text.Equals(""))
            {
                txb_Password.ForeColor = Color.Silver;
                txb_Password.Text = "1234";
            }
        }
        //
        //ΚΟΥΜΠΙ ΕΙΣΟΔΟΥ
        //
        private void btn_Login_Click(object sender, EventArgs e)
        {
            CheckUsernamePassword();
        }
        //
        //ΔΙΑΒΑΣΜΑ CSV
        //
        private void ReadCSV()
        {
            dt = new DataTable();
            //ΧΡΗΣΗ ΤΟΥ TEXTFIELDPARSER ΓΙΑ ΤΗΝ ΕΠΕΞΕΡΓΑΣΙΑ ΑΡΧΕΙΩΝ .CSV
            using (TextFieldParser tfp = new TextFieldParser("Resources/users.csv"))
            {
                //ΘΕΤΟΥΜΕ ΤΑ ΔΕΔΟΜΕΝΑ ΤΟΥ CSV ΟΠΩΣ ΤΟΝ ΔΙΑΧΩΡΙΣΜΟ ΤΟΥΣ (",") ΚΛΠ
                tfp.SetDelimiters(",");
                tfp.HasFieldsEnclosedInQuotes = true;
                bool firstline = true;

                //ΔΟΜΗ ΕΠΑΝΑΛΥΨΗΣ ΠΟΥ ΤΕΡΜΑΤΙΖΕΙ ΟΤΑΝ ΦΤΑΣΕΙ ΣΤΟ ΤΕΛΕΥΤΑΙΟ ΣΤΟΙΧΕΙΟ
                while (!tfp.EndOfData)
                {   
                    //ΕΚΧΩΡΗΣΗ ΤΗΣ ΓΡΑΜΜΗΣ ΣΕ ΕΝΑΝ ΠΙΝΑΚΑ
                    string[] userData = tfp.ReadFields();
                    //ΕΑΝ ΕΙΝΑΙ Η ΠΡΩΤΗ ΓΡΑΜΜΗ
                    if (firstline)
                    {
                        //ΔΟΜΗ ΕΠΑΝΑΛΥΨΗΣ ΠΟΥ ΕΚΧΩΡΕΙ ΤΟΥΣ ΤΙΤΛΟΥΣ ΤΩΝ ΣΤΗΛΩΝ ΤΟΥ DATATABLE
                        foreach (var header in userData)
                        {
                            dt.Columns.Add(header);
                        }
                        //ΑΛΛΑΓΗ ΤΗΣ BOOL ΜΕΤΑΒΛΗΤΗΣ ΣΕ FALSE ΟΤΑΝ ΕΚΧΩΡΗΘΟΥΝ ΟΙ ΤΙΤΛΟΙ
                        firstline = false;
                        continue;
                    }
                    //ΠΡΟΣΘΗΚΗ ΣΤΟΙΧΕΙΩΝ (ΕΚΤΟΣ ΤΩΝ ΤΙΤΛΩΝ) ΣΤΑ ΚΕΛΙΑ ΤΟΥ DATATABLE
                    dt.Rows.Add(userData);
                }
            }
        }
        //
        //ΕΠΕΞΕΡΓΑΣΙΑ CSV
        //
        private void WriteCSV()
        {
            //ΔΗΜΙΟΥΡΓΙΑ ΤΟΥ STRING ΠΟΥ ΘΑ ΕΚΧΩΡΗΘΕΙ
            int id = int.Parse(dt.Rows[dt.Rows.Count - 1]["id"].ToString()) + 1;
            String username = txb_Username.Text;
            String password = txb_Password.Text;
            String input = id.ToString() + "," + username + "," + password;

            //ΔΗΜΙΟΥΡΓΙΑ STREAM ΓΙΑ ΤΟ ΑΡΧΕΙΟ ΠΡΟΚΕΙΜΕΝΟΥ ΝΑ ΠΡΟΣΤΕΘΟΥΝ ΠΛΗΡΟΦΟΡΙΕΣ
            using (FileStream fs = new FileStream("Resources/users.csv", FileMode.Append,FileAccess.Write))
            {
                //ΔΗΜΙΟΥΡΓΙΑ STREAM ΓΙΑ ΤΗΝ ΕΠΕΞΕΡΓΑΣΙΑ ΤΟΥ ΑΡΧΕΙΟΥ
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(input);
                }
            }
        }
        //
        //ΕΛΕΓΧΟΣ ΟΝΟΜΑ ΧΡΗΣΤΗ ΚΑΙ ΚΩΔΙΚΟΥ
        //
        private void CheckUsernamePassword()
        {
            bool existsUsername = false;
            bool existsPassword = false;
            ToolTip tt_Error = new ToolTip();
            tt_Error.IsBalloon = true;
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    //ΕΑΝ ΕΙΝΑΙ ΣΩΣΤΟ ΤΟΤΕ ΕΙΣΟΔΟΣ ΣΤΟ ΠΡΟΓΡΑΜΜΑ
                    if (txb_Username.Text.Equals(row["username"].ToString()) && txb_Password.Text.Equals(row["password"].ToString()))
                    {
                        MainMenu mainMenu = new MainMenu();
                        user = row["username"].ToString();
                        this.Hide();
                        mainMenu.Show();
                        existsUsername = true;
                        existsPassword = true;
                        break;
                    }
                    //ΕΑΝ ΕΙΝΑΙ ΜΟΝΟ Ο ΚΩΔΙΚΟΣ ΛΑΘΟΣ ΤΟΤΕ ΔΗΜΙΟΥΡΓΙΑ ΤΟΥ ΚΑΤΑΛΛΗΛΟΥ TOOLTIP
                    else if(txb_Username.Text.Equals(row["username"].ToString()) && txb_Password.Text != row["password"].ToString())
                    {
                        existsUsername = true;
                        existsPassword = false;
                        break;
                    }
                    //ΕΑΝ ΕΙΝΑΙ ΤΟ ΟΝΟΜΑ ΧΡΗΣΤΗ ΛΑΘΟΣ ΤΟΤΕ ΔΗΜΙΟΥΡΓΙΑ ΤΟΥ ΚΑΤΑΛΛΗΛΟΥ TOOLTIP
                    else
                    {
                        existsUsername = false;
                    } 
                }
                if (!existsUsername)
                {
                    tt_Error.Show(String.Empty, txb_Username, 1000);
                    tt_Error.Show("Το όνομα χρήστη που εισάγατε δεν υπάρχει. Παρακαλούμε εγγραφείτε στην εφαρμογή ή ελέγξτε για τυχόν λάθη.", txb_Username, 1000); //Ίδια μέθοδος 2 φορές λόγω bug των winforms.
                    throw new Exception();
                }
                else if (!existsPassword)
                {
                    tt_Error.Show(String.Empty, txb_Password, 1000);
                    tt_Error.Show("Ο κωδικός που εισάγατε είναι λανθασμένος. Παρακαλούμε ελέγξτε για τυχόν λάθη.", txb_Password, 1000); //Ίδια μέθοδος 2 φορές λόγω bug των winforms.
                    throw new Exception();
                }
            }
            catch
            {
                //Error
            } 
        }
        // 
        // ΚΟΥΜΠΙ ΕΞΟΔΟΥ
        //
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //ΚΟΥΜΠΙ ΕΓΓΡΑΦΗΣ
        //
        private void btn_Signup_Click(object sender, EventArgs e)
        {
            try
            {

                if(txb_Username.Text.Equals(String.Empty) || txb_Password.Text.Equals(String.Empty))
                {
                    throw new Exception("Παρακαλούμε συμπληρώστε τα στοιχεία σας για να συνεχίση η εγγραφή");
                }
                else
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        if (txb_Username.Text.Equals(row["username"].ToString()))
                        {
                            throw new Exception("Το όνομα χρήστη υπάρχει ήδη.");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            WriteCSV();
            ReadCSV();
            MessageBox.Show("Ο χρήστης καταχωρήθηκε επιτυχώς!");
        }
        //
        //ΚΟΥΜΠΙ ABOUT
        //
        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εφαρμογή αυτή δημιουργήθηκε από τους:\nΜαρία Τράγα\nΜΠΠΛ19058\n\nΔημήτρη Μάλλιαρη\nΜΠΠΛ19034");
        }
        //
        //ΕΞΟΔΟΣ ΑΠΟ ΤΗΝ ΕΦΑΡΜΟΓΗ
        //
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }       
}

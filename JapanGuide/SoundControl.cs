using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;

namespace JapanGuide
{
    public partial class SoundControl : UserControl
    {
        //
        //ΔΗΛΩΣΗ ΜΕΤΑΒΛΗΤΩΝ
        //
        static private Mp3FileReader reader;
        static private WaveOut waveout;
        private MemoryStream ms;
        static private byte[] song;
        static private bool muted = false;
        //
        //ΚΟΝΣΤΡΑΚΤΟΡΑΣ
        //
        public SoundControl()
        {
            InitializeComponent();
        }
        //
        //ΟΤΑΝ ΦΟΡΤΩΝΕΙ ΤΟ SOUNDCONTROL
        //
        private void SoundControl_Load(object sender, EventArgs e)
        {
            LoadAndStartSong();
        }
        //
        //ΚΟΥΜΠΙ ΗΧΟΥ
        //
        private void pcb_Sound_Click(object sender, EventArgs e)
        {
            //ΑΝ ΤΟ TAG ΤΟΥ ΚΟΥΜΠΙΟΥ EINAI ON ΤΟΤΕ ΤΟ ΑΛΛΑΖΕΙ ΚΑΙ ΣΤΑΜΑΤΑΕΙ ΤΟ WAVEOUT
            if (pcb_Sound.Tag.ToString().Equals("ON"))
            {
                pcb_Sound.Image = Properties.Resources.icons8_mute_40px;
                pcb_Sound.Tag = "OFF";
                muted = true;
                waveout.Stop();
            }
            //ΑΝ ΤΟ TAG ΤΟΥ ΚΟΥΜΠΙΟΥ EINAI OFF ΤΟΤΕ ΤΟ ΑΛΛΑΖΕΙ ΚΑΙ ΑΡΧΙΖΕΙ ΤΟ WAVEOUT
            else
            {
                pcb_Sound.Image = Properties.Resources.icons8_voice_40px;
                pcb_Sound.Tag = "ON";
                muted = false;
                waveout.Play();
            }
        }
        //
        //ΜΕΘΟΔΟΣ ΠΟΥ ΔΙΑΒΑΖΕΙ ΤΟ ΤΡΑΓΟΥΔΙ ΚΑΙ ΤΟ ΚΑΤΑΧΩΡΕΙ ΣΕ STREAM ΚΑΙ ΤΟ ΞΕΚΙΝΑΕΙ
        //
        private void LoadAndStartSong()
        {
            //ΑΝ ΠΑΙΖΕΙ ΤΟ ΤΡΑΓΟΥΔΙ ΤΟΤΕ ΕΠΙΣΤΡΕΦΕΙ (ΔΕΝ ΞΑΝΑΞΕΚΙΝΑΕΙ)
            if (waveout!=null && waveout.PlaybackState.Equals(PlaybackState.Playing))
            {
                return;
            }
            song = Properties.Resources.Japan; //Get song buffer into a byte array
            ms = new MemoryStream(song); //Place byte array into a stream
            reader = new Mp3FileReader(ms); //Read stream with Mp3FileReader from NAudio library
            waveout = new WaveOut(); //Construct a waveout device
            waveout.Init(reader); //Initializes waveout device
            waveout.Volume = 0.3f;
            waveout.Play();
            waveout.PlaybackStopped += Waveout_PlaybackStopped; //Event handler for looping
        }
        //
        //ΑΝ ΕΧΕΙ ΤΕΛΕΙΩΣΕΙ ΤΟ ΤΡΑΓΟΥΔΙ ΤΟΤΕ ΜΕΣΩ ΤΟΥ EVENT HANDLER ΑΡΧΙΖΕΙ ΑΠΟ ΤΗΝ ΑΡΧΗ ΑΛΛΑΖΟΝΤΑΣ ΤΗΝ ΘΕΣΗ ΤΟΥ MEMORYSTREAM
        //
        private void Waveout_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (muted)
            { 
                return;
            }
            ms.Position = 0; //Restart memory stream
            waveout.Play();
        }
    }
}

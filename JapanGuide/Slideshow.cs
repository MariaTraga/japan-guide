using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace JapanGuide
{
    public partial class Slideshow : UserControl
    {
        //
        //ΔΗΛΩΣΗ ΜΕΤΑΒΛΗΤΩΝ
        //
        SliderPictureList sliderPictureList;
        bool forward = true;

        //
        //ΚΟΝΣΤΡΑΚΤΟΡΑΣ ΠΟΥ ΔΕΧΕΤΑΙ ΜΙΑ ΛΙΣΤΑ ΑΠΟ ΕΙΚΟΝΕΣ
        //
        public Slideshow(Image[] imageList)
        {
            InitializeComponent();
            //ΑΡΧΙΚΟΠΟΙΗΣΗ ΑΝΤΙΚΕΙΜΕΝΟΥ ΛΙΣΤΑΣ ΕΙΚΟΝΩΝ ΑΠΟ ΤΗΝ ΚΛΑΣΗ SliderPictureList
            sliderPictureList = new SliderPictureList(imageList, this); 
            this.Dock = DockStyle.Fill;
        }
        //
        // ΚΑΤΑ ΤΗ ΦΟΡΤΩΣΗ ΤΟΠΟΘΕΤΟΥΝΤΑΙ ΤΑ ΚΟΥΜΠΙΑ ΑΚΡΙΒΩΣ ΣΤΗ ΜΕΣΗ ΤΟΥ SLIDΕSHOW
        //
        private void Slideshow_Load(object sender, EventArgs e)
        {
            btn_Next.Location = new Point(this.Width - btn_Next.Width, this.Height / 2 - btn_Next.Height / 2);
            btn_Previous.Location = new Point(0, this.Height / 2 - btn_Previous.Height / 2);
        }
        //
        // ΕΜΦΑΝΙΣΗ ΠΡΩΤΗΣ ΕΙΚΟΝΑΣ / ΕΝΑΡΞΗ ΤΆΙΜΕΡ
        //
        public void StartSlider()
        {
            this.Controls.Add(sliderPictureList.CreatePictureBox(0));
            timer_SliderIntervals.Start();
        }

        //
        // ΚΛΑΣΗ Η ΟΠΟΙΑ ΔΗΜΙΟΥΡΓΕΙ ΤΑ PICTUREBOX ΠΟΥ ΕΜΦΑΝΙΖΟΝΤΑΙ ΑΠΟ ΤΗ ΛΙΣΤΑ ΕΙΚΟΝΩΝ ΠΟΥ ΕΧΟΥΜΕ ΔΩΣΕΙ
        //
        private class SliderPictureList
        {
            private Image[] images;
            private int imageIndex = 0;
            private Control owner;

            public SliderPictureList(Image[] imageList, Control newOwner) 
            {
                this.images = imageList;
                this.owner = newOwner;
            }
            //
            // ΔΗΜΙΟΥΡΓΙΑ PICTUREBOX ΚΑΙ ΑΛΛΑΓΗ ΤΟΠΟΘΕΣΙΑΣ ΤΟΥ ΜΕ ΒΑΣΗ ΕΝΑΝ ΑΚΕΡΑΙΟ position
            //
            public PictureBox CreatePictureBox(int position) // position: -1 - Left | 0 - Default | 1 - Right 
            {
                PictureBox picture = new PictureBox();
                picture.Size = owner.Size;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                switch (position)
                {
                    case -1:
                        picture.Location = new Point(-owner.Width, 0); // ΘΕΣΗ -1 
                        picture.Image = previousImage();
                        break;
                    case 1:
                        picture.Location = new Point(owner.Width, 0); // ΘΕΣΗ 1
                        picture.Image = nextImage();
                        break;
                    default:
                        picture.Image = nextImage(); // ΘΕΣΗ 0
                        break;
                }
                return picture;
            }
            // ΕΠΟΜΕΝΗ ΕΙΚΟΝΑ ΑΠΟ ΤΗ ΛΙΣΤΑ ΕΙΚΟΝΩΝ
            private Image nextImage()
            {
                try
                {
                    return images[++imageIndex];
                }
                catch (IndexOutOfRangeException)
                {
                    imageIndex = 0;
                    return images[imageIndex];
                }
            }
            // ΠΡΟΗΓΟΥΜΕΝΗ ΕΙΚΟΝΑ ΑΠΟ ΤΗ ΛΙΣΤΑ ΕΙΚΟΝΩΝ
            private Image previousImage()
            {
                try
                {
                    return images[--imageIndex];
                }
                catch (IndexOutOfRangeException)
                {
                    imageIndex = images.Length;
                    return images[--imageIndex];
                }
            }
        }

        //
        // BUTTONS NEXT AND PREVIOUS
        //

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            forward = false;
            this.Controls.Add(sliderPictureList.CreatePictureBox(-1));
            ManualSlide();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            forward = true;
            this.Controls.Add(sliderPictureList.CreatePictureBox(1));
            ManualSlide();
        }
        // ΜΕΘΟΔΟΣ ΠΟΥ ΚΑΛΕΙΤΑΙ ΓΙΑ ΝΑ ΚΙΝΗΘΕΙ ΤΟ SLIDESHOW ΟΠΩΣ ΤΟ ΘΕΛΟΥΜΕ
        private void ManualSlide()
        {
            timer_SliderIntervals.Stop();
            timer_SlidePictures.Start();
            btn_Next.Enabled = false;
            btn_Previous.Enabled = false;
        }

        //
        // TIMER TICKS
        //
        // ΜΕΤΑΚΙΝΕΙ ΤΙΣ ΕΙΚΟΝΕΣ ΠΡΟΣ ΤΑ ΔΕΞΙΑ Ή ΑΡΙΣΤΕΡΑ ΑΝΑΛΟΓΑ ΜΕ ΤΗΝ ΤΙΜΗ ΤΟΥ forward
        private void timer_SlidePictures_Tick(object sender, EventArgs e)
        {
            IEnumerable<PictureBox> pictures = this.Controls.OfType<PictureBox>();
            if (pictures.Count().Equals(1))
            {
                Refresh(pictures);
                return;
            }
            switch (forward)
            {
                case true:
                    SlideLeft(pictures);
                    break;
                case false:
                    SlideRight(pictures);
                    break;
            }
        }
        // ΑΝΑΝΕΩΣΗ ΤΗΣ ΕΙΚΟΝΑΣ ΤΟΥ SLIDESHOW ΩΣΤΕ ΝΑ "ΚΑΘΕΤΑΙ" ΑΚΡΙΒΩΣ  / ΤΟΠΟΘΕΤΗΣΗ ΣΤΟ ΣΗΜΕΙΟ 0
        private void Refresh(IEnumerable<PictureBox> pictures)
        {
            btn_Next.Enabled = true;
            btn_Previous.Enabled = true;
            pictures.First().Location = new Point(0, 0);
            timer_SlidePictures.Stop();
            timer_SliderIntervals.Start();
            return;
        }
        // TIMER ΑΝΑΜΟΝΗΣ ΕΩΣ ΤΗΝ ΕΝΑΡΞΗ ΤΗΣ ΕΠΟΜΕΝΗΣ ΚΥΛΙΣΗΣ
        private void timer_SliderIntervals_Tick(object sender, EventArgs e)
        {
            forward = true;
            btn_Next.Enabled = false;
            btn_Previous.Enabled = false;
            timer_SlidePictures.Start();
            this.Controls.Add(sliderPictureList.CreatePictureBox(1));
            timer_SliderIntervals.Stop();
        }
        // ΜΕΘΟΔΟΣ ΚΙΝΗΣΗΣ ΕΙΚΟΝΩΝ ΠΡΟΣ ΤΑ ΑΡΙΣΤΕΡΑ
        private void SlideLeft(IEnumerable<PictureBox> pictures)
        {
            foreach (PictureBox picture in pictures)
            {
                picture.Location = new Point(picture.Location.X - 7, picture.Top);
                if (picture.Location.X + picture.Width <= 0)
                {
                    picture.Dispose();
                }
            }
        }
        //ΜΕΘΟΔΟΣ ΚΙΝΗΣΗΣ ΕΙΚΟΝΩΝ ΠΡΟΣ ΤΑ ΔΕΞΙΑΣ
        private void SlideRight(IEnumerable<PictureBox> pictures)
        {
            foreach (PictureBox picture in pictures)
            {
                picture.Location = new Point(picture.Location.X + 7, picture.Top);
                if (picture.Location.X >= this.Width)
                {
                    picture.Dispose();
                }
            }
        }
    }
}

namespace JapanGuide
{
    partial class Slideshow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.timer_SlidePictures = new System.Windows.Forms.Timer(this.components);
            this.timer_SliderIntervals = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_Previous
            // 
            this.btn_Previous.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Previous.BackColor = System.Drawing.Color.Transparent;
            this.btn_Previous.FlatAppearance.BorderSize = 0;
            this.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Previous.Image = global::JapanGuide.Properties.Resources.icon_previous_45px;
            this.btn_Previous.Location = new System.Drawing.Point(3, 109);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(30, 30);
            this.btn_Previous.TabIndex = 2;
            this.btn_Previous.TabStop = false;
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Image = global::JapanGuide.Properties.Resources.icon_next_45px;
            this.btn_Next.Location = new System.Drawing.Point(439, 109);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(30, 30);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.TabStop = false;
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // timer_SlidePictures
            // 
            this.timer_SlidePictures.Interval = 1;
            this.timer_SlidePictures.Tick += new System.EventHandler(this.timer_SlidePictures_Tick);
            // 
            // timer_SliderIntervals
            // 
            this.timer_SliderIntervals.Interval = 2500;
            this.timer_SliderIntervals.Tick += new System.EventHandler(this.timer_SliderIntervals_Tick);
            // 
            // Slideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_Next);
            this.Name = "Slideshow";
            this.Size = new System.Drawing.Size(472, 242);
            this.Load += new System.EventHandler(this.Slideshow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Timer timer_SlidePictures;
        private System.Windows.Forms.Timer timer_SliderIntervals;
    }
}

namespace JapanGuide
{
    partial class SoundControl
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
            this.pcb_Sound = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Sound)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_Sound
            // 
            this.pcb_Sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_Sound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcb_Sound.Image = global::JapanGuide.Properties.Resources.icons8_voice_40px;
            this.pcb_Sound.Location = new System.Drawing.Point(0, 0);
            this.pcb_Sound.Name = "pcb_Sound";
            this.pcb_Sound.Size = new System.Drawing.Size(30, 30);
            this.pcb_Sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Sound.TabIndex = 0;
            this.pcb_Sound.TabStop = false;
            this.pcb_Sound.Tag = "ON";
            this.toolTip1.SetToolTip(this.pcb_Sound, "Mute/Unmute sound");
            this.pcb_Sound.Click += new System.EventHandler(this.pcb_Sound_Click);
            // 
            // SoundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcb_Sound);
            this.Name = "SoundControl";
            this.Size = new System.Drawing.Size(30, 30);
            this.Load += new System.EventHandler(this.SoundControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Sound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_Sound;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

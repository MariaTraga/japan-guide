namespace JapanGuide
{
    partial class Events
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            this.pnl_Side = new System.Windows.Forms.Panel();
            this.pnl_LinkLabels = new System.Windows.Forms.Panel();
            this.lbl_LinkLabels = new System.Windows.Forms.Label();
            this.llbl_Hanami = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llbl_Nagasaki = new System.Windows.Forms.LinkLabel();
            this.llbl_Bon = new System.Windows.Forms.LinkLabel();
            this.llbl_FireFestival = new System.Windows.Forms.LinkLabel();
            this.llbl_Gion = new System.Windows.Forms.LinkLabel();
            this.llbl_Takayama = new System.Windows.Forms.LinkLabel();
            this.llbl_Sanja = new System.Windows.Forms.LinkLabel();
            this.llbl_SnowFestival = new System.Windows.Forms.LinkLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Sliedshow = new System.Windows.Forms.Panel();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.rtxt_Info = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_Tools = new System.Windows.Forms.Panel();
            this.pnl_Side.SuspendLayout();
            this.pnl_LinkLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Info.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Side
            // 
            this.pnl_Side.Controls.Add(this.pnl_LinkLabels);
            this.pnl_Side.Controls.Add(this.monthCalendar1);
            this.pnl_Side.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Side.Location = new System.Drawing.Point(0, 37);
            this.pnl_Side.Name = "pnl_Side";
            this.pnl_Side.Size = new System.Drawing.Size(287, 692);
            this.pnl_Side.TabIndex = 2;
            // 
            // pnl_LinkLabels
            // 
            this.pnl_LinkLabels.Controls.Add(this.lbl_LinkLabels);
            this.pnl_LinkLabels.Controls.Add(this.llbl_Hanami);
            this.pnl_LinkLabels.Controls.Add(this.pictureBox1);
            this.pnl_LinkLabels.Controls.Add(this.llbl_Nagasaki);
            this.pnl_LinkLabels.Controls.Add(this.llbl_Bon);
            this.pnl_LinkLabels.Controls.Add(this.llbl_FireFestival);
            this.pnl_LinkLabels.Controls.Add(this.llbl_Gion);
            this.pnl_LinkLabels.Controls.Add(this.llbl_Takayama);
            this.pnl_LinkLabels.Controls.Add(this.llbl_Sanja);
            this.pnl_LinkLabels.Controls.Add(this.llbl_SnowFestival);
            this.pnl_LinkLabels.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_LinkLabels.Location = new System.Drawing.Point(0, 0);
            this.pnl_LinkLabels.Name = "pnl_LinkLabels";
            this.pnl_LinkLabels.Size = new System.Drawing.Size(287, 339);
            this.pnl_LinkLabels.TabIndex = 1;
            // 
            // lbl_LinkLabels
            // 
            this.lbl_LinkLabels.AutoSize = true;
            this.lbl_LinkLabels.Font = new System.Drawing.Font("Gabriola", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_LinkLabels.Location = new System.Drawing.Point(79, 108);
            this.lbl_LinkLabels.Name = "lbl_LinkLabels";
            this.lbl_LinkLabels.Size = new System.Drawing.Size(120, 39);
            this.lbl_LinkLabels.TabIndex = 8;
            this.lbl_LinkLabels.Text = "ΕΚΔΗΛΩΣΕΙΣ";
            // 
            // llbl_Hanami
            // 
            this.llbl_Hanami.AutoSize = true;
            this.llbl_Hanami.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.llbl_Hanami.Location = new System.Drawing.Point(12, 313);
            this.llbl_Hanami.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.llbl_Hanami.Name = "llbl_Hanami";
            this.llbl_Hanami.Size = new System.Drawing.Size(220, 18);
            this.llbl_Hanami.TabIndex = 7;
            this.llbl_Hanami.TabStop = true;
            this.llbl_Hanami.Tag = "3/14/2021";
            this.llbl_Hanami.Text = "Hanami - Άνθισμα των κερασιών";
            this.toolTip1.SetToolTip(this.llbl_Hanami, "Hanami - Άνθισμα των κερασιών");
            this.llbl_Hanami.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JapanGuide.Properties.Resources.lanterns;
            this.pictureBox1.Location = new System.Drawing.Point(3, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // llbl_Nagasaki
            // 
            this.llbl_Nagasaki.AutoSize = true;
            this.llbl_Nagasaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.llbl_Nagasaki.Location = new System.Drawing.Point(12, 290);
            this.llbl_Nagasaki.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.llbl_Nagasaki.Name = "llbl_Nagasaki";
            this.llbl_Nagasaki.Size = new System.Drawing.Size(187, 18);
            this.llbl_Nagasaki.TabIndex = 6;
            this.llbl_Nagasaki.TabStop = true;
            this.llbl_Nagasaki.Tag = "10/7/2020";
            this.llbl_Nagasaki.Text = "Nagasaki Kunchi Φεστιβάλ";
            this.toolTip1.SetToolTip(this.llbl_Nagasaki, "Nagasaki Kunchi Φεστιβάλ");
            this.llbl_Nagasaki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_LinkClicked);
            // 
            // llbl_Bon
            // 
            this.llbl_Bon.AutoSize = true;
            this.llbl_Bon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.llbl_Bon.Location = new System.Drawing.Point(12, 267);
            this.llbl_Bon.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.llbl_Bon.Name = "llbl_Bon";
            this.llbl_Bon.Size = new System.Drawing.Size(103, 18);
            this.llbl_Bon.TabIndex = 5;
            this.llbl_Bon.TabStop = true;
            this.llbl_Bon.Tag = "8/22/2021";
            this.llbl_Bon.Text = "Bon Φεστιβάλ";
            this.toolTip1.SetToolTip(this.llbl_Bon, "Bon Φεστιβάλ");
            this.llbl_Bon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_LinkClicked);
            // 
            // llbl_FireFestival
            // 
            this.llbl_FireFestival.AutoSize = true;
            this.llbl_FireFestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.llbl_FireFestival.Location = new System.Drawing.Point(12, 244);
            this.llbl_FireFestival.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.llbl_FireFestival.Name = "llbl_FireFestival";
            this.llbl_FireFestival.Size = new System.Drawing.Size(195, 18);
            this.llbl_FireFestival.TabIndex = 4;
            this.llbl_FireFestival.TabStop = true;
            this.llbl_FireFestival.Tag = "7/14/2021";
            this.llbl_FireFestival.Text = "Φεστιβάλ Φωτιάς στο Nachi";
            this.toolTip1.SetToolTip(this.llbl_FireFestival, "Φεστιβάλ Φωτιάς στο Nachi");
            this.llbl_FireFestival.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_LinkClicked);
            // 
            // llbl_Gion
            // 
            this.llbl_Gion.AutoSize = true;
            this.llbl_Gion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.llbl_Gion.Location = new System.Drawing.Point(12, 221);
            this.llbl_Gion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.llbl_Gion.Name = "llbl_Gion";
            this.llbl_Gion.Size = new System.Drawing.Size(108, 18);
            this.llbl_Gion.TabIndex = 3;
            this.llbl_Gion.TabStop = true;
            this.llbl_Gion.Tag = "7/1/2021";
            this.llbl_Gion.Text = "Gion Φεστιβάλ";
            this.toolTip1.SetToolTip(this.llbl_Gion, "Gion Φεστιβάλ");
            this.llbl_Gion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_LinkClicked);
            // 
            // llbl_Takayama
            // 
            this.llbl_Takayama.AutoSize = true;
            this.llbl_Takayama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.llbl_Takayama.Location = new System.Drawing.Point(12, 198);
            this.llbl_Takayama.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.llbl_Takayama.Name = "llbl_Takayama";
            this.llbl_Takayama.Size = new System.Drawing.Size(145, 18);
            this.llbl_Takayama.TabIndex = 2;
            this.llbl_Takayama.TabStop = true;
            this.llbl_Takayama.Tag = "10/9/2020";
            this.llbl_Takayama.Text = "Takayama Φεστιβάλ";
            this.toolTip1.SetToolTip(this.llbl_Takayama, "Takayama Φεστιβάλ");
            this.llbl_Takayama.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_LinkClicked);
            // 
            // llbl_Sanja
            // 
            this.llbl_Sanja.AutoSize = true;
            this.llbl_Sanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.llbl_Sanja.Location = new System.Drawing.Point(12, 175);
            this.llbl_Sanja.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.llbl_Sanja.Name = "llbl_Sanja";
            this.llbl_Sanja.Size = new System.Drawing.Size(113, 18);
            this.llbl_Sanja.TabIndex = 1;
            this.llbl_Sanja.TabStop = true;
            this.llbl_Sanja.Tag = "5/15/2021";
            this.llbl_Sanja.Text = "Sanja Φεστιβάλ";
            this.toolTip1.SetToolTip(this.llbl_Sanja, "Sanja Φεστιβάλ");
            this.llbl_Sanja.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_LinkClicked);
            // 
            // llbl_SnowFestival
            // 
            this.llbl_SnowFestival.AutoSize = true;
            this.llbl_SnowFestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.llbl_SnowFestival.Location = new System.Drawing.Point(12, 152);
            this.llbl_SnowFestival.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.llbl_SnowFestival.Name = "llbl_SnowFestival";
            this.llbl_SnowFestival.Size = new System.Drawing.Size(217, 18);
            this.llbl_SnowFestival.TabIndex = 0;
            this.llbl_SnowFestival.TabStop = true;
            this.llbl_SnowFestival.Tag = "2/4/2021";
            this.llbl_SnowFestival.Text = "Φεστιβάλ Χιονιού στο Sapporo";
            this.toolTip1.SetToolTip(this.llbl_SnowFestival, "Φεστιβάλ Χιονιού στο Sapporo");
            this.llbl_SnowFestival.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_LinkClicked);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.monthCalendar1.BoldedDates = new System.DateTime[] {
        new System.DateTime(2021, 2, 4, 0, 0, 0, 0),
        new System.DateTime(2021, 5, 15, 0, 0, 0, 0),
        new System.DateTime(2020, 10, 9, 0, 0, 0, 0),
        new System.DateTime(2021, 7, 1, 0, 0, 0, 0),
        new System.DateTime(2021, 7, 14, 0, 0, 0, 0),
        new System.DateTime(2021, 8, 22, 0, 0, 0, 0),
        new System.DateTime(2020, 10, 7, 0, 0, 0, 0),
        new System.DateTime(2021, 3, 14, 0, 0, 0, 0)};
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(30, 342);
            this.monthCalendar1.MaxDate = new System.DateTime(2021, 9, 30, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.Tag = "";
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.Control;
            this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.Control;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_Title.Location = new System.Drawing.Point(6, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(23, 39);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "-";
            // 
            // pnl_Sliedshow
            // 
            this.pnl_Sliedshow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Sliedshow.Location = new System.Drawing.Point(287, 37);
            this.pnl_Sliedshow.Name = "pnl_Sliedshow";
            this.pnl_Sliedshow.Size = new System.Drawing.Size(721, 285);
            this.pnl_Sliedshow.TabIndex = 3;
            // 
            // pnl_Info
            // 
            this.pnl_Info.Controls.Add(this.pnl_Bottom);
            this.pnl_Info.Controls.Add(this.lbl_Title);
            this.pnl_Info.Controls.Add(this.rtxt_Info);
            this.pnl_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Info.Location = new System.Drawing.Point(287, 322);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(721, 407);
            this.pnl_Info.TabIndex = 4;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Controls.Add(this.btn_Exit);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 357);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(721, 50);
            this.pnl_Bottom.TabIndex = 5;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = global::JapanGuide.Properties.Resources.exit_static;
            this.btn_Exit.Location = new System.Drawing.Point(622, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(99, 50);
            this.btn_Exit.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_Exit, "Exit");
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseEnter += new System.EventHandler(this.btn_Exit_MouseEnter);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            // 
            // rtxt_Info
            // 
            this.rtxt_Info.BackColor = System.Drawing.Color.LavenderBlush;
            this.rtxt_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxt_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rtxt_Info.Location = new System.Drawing.Point(3, 45);
            this.rtxt_Info.Name = "rtxt_Info";
            this.rtxt_Info.Size = new System.Drawing.Size(715, 306);
            this.rtxt_Info.TabIndex = 4;
            this.rtxt_Info.Text = "";
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(1008, 37);
            this.pnl_Tools.TabIndex = 1;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnl_Info);
            this.Controls.Add(this.pnl_Sliedshow);
            this.Controls.Add(this.pnl_Side);
            this.Controls.Add(this.pnl_Tools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Events Forms";
            this.Text = "Events";
            this.Activated += new System.EventHandler(this.Events_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Events_FormClosed);
            this.Load += new System.EventHandler(this.Events_Load);
            this.pnl_Side.ResumeLayout(false);
            this.pnl_LinkLabels.ResumeLayout(false);
            this.pnl_LinkLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Side;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel pnl_Sliedshow;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.RichTextBox rtxt_Info;
        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.Panel pnl_LinkLabels;
        private System.Windows.Forms.LinkLabel llbl_Hanami;
        private System.Windows.Forms.LinkLabel llbl_Nagasaki;
        private System.Windows.Forms.LinkLabel llbl_Bon;
        private System.Windows.Forms.LinkLabel llbl_FireFestival;
        private System.Windows.Forms.LinkLabel llbl_Gion;
        private System.Windows.Forms.LinkLabel llbl_Takayama;
        private System.Windows.Forms.LinkLabel llbl_Sanja;
        private System.Windows.Forms.LinkLabel llbl_SnowFestival;
        private System.Windows.Forms.Label lbl_LinkLabels;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_Bottom;
    }
}
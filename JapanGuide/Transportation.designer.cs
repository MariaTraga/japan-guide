namespace JapanGuide
{
    partial class Transportation
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
            this.pnl_Tools = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_Side = new System.Windows.Forms.Panel();
            this.btn_Ships = new System.Windows.Forms.Button();
            this.btn_Planes = new System.Windows.Forms.Button();
            this.btn_Train = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxt_GeneralInfo = new System.Windows.Forms.RichTextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.rtxt_Info = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_Side.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(1008, 37);
            this.pnl_Tools.TabIndex = 0;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Controls.Add(this.btn_Exit);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 679);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(1008, 50);
            this.pnl_Bottom.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = global::JapanGuide.Properties.Resources.exit_static;
            this.btn_Exit.Location = new System.Drawing.Point(909, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(99, 50);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseEnter += new System.EventHandler(this.btn_Exit_MouseEnter);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            // 
            // pnl_Side
            // 
            this.pnl_Side.Controls.Add(this.btn_Ships);
            this.pnl_Side.Controls.Add(this.btn_Planes);
            this.pnl_Side.Controls.Add(this.btn_Train);
            this.pnl_Side.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Side.Location = new System.Drawing.Point(0, 37);
            this.pnl_Side.Name = "pnl_Side";
            this.pnl_Side.Size = new System.Drawing.Size(249, 642);
            this.pnl_Side.TabIndex = 2;
            // 
            // btn_Ships
            // 
            this.btn_Ships.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ships.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ships.FlatAppearance.BorderSize = 0;
            this.btn_Ships.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ships.ForeColor = System.Drawing.Color.Black;
            this.btn_Ships.Image = global::JapanGuide.Properties.Resources.boat_static;
            this.btn_Ships.Location = new System.Drawing.Point(0, 23);
            this.btn_Ships.Name = "btn_Ships";
            this.btn_Ships.Size = new System.Drawing.Size(249, 191);
            this.btn_Ships.TabIndex = 2;
            this.btn_Ships.Tag = "tr_ships";
            this.toolTip1.SetToolTip(this.btn_Ships, "Πληροφορίες για την μεταφορά με πλοία");
            this.btn_Ships.UseVisualStyleBackColor = true;
            this.btn_Ships.Click += new System.EventHandler(this.btn_Click);
            this.btn_Ships.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_Ships.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_Planes
            // 
            this.btn_Planes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Planes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Planes.FlatAppearance.BorderSize = 0;
            this.btn_Planes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Planes.Image = global::JapanGuide.Properties.Resources.plane_static;
            this.btn_Planes.Location = new System.Drawing.Point(0, 434);
            this.btn_Planes.Name = "btn_Planes";
            this.btn_Planes.Size = new System.Drawing.Size(249, 191);
            this.btn_Planes.TabIndex = 1;
            this.btn_Planes.Tag = "tr_planes";
            this.toolTip1.SetToolTip(this.btn_Planes, "Πληροφορίες για την μεταφορά με αεροπλάνα");
            this.btn_Planes.UseVisualStyleBackColor = true;
            this.btn_Planes.Click += new System.EventHandler(this.btn_Click);
            this.btn_Planes.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_Planes.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_Train
            // 
            this.btn_Train.BackColor = System.Drawing.Color.Thistle;
            this.btn_Train.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Train.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Train.FlatAppearance.BorderSize = 0;
            this.btn_Train.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Train.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_Train.Image = global::JapanGuide.Properties.Resources.train_static;
            this.btn_Train.Location = new System.Drawing.Point(0, 220);
            this.btn_Train.Name = "btn_Train";
            this.btn_Train.Size = new System.Drawing.Size(249, 191);
            this.btn_Train.TabIndex = 0;
            this.btn_Train.Tag = "tr_trains";
            this.btn_Train.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_Train, "Πληροφορίες για την μεταφορά με τρένα");
            this.btn_Train.UseVisualStyleBackColor = false;
            this.btn_Train.Click += new System.EventHandler(this.btn_Click);
            this.btn_Train.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_Train.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtxt_GeneralInfo);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Controls.Add(this.rtxt_Info);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(249, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 642);
            this.panel1.TabIndex = 3;
            // 
            // rtxt_GeneralInfo
            // 
            this.rtxt_GeneralInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rtxt_GeneralInfo.Location = new System.Drawing.Point(15, 39);
            this.rtxt_GeneralInfo.Name = "rtxt_GeneralInfo";
            this.rtxt_GeneralInfo.Size = new System.Drawing.Size(732, 175);
            this.rtxt_GeneralInfo.TabIndex = 2;
            this.rtxt_GeneralInfo.Text = "";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_Title.Location = new System.Drawing.Point(6, 253);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 50);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "-";
            // 
            // rtxt_Info
            // 
            this.rtxt_Info.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rtxt_Info.Location = new System.Drawing.Point(15, 364);
            this.rtxt_Info.Name = "rtxt_Info";
            this.rtxt_Info.Size = new System.Drawing.Size(732, 275);
            this.rtxt_Info.TabIndex = 0;
            this.rtxt_Info.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JapanGuide.Properties.Resources.koi;
            this.pictureBox1.Location = new System.Drawing.Point(189, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Transportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Side);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Tools);
            this.Name = "Transportation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transportation";
            this.Activated += new System.EventHandler(this.Transportation_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Transportation_FormClosed);
            this.Load += new System.EventHandler(this.Transportation_Load);
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Side.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Side;
        private System.Windows.Forms.Button btn_Planes;
        private System.Windows.Forms.Button btn_Train;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox rtxt_GeneralInfo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.RichTextBox rtxt_Info;
        private System.Windows.Forms.Button btn_Ships;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Exit;
    }
}
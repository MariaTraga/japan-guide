namespace JapanGuide
{
    partial class JapanMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JapanMap));
            this.pct_map = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_Tools = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl_Links = new System.Windows.Forms.Panel();
            this.llbl_attraction1 = new System.Windows.Forms.LinkLabel();
            this.llbl_attraction3 = new System.Windows.Forms.LinkLabel();
            this.pct_AttractionPreview = new System.Windows.Forms.PictureBox();
            this.llbl_attraction2 = new System.Windows.Forms.LinkLabel();
            this.pnl_legend = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rtxt_Info = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnl_Map = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pct_map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnl_Links.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_AttractionPreview)).BeginInit();
            this.pnl_legend.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnl_Map.SuspendLayout();
            this.SuspendLayout();
            // 
            // pct_map
            // 
            this.pct_map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pct_map.Image = global::JapanGuide.Properties.Resources.map_kanto;
            this.pct_map.Location = new System.Drawing.Point(0, 0);
            this.pct_map.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.pct_map.Name = "pct_map";
            this.pct_map.Size = new System.Drawing.Size(684, 572);
            this.pct_map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_map.TabIndex = 0;
            this.pct_map.TabStop = false;
            this.toolTip1.SetToolTip(this.pct_map, "ΧΑΡΤΗΣ ΤΗΣ ΙΑΠΩΝΙΑΣ");
            this.pct_map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pct_map_MouseMove);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(98, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(127, 59);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "   KANTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JapanGuide.Properties.Resources.icons8_sakura_50px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JapanGuide.Properties.Resources.icons8_sakura_50px_flipped;
            this.pictureBox2.Location = new System.Drawing.Point(271, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(1008, 37);
            this.pnl_Tools.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Exit);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 679);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1008, 50);
            this.panel6.TabIndex = 0;
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
            this.btn_Exit.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_Exit, "ΕΞΟΔΟΣ");
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseEnter += new System.EventHandler(this.btn_Exit_MouseEnter);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(684, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 642);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnl_Links);
            this.panel5.Controls.Add(this.pnl_legend);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 585);
            this.panel5.TabIndex = 7;
            // 
            // pnl_Links
            // 
            this.pnl_Links.Controls.Add(this.llbl_attraction1);
            this.pnl_Links.Controls.Add(this.llbl_attraction3);
            this.pnl_Links.Controls.Add(this.pct_AttractionPreview);
            this.pnl_Links.Controls.Add(this.llbl_attraction2);
            this.pnl_Links.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Links.Location = new System.Drawing.Point(0, 229);
            this.pnl_Links.Name = "pnl_Links";
            this.pnl_Links.Size = new System.Drawing.Size(324, 356);
            this.pnl_Links.TabIndex = 14;
            // 
            // llbl_attraction1
            // 
            this.llbl_attraction1.AutoSize = true;
            this.llbl_attraction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_attraction1.Location = new System.Drawing.Point(6, 11);
            this.llbl_attraction1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.llbl_attraction1.Name = "llbl_attraction1";
            this.llbl_attraction1.Size = new System.Drawing.Size(65, 25);
            this.llbl_attraction1.TabIndex = 0;
            this.llbl_attraction1.TabStop = true;
            this.llbl_attraction1.Tag = "Tokyo";
            this.llbl_attraction1.Text = "Τόκιο";
            this.llbl_attraction1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_attraction_LinkClicked);
            this.llbl_attraction1.MouseEnter += new System.EventHandler(this.llbl_attraction_MouseEnter);
            // 
            // llbl_attraction3
            // 
            this.llbl_attraction3.AutoSize = true;
            this.llbl_attraction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_attraction3.Location = new System.Drawing.Point(6, 81);
            this.llbl_attraction3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.llbl_attraction3.Name = "llbl_attraction3";
            this.llbl_attraction3.Size = new System.Drawing.Size(121, 25);
            this.llbl_attraction3.TabIndex = 2;
            this.llbl_attraction3.TabStop = true;
            this.llbl_attraction3.Tag = "Kamakura";
            this.llbl_attraction3.Text = "Καμακούρα";
            this.llbl_attraction3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_attraction_LinkClicked);
            this.llbl_attraction3.MouseEnter += new System.EventHandler(this.llbl_attraction_MouseEnter);
            // 
            // pct_AttractionPreview
            // 
            this.pct_AttractionPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct_AttractionPreview.Location = new System.Drawing.Point(3, 114);
            this.pct_AttractionPreview.Name = "pct_AttractionPreview";
            this.pct_AttractionPreview.Size = new System.Drawing.Size(318, 172);
            this.pct_AttractionPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_AttractionPreview.TabIndex = 0;
            this.pct_AttractionPreview.TabStop = false;
            // 
            // llbl_attraction2
            // 
            this.llbl_attraction2.AutoSize = true;
            this.llbl_attraction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_attraction2.Location = new System.Drawing.Point(6, 46);
            this.llbl_attraction2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.llbl_attraction2.Name = "llbl_attraction2";
            this.llbl_attraction2.Size = new System.Drawing.Size(102, 25);
            this.llbl_attraction2.TabIndex = 1;
            this.llbl_attraction2.TabStop = true;
            this.llbl_attraction2.Tag = "Kawasaki";
            this.llbl_attraction2.Text = "Καβασάκι";
            this.llbl_attraction2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_attraction_LinkClicked);
            this.llbl_attraction2.MouseEnter += new System.EventHandler(this.llbl_attraction_MouseEnter);
            // 
            // pnl_legend
            // 
            this.pnl_legend.Controls.Add(this.label2);
            this.pnl_legend.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_legend.Location = new System.Drawing.Point(0, 192);
            this.pnl_legend.Name = "pnl_legend";
            this.pnl_legend.Size = new System.Drawing.Size(324, 37);
            this.pnl_legend.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "ΑΞΙΟΘΕΑΤΑ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rtxt_Info);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(324, 192);
            this.panel8.TabIndex = 12;
            // 
            // rtxt_Info
            // 
            this.rtxt_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_Info.Location = new System.Drawing.Point(0, 0);
            this.rtxt_Info.Name = "rtxt_Info";
            this.rtxt_Info.Size = new System.Drawing.Size(324, 192);
            this.rtxt_Info.TabIndex = 3;
            this.rtxt_Info.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.lbl_title);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 57);
            this.panel4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "ΧΑΡΤΗΣ ΤΗΣ ΙΑΠΩΝΙΑΣ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 642);
            this.panel2.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnl_Map);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(684, 642);
            this.panel7.TabIndex = 2;
            // 
            // pnl_Map
            // 
            this.pnl_Map.Controls.Add(this.label7);
            this.pnl_Map.Controls.Add(this.label6);
            this.pnl_Map.Controls.Add(this.label5);
            this.pnl_Map.Controls.Add(this.label4);
            this.pnl_Map.Controls.Add(this.label3);
            this.pnl_Map.Controls.Add(this.label1);
            this.pnl_Map.Controls.Add(this.pct_map);
            this.pnl_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Map.Location = new System.Drawing.Point(0, 0);
            this.pnl_Map.Name = "pnl_Map";
            this.pnl_Map.Size = new System.Drawing.Size(684, 572);
            this.pnl_Map.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 45);
            this.label7.TabIndex = 11;
            this.label7.Text = "ΠΕΡΙΟΧΕΣ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.GhostWhite;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kyushu";
            this.toolTip1.SetToolTip(this.label6, "ΠΕΡΙΟΧΗ ΚΙΟΥΣΟΥ");
            this.label6.Click += new System.EventHandler(this.lbl_Region_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kansai";
            this.toolTip1.SetToolTip(this.label5, "ΠΕΡΙΟΧΗ ΚΑΝΣΑΙ");
            this.label5.Click += new System.EventHandler(this.lbl_Region_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kanto";
            this.toolTip1.SetToolTip(this.label4, "ΠΕΡΙΟΧΗ ΚΑΝΤΟ");
            this.label4.Click += new System.EventHandler(this.lbl_Region_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.GhostWhite;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hokkaido";
            this.toolTip1.SetToolTip(this.label3, "ΠΕΡΙΟΧΗ ΧΟΚΑΙΝΤΟ");
            this.label3.Click += new System.EventHandler(this.lbl_Region_Click);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 572);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(684, 70);
            this.panel9.TabIndex = 0;
            // 
            // JapanMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnl_Tools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JapanMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Χάρτης Ιαπωνίας";
            this.Activated += new System.EventHandler(this.JapanMap_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JapanMap_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnl_Links.ResumeLayout(false);
            this.pnl_Links.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_AttractionPreview)).EndInit();
            this.pnl_legend.ResumeLayout(false);
            this.pnl_legend.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnl_Map.ResumeLayout(false);
            this.pnl_Map.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_map;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnl_Links;
        private System.Windows.Forms.PictureBox pct_AttractionPreview;
        private System.Windows.Forms.Panel pnl_legend;
        private System.Windows.Forms.LinkLabel llbl_attraction1;
        private System.Windows.Forms.LinkLabel llbl_attraction3;
        private System.Windows.Forms.LinkLabel llbl_attraction2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxt_Info;
        private System.Windows.Forms.Panel pnl_Map;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
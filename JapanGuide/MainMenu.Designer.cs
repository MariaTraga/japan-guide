namespace JapanGuide
{
    partial class MainMenu
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
            this.pnl_ContainerPanel = new System.Windows.Forms.Panel();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.pnl_Side_L = new System.Windows.Forms.Panel();
            this.pnl_NavMenu = new System.Windows.Forms.Panel();
            this.btn_Transportation = new System.Windows.Forms.Button();
            this.btn_Food = new System.Windows.Forms.Button();
            this.btn_Events = new System.Windows.Forms.Button();
            this.btn_Sightseeing = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pct_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_Tools = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_ContainerPanel.SuspendLayout();
            this.pnl_Container.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Side_L.SuspendLayout();
            this.pnl_NavMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_ContainerPanel
            // 
            this.pnl_ContainerPanel.Controls.Add(this.pnl_Container);
            this.pnl_ContainerPanel.Controls.Add(this.pnl_Side_L);
            this.pnl_ContainerPanel.Controls.Add(this.pnl_Tools);
            this.pnl_ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.pnl_ContainerPanel.Name = "pnl_ContainerPanel";
            this.pnl_ContainerPanel.Size = new System.Drawing.Size(1008, 729);
            this.pnl_ContainerPanel.TabIndex = 3;
            // 
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.pnl_Top);
            this.pnl_Container.Controls.Add(this.pnl_Bottom);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(200, 37);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(808, 692);
            this.pnl_Container.TabIndex = 4;
            // 
            // pnl_Top
            // 
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(808, 352);
            this.pnl_Top.TabIndex = 4;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Controls.Add(this.panel2);
            this.pnl_Bottom.Controls.Add(this.lbl_title);
            this.pnl_Bottom.Controls.Add(this.txt_info);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 352);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(808, 340);
            this.pnl_Bottom.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 50);
            this.panel2.TabIndex = 3;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = global::JapanGuide.Properties.Resources.exit_static;
            this.btn_Exit.Location = new System.Drawing.Point(709, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(99, 50);
            this.btn_Exit.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_Exit, "ΕΞΟΔΟΣ");
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseEnter += new System.EventHandler(this.btn_Exit_MouseEnter);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(6, 3);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 45);
            this.lbl_title.TabIndex = 1;
            // 
            // txt_info
            // 
            this.txt_info.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_info.Location = new System.Drawing.Point(6, 51);
            this.txt_info.Multiline = true;
            this.txt_info.Name = "txt_info";
            this.txt_info.ReadOnly = true;
            this.txt_info.Size = new System.Drawing.Size(790, 102);
            this.txt_info.TabIndex = 0;
            this.txt_info.TabStop = false;
            // 
            // pnl_Side_L
            // 
            this.pnl_Side_L.Controls.Add(this.pnl_NavMenu);
            this.pnl_Side_L.Controls.Add(this.panel1);
            this.pnl_Side_L.Controls.Add(this.pct_Logo);
            this.pnl_Side_L.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Side_L.Location = new System.Drawing.Point(0, 37);
            this.pnl_Side_L.Name = "pnl_Side_L";
            this.pnl_Side_L.Size = new System.Drawing.Size(200, 692);
            this.pnl_Side_L.TabIndex = 3;
            // 
            // pnl_NavMenu
            // 
            this.pnl_NavMenu.Controls.Add(this.btn_Transportation);
            this.pnl_NavMenu.Controls.Add(this.btn_Food);
            this.pnl_NavMenu.Controls.Add(this.btn_Events);
            this.pnl_NavMenu.Controls.Add(this.btn_Sightseeing);
            this.pnl_NavMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_NavMenu.Location = new System.Drawing.Point(0, 170);
            this.pnl_NavMenu.Name = "pnl_NavMenu";
            this.pnl_NavMenu.Size = new System.Drawing.Size(200, 522);
            this.pnl_NavMenu.TabIndex = 11;
            // 
            // btn_Transportation
            // 
            this.btn_Transportation.BackgroundImage = global::JapanGuide.Properties.Resources.transport;
            this.btn_Transportation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Transportation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Transportation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Transportation.FlatAppearance.BorderSize = 0;
            this.btn_Transportation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transportation.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transportation.Location = new System.Drawing.Point(0, 375);
            this.btn_Transportation.Name = "btn_Transportation";
            this.btn_Transportation.Size = new System.Drawing.Size(200, 125);
            this.btn_Transportation.TabIndex = 3;
            this.btn_Transportation.Text = "ΜΕΤΑΚΙΝΗΣΗ";
            this.btn_Transportation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Transportation.UseVisualStyleBackColor = true;
            this.btn_Transportation.Click += new System.EventHandler(this.btn_Click);
            this.btn_Transportation.Enter += new System.EventHandler(this.btn_Focused);
            this.btn_Transportation.MouseHover += new System.EventHandler(this.btn_MouseEnter);
            // 
            // btn_Food
            // 
            this.btn_Food.BackgroundImage = global::JapanGuide.Properties.Resources.food;
            this.btn_Food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Food.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Food.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Food.FlatAppearance.BorderSize = 0;
            this.btn_Food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Food.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Food.Location = new System.Drawing.Point(0, 250);
            this.btn_Food.Name = "btn_Food";
            this.btn_Food.Size = new System.Drawing.Size(200, 125);
            this.btn_Food.TabIndex = 2;
            this.btn_Food.Tag = "2";
            this.btn_Food.Text = "ΦΑΓΗΤΟ";
            this.btn_Food.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Food.UseVisualStyleBackColor = true;
            this.btn_Food.Click += new System.EventHandler(this.btn_Click);
            this.btn_Food.Enter += new System.EventHandler(this.btn_Focused);
            this.btn_Food.MouseHover += new System.EventHandler(this.btn_MouseEnter);
            // 
            // btn_Events
            // 
            this.btn_Events.BackgroundImage = global::JapanGuide.Properties.Resources.events;
            this.btn_Events.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Events.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Events.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Events.FlatAppearance.BorderSize = 0;
            this.btn_Events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Events.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Events.Location = new System.Drawing.Point(0, 125);
            this.btn_Events.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_Events.Name = "btn_Events";
            this.btn_Events.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_Events.Size = new System.Drawing.Size(200, 125);
            this.btn_Events.TabIndex = 1;
            this.btn_Events.Tag = "1";
            this.btn_Events.Text = "ΕΚΔΗΛΩΣΕΙΣ";
            this.btn_Events.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Events.UseVisualStyleBackColor = true;
            this.btn_Events.Click += new System.EventHandler(this.btn_Click);
            this.btn_Events.Enter += new System.EventHandler(this.btn_Focused);
            this.btn_Events.MouseHover += new System.EventHandler(this.btn_MouseEnter);
            // 
            // btn_Sightseeing
            // 
            this.btn_Sightseeing.BackgroundImage = global::JapanGuide.Properties.Resources.sightseeing;
            this.btn_Sightseeing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sightseeing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sightseeing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sightseeing.FlatAppearance.BorderSize = 0;
            this.btn_Sightseeing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sightseeing.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sightseeing.Location = new System.Drawing.Point(0, 0);
            this.btn_Sightseeing.Name = "btn_Sightseeing";
            this.btn_Sightseeing.Size = new System.Drawing.Size(200, 125);
            this.btn_Sightseeing.TabIndex = 0;
            this.btn_Sightseeing.Tag = "0";
            this.btn_Sightseeing.Text = "ΑΞΙΟΘΕΑΤΑ";
            this.btn_Sightseeing.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sightseeing.UseVisualStyleBackColor = true;
            this.btn_Sightseeing.Click += new System.EventHandler(this.btn_Click);
            this.btn_Sightseeing.Enter += new System.EventHandler(this.btn_Focused);
            this.btn_Sightseeing.MouseHover += new System.EventHandler(this.btn_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 10;
            // 
            // pct_Logo
            // 
            this.pct_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(137)))), ((int)(((byte)(168)))));
            this.pct_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pct_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pct_Logo.Image = global::JapanGuide.Properties.Resources.logo;
            this.pct_Logo.Location = new System.Drawing.Point(0, 0);
            this.pct_Logo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pct_Logo.Name = "pct_Logo";
            this.pct_Logo.Padding = new System.Windows.Forms.Padding(10);
            this.pct_Logo.Size = new System.Drawing.Size(200, 140);
            this.pct_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Logo.TabIndex = 5;
            this.pct_Logo.TabStop = false;
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(1008, 37);
            this.pnl_Tools.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnl_ContainerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Activated += new System.EventHandler(this.MainMenu_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.pnl_ContainerPanel.ResumeLayout(false);
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Bottom.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnl_Side_L.ResumeLayout(false);
            this.pnl_NavMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_ContainerPanel;
        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Side_L;
        private System.Windows.Forms.Button btn_Food;
        private System.Windows.Forms.Button btn_Transportation;
        private System.Windows.Forms.Button btn_Sightseeing;
        private System.Windows.Forms.Button btn_Events;
        private System.Windows.Forms.PictureBox pct_Logo;
        private System.Windows.Forms.Panel pnl_NavMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_info;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Exit;
    }
}


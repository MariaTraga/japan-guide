namespace JapanGuide
{
    partial class CustomMenuStrip
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.αρχικήΣελίδαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.αποσύνδεσηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_SoundANDInfo = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnl_SoundANDInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.16666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_SoundANDInfo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 37);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.αρχικήΣελίδαToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.printToolStripMenuItem,
            this.αποσύνδεσηToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // αρχικήΣελίδαToolStripMenuItem
            // 
            this.αρχικήΣελίδαToolStripMenuItem.Name = "αρχικήΣελίδαToolStripMenuItem";
            this.αρχικήΣελίδαToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.αρχικήΣελίδαToolStripMenuItem.Text = "Αρχική Σελίδα";
            this.αρχικήΣελίδαToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentHistoryToolStripMenuItem,
            this.clearHistoryToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.historyToolStripMenuItem.Text = "Ιστορικό";
            // 
            // recentHistoryToolStripMenuItem
            // 
            this.recentHistoryToolStripMenuItem.Name = "recentHistoryToolStripMenuItem";
            this.recentHistoryToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.recentHistoryToolStripMenuItem.Text = "Πρόσφατο Ιστορικό";
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.clearHistoryToolStripMenuItem.Text = "Καθαρισμός Ιστορικού";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(226, 29);
            this.printToolStripMenuItem.Text = "Εξαγωγή Πληροφοριών";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // αποσύνδεσηToolStripMenuItem
            // 
            this.αποσύνδεσηToolStripMenuItem.Name = "αποσύνδεσηToolStripMenuItem";
            this.αποσύνδεσηToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.αποσύνδεσηToolStripMenuItem.Text = "Αποσύνδεση";
            this.αποσύνδεσηToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pnl_SoundANDInfo
            // 
            this.pnl_SoundANDInfo.Controls.Add(this.label1);
            this.pnl_SoundANDInfo.Controls.Add(this.btn_about);
            this.pnl_SoundANDInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SoundANDInfo.Location = new System.Drawing.Point(801, 3);
            this.pnl_SoundANDInfo.Name = "pnl_SoundANDInfo";
            this.pnl_SoundANDInfo.Size = new System.Drawing.Size(204, 31);
            this.pnl_SoundANDInfo.TabIndex = 1;
            // 
            // btn_about
            // 
            this.btn_about.BackgroundImage = global::JapanGuide.Properties.Resources.icons8_info_80px;
            this.btn_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Location = new System.Drawing.Point(123, 0);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(31, 31);
            this.btn_about.TabIndex = 2;
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // CustomMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomMenuStrip";
            this.Size = new System.Drawing.Size(1008, 37);
            this.Load += new System.EventHandler(this.MenuStrip_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_SoundANDInfo.ResumeLayout(false);
            this.pnl_SoundANDInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem αρχικήΣελίδαToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_SoundANDInfo;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.ToolStripMenuItem αποσύνδεσηToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

namespace JapanGuide
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.grb_Logininfo = new System.Windows.Forms.GroupBox();
            this.pcb_Username = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.btn_Signup = new System.Windows.Forms.Button();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.pcb_Password = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pct_Logo = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.grb_Logininfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.btn_about);
            this.panel1.Controls.Add(this.grb_Logininfo);
            this.panel1.Controls.Add(this.pct_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 532);
            this.panel1.TabIndex = 1;
            // 
            // btn_about
            // 
            this.btn_about.BackgroundImage = global::JapanGuide.Properties.Resources.icons8_info_80px;
            this.btn_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Location = new System.Drawing.Point(376, 12);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(31, 31);
            this.btn_about.TabIndex = 11;
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // grb_Logininfo
            // 
            this.grb_Logininfo.Controls.Add(this.pcb_Username);
            this.grb_Logininfo.Controls.Add(this.btn_Exit);
            this.grb_Logininfo.Controls.Add(this.txb_Username);
            this.grb_Logininfo.Controls.Add(this.btn_Signup);
            this.grb_Logininfo.Controls.Add(this.txb_Password);
            this.grb_Logininfo.Controls.Add(this.pcb_Password);
            this.grb_Logininfo.Controls.Add(this.btn_Login);
            this.grb_Logininfo.Location = new System.Drawing.Point(54, 237);
            this.grb_Logininfo.Name = "grb_Logininfo";
            this.grb_Logininfo.Size = new System.Drawing.Size(354, 283);
            this.grb_Logininfo.TabIndex = 10;
            this.grb_Logininfo.TabStop = false;
            // 
            // pcb_Username
            // 
            this.pcb_Username.Image = global::JapanGuide.Properties.Resources.icons8_user_40px;
            this.pcb_Username.Location = new System.Drawing.Point(31, 34);
            this.pcb_Username.Name = "pcb_Username";
            this.pcb_Username.Size = new System.Drawing.Size(40, 40);
            this.pcb_Username.TabIndex = 6;
            this.pcb_Username.TabStop = false;
            this.toolTip1.SetToolTip(this.pcb_Username, "Όνομα Χρήστη");
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_Exit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.Location = new System.Drawing.Point(182, 216);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(150, 45);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "ΕΞΟΔΟΣ";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Exit, "Έξοδος από την εφαρμογή");
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txb_Username
            // 
            this.txb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txb_Username.ForeColor = System.Drawing.Color.Silver;
            this.txb_Username.Location = new System.Drawing.Point(77, 42);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.Size = new System.Drawing.Size(255, 26);
            this.txb_Username.TabIndex = 3;
            this.txb_Username.Text = "Guest";
            this.txb_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Username.Enter += new System.EventHandler(this.txb_Username_Enter);
            this.txb_Username.Leave += new System.EventHandler(this.txb_Username_Leave);
            // 
            // btn_Signup
            // 
            this.btn_Signup.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Signup.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signup.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_Signup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Signup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Signup.Location = new System.Drawing.Point(20, 216);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(150, 45);
            this.btn_Signup.TabIndex = 8;
            this.btn_Signup.Text = "ΕΓΓΡΑΦΗ";
            this.btn_Signup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Signup, "Εγγραφή νέου χρήστη");
            this.btn_Signup.UseVisualStyleBackColor = false;
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txb_Password.ForeColor = System.Drawing.Color.Silver;
            this.txb_Password.Location = new System.Drawing.Point(77, 96);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(255, 26);
            this.txb_Password.TabIndex = 4;
            this.txb_Password.Text = "1234";
            this.txb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Password.Enter += new System.EventHandler(this.txb_Password_Enter);
            this.txb_Password.Leave += new System.EventHandler(this.txb_Password_Leave);
            // 
            // pcb_Password
            // 
            this.pcb_Password.Image = global::JapanGuide.Properties.Resources.icons8_key_40px;
            this.pcb_Password.Location = new System.Drawing.Point(31, 89);
            this.pcb_Password.Name = "pcb_Password";
            this.pcb_Password.Size = new System.Drawing.Size(40, 40);
            this.pcb_Password.TabIndex = 7;
            this.pcb_Password.TabStop = false;
            this.toolTip1.SetToolTip(this.pcb_Password, "Κωδικός Χρήστη");
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_Login.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.Location = new System.Drawing.Point(20, 161);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(312, 49);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "ΕΙΣΟΔΟΣ";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Login, "Είσοδος στο πρόγραμμα");
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pct_Logo
            // 
            this.pct_Logo.Image = global::JapanGuide.Properties.Resources.logo5;
            this.pct_Logo.Location = new System.Drawing.Point(91, 26);
            this.pct_Logo.Name = "pct_Logo";
            this.pct_Logo.Size = new System.Drawing.Size(277, 205);
            this.pct_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Logo.TabIndex = 0;
            this.pct_Logo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 532);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Login Form";
            this.Text = "Φόρμα εισόδου/εγγραφής";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.grb_Logininfo.ResumeLayout(false);
            this.grb_Logininfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Signup;
        private System.Windows.Forms.PictureBox pcb_Password;
        private System.Windows.Forms.PictureBox pcb_Username;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.GroupBox grb_Logininfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_about;
    }
}


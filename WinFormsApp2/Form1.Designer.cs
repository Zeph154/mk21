namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            pictureBox5Instagram = new PictureBox();
            pictureBox6Facebook = new PictureBox();
            pictureBox7Tiktok = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5Instagram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6Facebook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7Tiktok).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 161);
            label1.Name = "label1";
            label1.Size = new Size(0, 41);
            label1.TabIndex = 7;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(122, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-113, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(539, 260);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Info;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(75, 188);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(185, 19);
            txtUsername.TabIndex = 10;
            txtUsername.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(75, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 19);
            txtPassword.TabIndex = 11;
            txtPassword.Text = "Password";
            txtPassword.MouseEnter += txtPassword_MouseEnter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 175);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(24, 248);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(75, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 4);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(75, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 4);
            panel2.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(75, 313);
            button1.Name = "button1";
            button1.Size = new Size(185, 29);
            button1.TabIndex = 16;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(75, 348);
            button2.Name = "button2";
            button2.Size = new Size(185, 29);
            button2.TabIndex = 17;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox5Instagram
            // 
            pictureBox5Instagram.Image = Properties.Resources.download;
            pictureBox5Instagram.Location = new Point(75, 392);
            pictureBox5Instagram.Name = "pictureBox5Instagram";
            pictureBox5Instagram.Size = new Size(38, 38);
            pictureBox5Instagram.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5Instagram.TabIndex = 18;
            pictureBox5Instagram.TabStop = false;
            // 
            // pictureBox6Facebook
            // 
            pictureBox6Facebook.Image = Properties.Resources.Facebook_Logosu_;
            pictureBox6Facebook.Location = new Point(151, 392);
            pictureBox6Facebook.Name = "pictureBox6Facebook";
            pictureBox6Facebook.Size = new Size(38, 38);
            pictureBox6Facebook.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6Facebook.TabIndex = 19;
            pictureBox6Facebook.TabStop = false;
            // 
            // pictureBox7Tiktok
            // 
            pictureBox7Tiktok.Image = Properties.Resources.TikTok_overtakes_Facebook_downloads__Facebook_fires_back_with_Lasso___Schaefer_Marketing_Solutions__We_Help_Businesses__grow_;
            pictureBox7Tiktok.Location = new Point(222, 392);
            pictureBox7Tiktok.Name = "pictureBox7Tiktok";
            pictureBox7Tiktok.Size = new Size(38, 38);
            pictureBox7Tiktok.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7Tiktok.TabIndex = 20;
            pictureBox7Tiktok.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(303, 12);
            button3.Name = "button3";
            button3.Size = new Size(32, 29);
            button3.TabIndex = 21;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            BackColor = Color.Navy;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(347, 455);
            Controls.Add(button3);
            Controls.Add(pictureBox7Tiktok);
            Controls.Add(pictureBox6Facebook);
            Controls.Add(pictureBox5Instagram);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animal Shelter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5Instagram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6Facebook).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7Tiktok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox5Instagram;
        private PictureBox pictureBox6Facebook;
        private PictureBox pictureBox7Tiktok;
        private Button button3;
    }
}

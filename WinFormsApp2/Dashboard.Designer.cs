namespace WinFormsApp2
{
    partial class Dashboard
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
            menuStrip1 = new MenuStrip();
            bookToolStripMenuItem = new ToolStripMenuItem();
            addHewanToolStripMenuItem = new ToolStripMenuItem();
            viewHewanToolStripMenuItem = new ToolStripMenuItem();
            guestToolStripMenuItem = new ToolStripMenuItem();
            namaPengunjungToolStripMenuItem = new ToolStripMenuItem();
            guestListToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { bookToolStripMenuItem, guestToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(880, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // bookToolStripMenuItem
            // 
            bookToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addHewanToolStripMenuItem, viewHewanToolStripMenuItem });
            bookToolStripMenuItem.Image = Properties.Resources.icons8_add_book_481;
            bookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            bookToolStripMenuItem.Size = new Size(117, 54);
            bookToolStripMenuItem.Text = "Hewan";
            // 
            // addHewanToolStripMenuItem
            // 
            addHewanToolStripMenuItem.Image = Properties.Resources.icons8_add_book_48;
            addHewanToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addHewanToolStripMenuItem.Name = "addHewanToolStripMenuItem";
            addHewanToolStripMenuItem.Size = new Size(254, 56);
            addHewanToolStripMenuItem.Text = "Add Nama Hewan";
            addHewanToolStripMenuItem.Click += addHewanToolStripMenuItem_Click;
            // 
            // viewHewanToolStripMenuItem
            // 
            viewHewanToolStripMenuItem.Image = Properties.Resources.icons8_view_501;
            viewHewanToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewHewanToolStripMenuItem.Name = "viewHewanToolStripMenuItem";
            viewHewanToolStripMenuItem.Size = new Size(254, 56);
            viewHewanToolStripMenuItem.Text = "View Hewan ";
            viewHewanToolStripMenuItem.Click += viewHewanToolStripMenuItem_Click;
            // 
            // guestToolStripMenuItem
            // 
            guestToolStripMenuItem.BackColor = Color.OldLace;
            guestToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { namaPengunjungToolStripMenuItem, guestListToolStripMenuItem });
            guestToolStripMenuItem.Image = Properties.Resources.icons8_student_male_50;
            guestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            guestToolStripMenuItem.Name = "guestToolStripMenuItem";
            guestToolStripMenuItem.Size = new Size(110, 54);
            guestToolStripMenuItem.Text = "Guest";
            // 
            // namaPengunjungToolStripMenuItem
            // 
            namaPengunjungToolStripMenuItem.Image = Properties.Resources.icons8_add_user_male_50;
            namaPengunjungToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            namaPengunjungToolStripMenuItem.Name = "namaPengunjungToolStripMenuItem";
            namaPengunjungToolStripMenuItem.Size = new Size(254, 56);
            namaPengunjungToolStripMenuItem.Text = "Add Guest";
            namaPengunjungToolStripMenuItem.Click += namaPengunjungToolStripMenuItem_Click;
            // 
            // guestListToolStripMenuItem
            // 
            guestListToolStripMenuItem.Image = Properties.Resources.icons8_view_50;
            guestListToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            guestListToolStripMenuItem.Name = "guestListToolStripMenuItem";
            guestListToolStripMenuItem.Size = new Size(254, 56);
            guestListToolStripMenuItem.Text = "Guest List";
            guestListToolStripMenuItem.Click += guestListToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.icons8_exit_sign_50;
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(97, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Dogs_and_cats_seamless_stock_vector__Illustration_of_element___43504397;
            ClientSize = new Size(880, 462);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = " ";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem bookToolStripMenuItem;
        private ToolStripMenuItem addHewanToolStripMenuItem;
        private ToolStripMenuItem viewHewanToolStripMenuItem;
        private ToolStripMenuItem guestToolStripMenuItem;
        private ToolStripMenuItem namaPengunjungToolStripMenuItem;
        private ToolStripMenuItem guestListToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
namespace WinFormsApp2
{
    partial class AddHewan
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxNama = new TextBox();
            textBoxJenisHewan = new TextBox();
            textBoxJenisKelamin = new TextBox();
            textBoxPakan = new TextBox();
            textBoxBerkembangbiak = new TextBox();
            textBoxTempat = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download__3_;
            pictureBox1.Location = new Point(0, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 75);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(375, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 22);
            label1.TabIndex = 4;
            label1.Text = "Add Hewan ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download__2_;
            pictureBox2.Location = new Point(250, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(250, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 343);
            panel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(267, 288);
            label6.Name = "label6";
            label6.Size = new Size(172, 21);
            label6.TabIndex = 6;
            label6.Text = "Tipe Berkembangbiak :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(267, 329);
            label7.Name = "label7";
            label7.Size = new Size(159, 21);
            label7.TabIndex = 7;
            label7.Text = "Tipe Tempat Tinggal :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(267, 195);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 8;
            label2.Text = "Jenis Kelamin :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(267, 148);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 9;
            label3.Text = "Jenis Hewan :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(267, 103);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 10;
            label4.Text = "Nama Hewan :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(267, 240);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 11;
            label5.Text = "Jenis Pakan :";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(451, 103);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(219, 27);
            textBoxNama.TabIndex = 12;
            // 
            // textBoxJenisHewan
            // 
            textBoxJenisHewan.Location = new Point(451, 145);
            textBoxJenisHewan.Name = "textBoxJenisHewan";
            textBoxJenisHewan.Size = new Size(219, 27);
            textBoxJenisHewan.TabIndex = 13;
            // 
            // textBoxJenisKelamin
            // 
            textBoxJenisKelamin.Location = new Point(451, 192);
            textBoxJenisKelamin.Name = "textBoxJenisKelamin";
            textBoxJenisKelamin.Size = new Size(219, 27);
            textBoxJenisKelamin.TabIndex = 14;
            // 
            // textBoxPakan
            // 
            textBoxPakan.Location = new Point(451, 240);
            textBoxPakan.Name = "textBoxPakan";
            textBoxPakan.Size = new Size(219, 27);
            textBoxPakan.TabIndex = 15;
            // 
            // textBoxBerkembangbiak
            // 
            textBoxBerkembangbiak.Location = new Point(451, 288);
            textBoxBerkembangbiak.Name = "textBoxBerkembangbiak";
            textBoxBerkembangbiak.Size = new Size(219, 27);
            textBoxBerkembangbiak.TabIndex = 16;
            // 
            // textBoxTempat
            // 
            textBoxTempat.Location = new Point(451, 329);
            textBoxTempat.Name = "textBoxTempat";
            textBoxTempat.Size = new Size(219, 27);
            textBoxTempat.TabIndex = 17;
            // 
            // buttonSave
            // 
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(346, 379);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 18;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(482, 379);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 19;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddHewan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 420);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxTempat);
            Controls.Add(textBoxBerkembangbiak);
            Controls.Add(textBoxPakan);
            Controls.Add(textBoxJenisKelamin);
            Controls.Add(textBoxJenisHewan);
            Controls.Add(textBoxNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AddHewan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddHewan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxNama;
        private TextBox textBoxJenisHewan;
        private TextBox textBoxJenisKelamin;
        private TextBox textBoxPakan;
        private TextBox textBoxBerkembangbiak;
        private TextBox textBoxTempat;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
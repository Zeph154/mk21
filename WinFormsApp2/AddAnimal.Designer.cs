namespace WinFormsApp2
{
    partial class AddAnimal
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
            buttonCancel = new Button();
            buttonSave = new Button();
            textBoxPengambilan = new TextBox();
            textBoxAdopted = new TextBox();
            textBoxNomorHp = new TextBox();
            textBoxAlamat = new TextBox();
            textBoxKelamin = new TextBox();
            textBoxNamaQuest = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(563, 379);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 35;
            buttonCancel.Text = "Exit";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(463, 379);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 34;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxPengambilan
            // 
            textBoxPengambilan.Location = new Point(451, 329);
            textBoxPengambilan.Name = "textBoxPengambilan";
            textBoxPengambilan.Size = new Size(219, 27);
            textBoxPengambilan.TabIndex = 33;
            // 
            // textBoxAdopted
            // 
            textBoxAdopted.Location = new Point(451, 288);
            textBoxAdopted.Name = "textBoxAdopted";
            textBoxAdopted.Size = new Size(219, 27);
            textBoxAdopted.TabIndex = 32;
            // 
            // textBoxNomorHp
            // 
            textBoxNomorHp.Location = new Point(451, 240);
            textBoxNomorHp.Name = "textBoxNomorHp";
            textBoxNomorHp.Size = new Size(219, 27);
            textBoxNomorHp.TabIndex = 31;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Location = new Point(451, 192);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(219, 27);
            textBoxAlamat.TabIndex = 30;
            // 
            // textBoxKelamin
            // 
            textBoxKelamin.Location = new Point(451, 145);
            textBoxKelamin.Name = "textBoxKelamin";
            textBoxKelamin.Size = new Size(219, 27);
            textBoxKelamin.TabIndex = 29;
            // 
            // textBoxNamaQuest
            // 
            textBoxNamaQuest.Location = new Point(451, 103);
            textBoxNamaQuest.Name = "textBoxNamaQuest";
            textBoxNamaQuest.Size = new Size(219, 27);
            textBoxNamaQuest.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(267, 240);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 27;
            label5.Text = "Nomor Hp :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(267, 103);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 26;
            label4.Text = "Nama Guest :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(267, 148);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 25;
            label3.Text = "Jenis Kelamin :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(267, 195);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 24;
            label2.Text = "Alamat :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(267, 329);
            label7.Name = "label7";
            label7.Size = new Size(133, 21);
            label7.TabIndex = 23;
            label7.Text = "Tgl Pengambilan :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(267, 288);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 22;
            label6.Text = "Adopted :";
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
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 27);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 4;
            label1.Text = "Add Guest";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_student_male_100;
            pictureBox2.Location = new Point(290, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 75);
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.addstudent1;
            pictureBox1.Location = new Point(0, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(363, 379);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 36;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 420);
            Controls.Add(button1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPengambilan);
            Controls.Add(textBoxAdopted);
            Controls.Add(textBoxNomorHp);
            Controls.Add(textBoxAlamat);
            Controls.Add(textBoxKelamin);
            Controls.Add(textBoxNamaQuest);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AddAnimal";
            Text = "AddAnimal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonSave;
        private TextBox textBoxPengambilan;
        private TextBox textBoxAdopted;
        private TextBox textBoxNomorHp;
        private TextBox textBoxAlamat;
        private TextBox textBoxKelamin;
        private TextBox textBoxNamaQuest;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
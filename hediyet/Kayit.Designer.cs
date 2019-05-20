namespace hediyet
{
    partial class Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name_textBox1 = new System.Windows.Forms.TextBox();
            this.age_textBox1 = new System.Windows.Forms.TextBox();
            this.weight_textBox1 = new System.Windows.Forms.TextBox();
            this.size_textBox1 = new System.Windows.Forms.TextBox();
            this.kAdi_textBox1 = new System.Windows.Forms.TextBox();
            this.sifre_textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.kyt_button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.soyad_textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBoxK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "YAŞ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "KİLO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "BOY (cm):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "DİYETİSYEN ->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "KULLANICI ADI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "ŞİFRE:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // name_textBox1
            // 
            this.name_textBox1.Location = new System.Drawing.Point(133, 58);
            this.name_textBox1.Name = "name_textBox1";
            this.name_textBox1.Size = new System.Drawing.Size(139, 20);
            this.name_textBox1.TabIndex = 8;
            this.name_textBox1.TextChanged += new System.EventHandler(this.name_textBox1_TextChanged);
            // 
            // age_textBox1
            // 
            this.age_textBox1.Location = new System.Drawing.Point(133, 110);
            this.age_textBox1.Name = "age_textBox1";
            this.age_textBox1.Size = new System.Drawing.Size(139, 20);
            this.age_textBox1.TabIndex = 9;
            this.age_textBox1.TextChanged += new System.EventHandler(this.age_textBox1_TextChanged);
            // 
            // weight_textBox1
            // 
            this.weight_textBox1.Location = new System.Drawing.Point(133, 136);
            this.weight_textBox1.Name = "weight_textBox1";
            this.weight_textBox1.Size = new System.Drawing.Size(139, 20);
            this.weight_textBox1.TabIndex = 10;
            this.weight_textBox1.TextChanged += new System.EventHandler(this.weight_textBox1_TextChanged);
            // 
            // size_textBox1
            // 
            this.size_textBox1.Location = new System.Drawing.Point(133, 175);
            this.size_textBox1.Name = "size_textBox1";
            this.size_textBox1.Size = new System.Drawing.Size(139, 20);
            this.size_textBox1.TabIndex = 11;
            this.size_textBox1.TextChanged += new System.EventHandler(this.size_textBox1_TextChanged);
            // 
            // kAdi_textBox1
            // 
            this.kAdi_textBox1.Location = new System.Drawing.Point(133, 337);
            this.kAdi_textBox1.Name = "kAdi_textBox1";
            this.kAdi_textBox1.Size = new System.Drawing.Size(139, 20);
            this.kAdi_textBox1.TabIndex = 12;
            this.kAdi_textBox1.TextChanged += new System.EventHandler(this.kAdi_textBox1_TextChanged);
            // 
            // sifre_textBox1
            // 
            this.sifre_textBox1.Location = new System.Drawing.Point(133, 371);
            this.sifre_textBox1.Name = "sifre_textBox1";
            this.sifre_textBox1.Size = new System.Drawing.Size(139, 20);
            this.sifre_textBox1.TabIndex = 13;
            this.sifre_textBox1.TextChanged += new System.EventHandler(this.sifre_textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(133, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(208, 230);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // kyt_button1
            // 
            this.kyt_button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.kyt_button1.Location = new System.Drawing.Point(191, 405);
            this.kyt_button1.Name = "kyt_button1";
            this.kyt_button1.Size = new System.Drawing.Size(81, 20);
            this.kyt_button1.TabIndex = 16;
            this.kyt_button1.Text = "KAYIT OL";
            this.kyt_button1.UseVisualStyleBackColor = false;
            this.kyt_button1.Click += new System.EventHandler(this.kyt_button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "SOYAD:";
            // 
            // soyad_textBox1
            // 
            this.soyad_textBox1.Location = new System.Drawing.Point(133, 85);
            this.soyad_textBox1.Name = "soyad_textBox1";
            this.soyad_textBox1.Size = new System.Drawing.Size(100, 20);
            this.soyad_textBox1.TabIndex = 18;
            this.soyad_textBox1.TextChanged += new System.EventHandler(this.soyad_textBox1_TextChanged);
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 437);
            this.Controls.Add(this.soyad_textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kyt_button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sifre_textBox1);
            this.Controls.Add(this.kAdi_textBox1);
            this.Controls.Add(this.size_textBox1);
            this.Controls.Add(this.weight_textBox1);
            this.Controls.Add(this.age_textBox1);
            this.Controls.Add(this.name_textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Kayit";
            this.Text = "Kayit";
            this.Load += new System.EventHandler(this.Kayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name_textBox1;
        private System.Windows.Forms.TextBox age_textBox1;
        private System.Windows.Forms.TextBox weight_textBox1;
        private System.Windows.Forms.TextBox size_textBox1;
        private System.Windows.Forms.TextBox kAdi_textBox1;
        private System.Windows.Forms.TextBox sifre_textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button kyt_button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox soyad_textBox1;
    }
}
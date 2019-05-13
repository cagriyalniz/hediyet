namespace hediyet
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dnsn_button = new System.Windows.Forms.Button();
            this.dyt_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kadi_textBox = new System.Windows.Forms.TextBox();
            this.sifre_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.CausesValidation = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "DİYETİSYENLERİMİZ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.CausesValidation = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(210, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "KAYIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.kyt_button_Click);
            // 
            // dnsn_button
            // 
            this.dnsn_button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dnsn_button.CausesValidation = false;
            this.dnsn_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dnsn_button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnsn_button.Location = new System.Drawing.Point(11, 226);
            this.dnsn_button.Name = "dnsn_button";
            this.dnsn_button.Size = new System.Drawing.Size(125, 57);
            this.dnsn_button.TabIndex = 2;
            this.dnsn_button.Text = "DANIŞAN GİRİŞİ";
            this.dnsn_button.UseVisualStyleBackColor = false;
            this.dnsn_button.Click += new System.EventHandler(this.dnsn_button_Click);
            // 
            // dyt_button
            // 
            this.dyt_button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dyt_button.CausesValidation = false;
            this.dyt_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dyt_button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dyt_button.Location = new System.Drawing.Point(154, 226);
            this.dyt_button.Name = "dyt_button";
            this.dyt_button.Size = new System.Drawing.Size(127, 57);
            this.dyt_button.TabIndex = 3;
            this.dyt_button.Text = "DİYETİSYEN GİRİŞİ";
            this.dyt_button.UseVisualStyleBackColor = false;
            this.dyt_button.Click += new System.EventHandler(this.dyt_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kadi_textBox
            // 
            this.kadi_textBox.Location = new System.Drawing.Point(165, 133);
            this.kadi_textBox.Name = "kadi_textBox";
            this.kadi_textBox.Size = new System.Drawing.Size(100, 20);
            this.kadi_textBox.TabIndex = 10;
            // 
            // sifre_textBox
            // 
            this.sifre_textBox.Location = new System.Drawing.Point(165, 179);
            this.sifre_textBox.Name = "sifre_textBox";
            this.sifre_textBox.Size = new System.Drawing.Size(100, 20);
            this.sifre_textBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 290);
            this.Controls.Add(this.sifre_textBox);
            this.Controls.Add(this.kadi_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dyt_button);
            this.Controls.Add(this.dnsn_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dnsn_button;
        private System.Windows.Forms.Button dyt_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox kadi_textBox;
        private System.Windows.Forms.TextBox sifre_textBox;
    }
}


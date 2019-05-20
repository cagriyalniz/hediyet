namespace hediyet
{
    partial class dytoner
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
            this.onerbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // onerbutton
            // 
            this.onerbutton.Location = new System.Drawing.Point(371, 196);
            this.onerbutton.Name = "onerbutton";
            this.onerbutton.Size = new System.Drawing.Size(100, 49);
            this.onerbutton.TabIndex = 0;
            this.onerbutton.Text = "öner";
            this.onerbutton.UseVisualStyleBackColor = true;
            this.onerbutton.Click += new System.EventHandler(this.onerbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(441, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dytoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 263);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.onerbutton);
            this.Name = "dytoner";
            this.Text = "dytoner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onerbutton;
        private System.Windows.Forms.TextBox textBox1;
    }
}
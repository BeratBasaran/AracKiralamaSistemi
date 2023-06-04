namespace AracKiralamaSistemi
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bayii1 = new System.Windows.Forms.Button();
            this.Bayii2 = new System.Windows.Forms.Button();
            this.Bayii3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(146, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Berat Rent A Car ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AracKiralamaSistemi.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(40, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Bayii1
            // 
            this.Bayii1.BackColor = System.Drawing.Color.Transparent;
            this.Bayii1.Location = new System.Drawing.Point(165, 117);
            this.Bayii1.Name = "Bayii1";
            this.Bayii1.Size = new System.Drawing.Size(150, 40);
            this.Bayii1.TabIndex = 1;
            this.Bayii1.Text = "KOCAELİ";
            this.Bayii1.UseVisualStyleBackColor = false;
            this.Bayii1.Click += new System.EventHandler(this.Bayii1_Click);
            // 
            // Bayii2
            // 
            this.Bayii2.BackColor = System.Drawing.Color.Transparent;
            this.Bayii2.Location = new System.Drawing.Point(165, 195);
            this.Bayii2.Name = "Bayii2";
            this.Bayii2.Size = new System.Drawing.Size(150, 40);
            this.Bayii2.TabIndex = 2;
            this.Bayii2.Text = "İSTANBUL";
            this.Bayii2.UseVisualStyleBackColor = false;
            this.Bayii2.Click += new System.EventHandler(this.Bayii2_Click);
            // 
            // Bayii3
            // 
            this.Bayii3.BackColor = System.Drawing.Color.Transparent;
            this.Bayii3.Location = new System.Drawing.Point(165, 277);
            this.Bayii3.Name = "Bayii3";
            this.Bayii3.Size = new System.Drawing.Size(150, 40);
            this.Bayii3.TabIndex = 3;
            this.Bayii3.Text = "İZMİR";
            this.Bayii3.UseVisualStyleBackColor = false;
            this.Bayii3.Click += new System.EventHandler(this.Bayii3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(46, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lütfen İşlem Yapmak İstediğiniz Bayi Seçiniz.";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(499, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bayii3);
            this.Controls.Add(this.Bayii2);
            this.Controls.Add(this.Bayii1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bayi Seçimi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Bayii1;
        private System.Windows.Forms.Button Bayii2;
        private System.Windows.Forms.Button Bayii3;
        private System.Windows.Forms.Label label2;
    }
}
namespace AracKiralamaSistemi
{
    partial class MusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdSoyadtext = new System.Windows.Forms.TextBox();
            this.TCNOtext = new System.Windows.Forms.TextBox();
            this.EMailtext = new System.Windows.Forms.TextBox();
            this.Adrestext = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cikisbtn = new System.Windows.Forms.Button();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "T.C. No:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon Numarası:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mail Adresi:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres:";
            // 
            // AdSoyadtext
            // 
            this.AdSoyadtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdSoyadtext.Location = new System.Drawing.Point(236, 53);
            this.AdSoyadtext.Name = "AdSoyadtext";
            this.AdSoyadtext.Size = new System.Drawing.Size(230, 27);
            this.AdSoyadtext.TabIndex = 1;
            this.AdSoyadtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdSoyadtext_KeyPress);
            // 
            // TCNOtext
            // 
            this.TCNOtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TCNOtext.Location = new System.Drawing.Point(236, 19);
            this.TCNOtext.MaxLength = 11;
            this.TCNOtext.Name = "TCNOtext";
            this.TCNOtext.Size = new System.Drawing.Size(230, 27);
            this.TCNOtext.TabIndex = 1;
            this.TCNOtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCNOtext_KeyPress);
            // 
            // EMailtext
            // 
            this.EMailtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMailtext.Location = new System.Drawing.Point(237, 123);
            this.EMailtext.Name = "EMailtext";
            this.EMailtext.Size = new System.Drawing.Size(230, 27);
            this.EMailtext.TabIndex = 1;
            this.EMailtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EMailtext_KeyPress);
            this.EMailtext.Leave += new System.EventHandler(this.EMailtext_Leave);
            // 
            // Adrestext
            // 
            this.Adrestext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Adrestext.Location = new System.Drawing.Point(237, 159);
            this.Adrestext.Multiline = true;
            this.Adrestext.Name = "Adrestext";
            this.Adrestext.Size = new System.Drawing.Size(230, 100);
            this.Adrestext.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(237, 87);
            this.maskedTextBox1.Mask = "(599) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(229, 27);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // cikisbtn
            // 
            this.cikisbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cikisbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cikisbtn.Location = new System.Drawing.Point(387, 367);
            this.cikisbtn.Name = "cikisbtn";
            this.cikisbtn.Size = new System.Drawing.Size(100, 50);
            this.cikisbtn.TabIndex = 3;
            this.cikisbtn.Text = "Çıkış Yap";
            this.cikisbtn.UseVisualStyleBackColor = true;
            this.cikisbtn.Click += new System.EventHandler(this.cikisbtn_Click);
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kaydetbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kaydetbtn.Location = new System.Drawing.Point(12, 367);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(100, 50);
            this.kaydetbtn.TabIndex = 3;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(162, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "© 2023 Copyright";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AracKiralamaSistemi.Properties.Resources.kaydet;
            this.pictureBox1.Location = new System.Drawing.Point(12, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AracKiralamaSistemi.Properties.Resources.çıkış_yap;
            this.pictureBox2.Location = new System.Drawing.Point(387, 311);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(499, 429);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cikisbtn);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Adrestext);
            this.Controls.Add(this.EMailtext);
            this.Controls.Add(this.TCNOtext);
            this.Controls.Add(this.AdSoyadtext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "MusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AdSoyadtext;
        private System.Windows.Forms.TextBox TCNOtext;
        private System.Windows.Forms.TextBox EMailtext;
        private System.Windows.Forms.TextBox Adrestext;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button cikisbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
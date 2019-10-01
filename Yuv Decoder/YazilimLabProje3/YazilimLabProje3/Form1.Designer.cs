namespace YazilimLabProje3
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
            this.components = new System.ComponentModel.Container();
            this.btnDosyaOku = new System.Windows.Forms.Button();
            this.lblYukseklik = new System.Windows.Forms.Label();
            this.lblGenislik = new System.Windows.Forms.Label();
            this.txtYukseklik = new System.Windows.Forms.TextBox();
            this.txtGenislik = new System.Windows.Forms.TextBox();
            this.BtnSifirla = new System.Windows.Forms.Button();
            this.ResimAlani = new System.Windows.Forms.PictureBox();
            this.radioBtn420 = new System.Windows.Forms.RadioButton();
            this.radioBtn422 = new System.Windows.Forms.RadioButton();
            this.radioBtn444 = new System.Windows.Forms.RadioButton();
            this.btnGoruntuOynat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ResimAlani)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDosyaOku
            // 
            this.btnDosyaOku.Location = new System.Drawing.Point(282, 335);
            this.btnDosyaOku.Name = "btnDosyaOku";
            this.btnDosyaOku.Size = new System.Drawing.Size(98, 25);
            this.btnDosyaOku.TabIndex = 0;
            this.btnDosyaOku.Text = "Dosya Oku";
            this.btnDosyaOku.UseVisualStyleBackColor = true;
            this.btnDosyaOku.Click += new System.EventHandler(this.btnDosyaOku_Click);
            // 
            // lblYukseklik
            // 
            this.lblYukseklik.AutoSize = true;
            this.lblYukseklik.Location = new System.Drawing.Point(89, 367);
            this.lblYukseklik.Name = "lblYukseklik";
            this.lblYukseklik.Size = new System.Drawing.Size(53, 13);
            this.lblYukseklik.TabIndex = 1;
            this.lblYukseklik.Text = "Yükseklik";
            // 
            // lblGenislik
            // 
            this.lblGenislik.AutoSize = true;
            this.lblGenislik.Location = new System.Drawing.Point(89, 341);
            this.lblGenislik.Name = "lblGenislik";
            this.lblGenislik.Size = new System.Drawing.Size(44, 13);
            this.lblGenislik.TabIndex = 2;
            this.lblGenislik.Text = "Genişlik";
            // 
            // txtYukseklik
            // 
            this.txtYukseklik.Location = new System.Drawing.Point(148, 364);
            this.txtYukseklik.Name = "txtYukseklik";
            this.txtYukseklik.Size = new System.Drawing.Size(86, 20);
            this.txtYukseklik.TabIndex = 3;
            // 
            // txtGenislik
            // 
            this.txtGenislik.Location = new System.Drawing.Point(148, 338);
            this.txtGenislik.Name = "txtGenislik";
            this.txtGenislik.Size = new System.Drawing.Size(86, 20);
            this.txtGenislik.TabIndex = 4;
            // 
            // BtnSifirla
            // 
            this.BtnSifirla.Location = new System.Drawing.Point(282, 399);
            this.BtnSifirla.Name = "BtnSifirla";
            this.BtnSifirla.Size = new System.Drawing.Size(98, 25);
            this.BtnSifirla.TabIndex = 6;
            this.BtnSifirla.Text = "Sıfırla";
            this.BtnSifirla.UseVisualStyleBackColor = true;
            this.BtnSifirla.Click += new System.EventHandler(this.BtnSifirla_Click);
            // 
            // ResimAlani
            // 
            this.ResimAlani.Location = new System.Drawing.Point(20, 17);
            this.ResimAlani.Name = "ResimAlani";
            this.ResimAlani.Size = new System.Drawing.Size(640, 294);
            this.ResimAlani.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResimAlani.TabIndex = 7;
            this.ResimAlani.TabStop = false;
            this.ResimAlani.Click += new System.EventHandler(this.ResimAlani_Click);
            // 
            // radioBtn420
            // 
            this.radioBtn420.AutoSize = true;
            this.radioBtn420.Location = new System.Drawing.Point(20, 339);
            this.radioBtn420.Name = "radioBtn420";
            this.radioBtn420.Size = new System.Drawing.Size(49, 17);
            this.radioBtn420.TabIndex = 8;
            this.radioBtn420.TabStop = true;
            this.radioBtn420.Text = "4 2 0";
            this.radioBtn420.UseVisualStyleBackColor = true;
            // 
            // radioBtn422
            // 
            this.radioBtn422.AutoSize = true;
            this.radioBtn422.Location = new System.Drawing.Point(20, 362);
            this.radioBtn422.Name = "radioBtn422";
            this.radioBtn422.Size = new System.Drawing.Size(49, 17);
            this.radioBtn422.TabIndex = 9;
            this.radioBtn422.TabStop = true;
            this.radioBtn422.Text = "4 2 2";
            this.radioBtn422.UseVisualStyleBackColor = true;
            // 
            // radioBtn444
            // 
            this.radioBtn444.AutoSize = true;
            this.radioBtn444.Location = new System.Drawing.Point(20, 385);
            this.radioBtn444.Name = "radioBtn444";
            this.radioBtn444.Size = new System.Drawing.Size(49, 17);
            this.radioBtn444.TabIndex = 10;
            this.radioBtn444.TabStop = true;
            this.radioBtn444.Text = "4 4 4";
            this.radioBtn444.UseVisualStyleBackColor = true;
            // 
            // btnGoruntuOynat
            // 
            this.btnGoruntuOynat.Location = new System.Drawing.Point(282, 367);
            this.btnGoruntuOynat.Name = "btnGoruntuOynat";
            this.btnGoruntuOynat.Size = new System.Drawing.Size(98, 26);
            this.btnGoruntuOynat.TabIndex = 11;
            this.btnGoruntuOynat.Text = "Görüntüyü Oynat";
            this.btnGoruntuOynat.UseVisualStyleBackColor = true;
            this.btnGoruntuOynat.Click += new System.EventHandler(this.btnGoruntuOynat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 41;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.btnGoruntuOynat);
            this.Controls.Add(this.radioBtn444);
            this.Controls.Add(this.radioBtn422);
            this.Controls.Add(this.radioBtn420);
            this.Controls.Add(this.ResimAlani);
            this.Controls.Add(this.BtnSifirla);
            this.Controls.Add(this.txtGenislik);
            this.Controls.Add(this.txtYukseklik);
            this.Controls.Add(this.lblGenislik);
            this.Controls.Add(this.lblYukseklik);
            this.Controls.Add(this.btnDosyaOku);
            this.Name = "Form1";
            this.Text = "YUV(Raw Data) Çözücü";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResimAlani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaOku;
        private System.Windows.Forms.Label lblYukseklik;
        private System.Windows.Forms.Label lblGenislik;
        private System.Windows.Forms.TextBox txtYukseklik;
        private System.Windows.Forms.TextBox txtGenislik;
        private System.Windows.Forms.Button BtnSifirla;
        private System.Windows.Forms.PictureBox ResimAlani;
        private System.Windows.Forms.RadioButton radioBtn420;
        private System.Windows.Forms.RadioButton radioBtn422;
        private System.Windows.Forms.RadioButton radioBtn444;
        private System.Windows.Forms.Button btnGoruntuOynat;
        private System.Windows.Forms.Timer timer1;
    }
}


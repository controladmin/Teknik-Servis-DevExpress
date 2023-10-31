
namespace TeknikServis.Formlar
{
    partial class FrmArizaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaDetay));
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtserino = new System.Windows.Forms.TextBox();
            this.txttarih = new System.Windows.Forms.TextBox();
            this.cburundurumdetay = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnvazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnurundurumdetay = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnguncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnguncelle.Appearance.Options.UseBackColor = true;
            this.btnguncelle.Appearance.Options.UseFont = true;
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(17, 407);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(194, 47);
            this.btnguncelle.TabIndex = 94;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 25);
            this.label2.TabIndex = 96;
            this.label2.Text = "ARIZALI ÜRÜN KAYDI AÇIKLAMA";
            // 
            // txtaciklama
            // 
            this.txtaciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaciklama.Location = new System.Drawing.Point(16, 218);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(403, 183);
            this.txtaciklama.TabIndex = 97;
            this.txtaciklama.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 98;
            this.label3.Text = "Seri No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 99;
            this.label4.Text = "Tarih :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 100;
            this.label5.Text = "Arıza Detayları :";
            // 
            // txtserino
            // 
            this.txtserino.Location = new System.Drawing.Point(154, 80);
            this.txtserino.Name = "txtserino";
            this.txtserino.Size = new System.Drawing.Size(207, 20);
            this.txtserino.TabIndex = 101;
            // 
            // txttarih
            // 
            this.txttarih.Location = new System.Drawing.Point(154, 117);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(207, 20);
            this.txttarih.TabIndex = 102;
            // 
            // cburundurumdetay
            // 
            this.cburundurumdetay.FormattingEnabled = true;
            this.cburundurumdetay.Items.AddRange(new object[] {
            "Ürün Kayıt Edildi",
            "Parça Bekleniyor",
            "Mesaj Bekleniyor",
            "İptal Edildi",
            "Fiyat Teklifi Verildi"});
            this.cburundurumdetay.Location = new System.Drawing.Point(154, 154);
            this.cburundurumdetay.Name = "cburundurumdetay";
            this.cburundurumdetay.Size = new System.Drawing.Size(207, 21);
            this.cburundurumdetay.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 104;
            this.label6.Text = "Ürün Durum Detay :";
            // 
            // btnvazgec
            // 
            this.btnvazgec.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnvazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnvazgec.Appearance.Options.UseBackColor = true;
            this.btnvazgec.Appearance.Options.UseFont = true;
            this.btnvazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnvazgec.Location = new System.Drawing.Point(226, 407);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(194, 47);
            this.btnvazgec.TabIndex = 105;
            this.btnvazgec.Text = "VAZGEÇ";
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
            // 
            // btnurundurumdetay
            // 
            this.btnurundurumdetay.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnurundurumdetay.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnurundurumdetay.Appearance.Options.UseBackColor = true;
            this.btnurundurumdetay.Appearance.Options.UseFont = true;
            this.btnurundurumdetay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnurundurumdetay.Location = new System.Drawing.Point(367, 148);
            this.btnurundurumdetay.Name = "btnurundurumdetay";
            this.btnurundurumdetay.Size = new System.Drawing.Size(104, 32);
            this.btnurundurumdetay.TabIndex = 106;
            this.btnurundurumdetay.Text = "GÜNCELLE";
            this.btnurundurumdetay.Click += new System.EventHandler(this.btnurundurumdetay_Click);
            // 
            // FrmArizaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(486, 470);
            this.Controls.Add(this.btnurundurumdetay);
            this.Controls.Add(this.btnvazgec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cburundurumdetay);
            this.Controls.Add(this.txttarih);
            this.Controls.Add(this.txtserino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmArizaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArizaDetay";
            this.Load += new System.EventHandler(this.FrmArizaDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtaciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtserino;
        private System.Windows.Forms.TextBox txttarih;
        private System.Windows.Forms.ComboBox cburundurumdetay;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnvazgec;
        private DevExpress.XtraEditors.SimpleButton btnurundurumdetay;
    }
}
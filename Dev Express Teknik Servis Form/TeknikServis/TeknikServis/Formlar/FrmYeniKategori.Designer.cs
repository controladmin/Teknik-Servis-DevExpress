
namespace TeknikServis.Formlar
{
    partial class FrmYeniKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniKategori));
            this.btnvazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnkategoriekle = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtkategoriadi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvazgec
            // 
            this.btnvazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnvazgec.Appearance.Options.UseFont = true;
            this.btnvazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnvazgec.ImageOptions.Image")));
            this.btnvazgec.Location = new System.Drawing.Point(67, 190);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(200, 47);
            this.btnvazgec.TabIndex = 43;
            this.btnvazgec.Text = "VAZGEÇ";
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
            // 
            // btnkategoriekle
            // 
            this.btnkategoriekle.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnkategoriekle.Appearance.Options.UseFont = true;
            this.btnkategoriekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btburunekle.ImageOptions.Image")));
            this.btnkategoriekle.Location = new System.Drawing.Point(67, 137);
            this.btnkategoriekle.Name = "btnkategoriekle";
            this.btnkategoriekle.Size = new System.Drawing.Size(200, 47);
            this.btnkategoriekle.TabIndex = 42;
            this.btnkategoriekle.Text = "KATEGORİ EKLE";
            this.btnkategoriekle.Click += new System.EventHandler(this.btnkategoriekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "YENİ KATEGORİ EKLEME";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(14, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 68);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 40;
            this.pictureBox7.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(67, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 25;
            // 
            // txtkategoriadi
            // 
            this.txtkategoriadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtkategoriadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkategoriadi.ForeColor = System.Drawing.Color.White;
            this.txtkategoriadi.Location = new System.Drawing.Point(67, 104);
            this.txtkategoriadi.Name = "txtkategoriadi";
            this.txtkategoriadi.Size = new System.Drawing.Size(200, 20);
            this.txtkategoriadi.TabIndex = 24;
            this.txtkategoriadi.Text = "Kategori Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FrmYeniKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(381, 250);
            this.Controls.Add(this.btnvazgec);
            this.Controls.Add(this.btnkategoriekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtkategoriadi);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmYeniKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYeniKategori";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnvazgec;
        private DevExpress.XtraEditors.SimpleButton btnkategoriekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtkategoriadi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
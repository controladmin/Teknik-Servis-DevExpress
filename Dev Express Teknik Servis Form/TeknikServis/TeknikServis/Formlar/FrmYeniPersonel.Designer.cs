
namespace TeknikServis.Formlar
{
    partial class FrmYeniPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniPersonel));
            this.lupdepartman = new DevExpress.XtraEditors.LookUpEdit();
            this.btnvazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btburunekle = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtceptelefonu = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtfotograf = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lupdepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // lupdepartman
            // 
            this.lupdepartman.Location = new System.Drawing.Point(140, 229);
            this.lupdepartman.Name = "lupdepartman";
            this.lupdepartman.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lupdepartman.Properties.Appearance.Options.UseBackColor = true;
            this.lupdepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupdepartman.Properties.DisplayMember = "Ad";
            this.lupdepartman.Properties.ValueMember = "ID";
            this.lupdepartman.Size = new System.Drawing.Size(200, 20);
            this.lupdepartman.TabIndex = 44;
            // 
            // btnvazgec
            // 
            this.btnvazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnvazgec.Appearance.Options.UseFont = true;
            this.btnvazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnvazgec.ImageOptions.Image")));
            this.btnvazgec.Location = new System.Drawing.Point(140, 680);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(200, 47);
            this.btnvazgec.TabIndex = 43;
            this.btnvazgec.Text = "VAZGEÇ";
            // 
            // btburunekle
            // 
            this.btburunekle.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btburunekle.Appearance.Options.UseFont = true;
            this.btburunekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btburunekle.ImageOptions.Image")));
            this.btburunekle.Location = new System.Drawing.Point(140, 627);
            this.btburunekle.Name = "btburunekle";
            this.btburunekle.Size = new System.Drawing.Size(200, 47);
            this.btburunekle.TabIndex = 42;
            this.btburunekle.Text = "PERSONEL EKLE";
            this.btburunekle.Click += new System.EventHandler(this.btburunekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "YENİ PERSONEL EKLEME";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(87, 26);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 68);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 40;
            this.pictureBox7.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(140, 413);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 2);
            this.panel6.TabIndex = 39;
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmail.ForeColor = System.Drawing.Color.White;
            this.txtmail.Location = new System.Drawing.Point(140, 388);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(200, 20);
            this.txtmail.TabIndex = 38;
            this.txtmail.Text = "Mail";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(87, 368);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(140, 360);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 2);
            this.panel5.TabIndex = 36;
            // 
            // txtceptelefonu
            // 
            this.txtceptelefonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtceptelefonu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtceptelefonu.ForeColor = System.Drawing.Color.White;
            this.txtceptelefonu.Location = new System.Drawing.Point(140, 335);
            this.txtceptelefonu.Name = "txtceptelefonu";
            this.txtceptelefonu.Size = new System.Drawing.Size(200, 20);
            this.txtceptelefonu.TabIndex = 35;
            this.txtceptelefonu.Text = "Cep Telefonu";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(87, 315);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 47);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(140, 307);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 2);
            this.panel4.TabIndex = 33;
            // 
            // txttelefon
            // 
            this.txttelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txttelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttelefon.ForeColor = System.Drawing.Color.White;
            this.txttelefon.Location = new System.Drawing.Point(140, 282);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(200, 20);
            this.txttelefon.TabIndex = 32;
            this.txttelefon.Text = "Telefon";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(87, 262);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(140, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 30;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(87, 209);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(140, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 28;
            // 
            // txtsoyad
            // 
            this.txtsoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsoyad.ForeColor = System.Drawing.Color.White;
            this.txtsoyad.Location = new System.Drawing.Point(140, 176);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(200, 20);
            this.txtsoyad.TabIndex = 27;
            this.txtsoyad.Text = "Personel Soyadı";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(87, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(140, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 25;
            // 
            // txtad
            // 
            this.txtad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtad.ForeColor = System.Drawing.Color.White;
            this.txtad.Location = new System.Drawing.Point(140, 123);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(200, 20);
            this.txtad.TabIndex = 24;
            this.txtad.Text = "Personel Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Location = new System.Drawing.Point(140, 466);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 2);
            this.panel7.TabIndex = 47;
            // 
            // txtfotograf
            // 
            this.txtfotograf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtfotograf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfotograf.ForeColor = System.Drawing.Color.White;
            this.txtfotograf.Location = new System.Drawing.Point(140, 441);
            this.txtfotograf.Name = "txtfotograf";
            this.txtfotograf.Size = new System.Drawing.Size(200, 20);
            this.txtfotograf.TabIndex = 46;
            this.txtfotograf.Text = "Fotoğraf";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(87, 421);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(47, 47);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 45;
            this.pictureBox8.TabStop = false;
            // 
            // txtadres
            // 
            this.txtadres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtadres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadres.ForeColor = System.Drawing.Color.White;
            this.txtadres.Location = new System.Drawing.Point(140, 494);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(200, 127);
            this.txtadres.TabIndex = 49;
            this.txtadres.Text = "Adres";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(87, 534);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(47, 47);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 48;
            this.pictureBox9.TabStop = false;
            // 
            // FrmYeniPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(491, 747);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtfotograf);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.lupdepartman);
            this.Controls.Add(this.btnvazgec);
            this.Controls.Add(this.btburunekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtceptelefonu);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmYeniPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYeniPersonel";
            this.Load += new System.EventHandler(this.FrmYeniPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lupdepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lupdepartman;
        private DevExpress.XtraEditors.SimpleButton btnvazgec;
        private DevExpress.XtraEditors.SimpleButton btburunekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtceptelefonu;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtfotograf;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}
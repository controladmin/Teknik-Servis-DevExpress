
namespace TeknikServis.Formlar
{
    partial class FrmDepartmanListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartmanListesi));
            this.dgdepartmanlistesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupcontrol1 = new DevExpress.XtraEditors.GroupControl();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.txtdepartmanid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtdepartmanadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltoplmadepartman = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.llbltoplampersonel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblenfazlaperdepartman = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblenazcalisandepartman = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdepartmanlistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupcontrol1)).BeginInit();
            this.groupcontrol1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdepartmanid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdepartmanadi.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdepartmanlistesi
            // 
            this.dgdepartmanlistesi.Location = new System.Drawing.Point(5, 126);
            this.dgdepartmanlistesi.MainView = this.gridView1;
            this.dgdepartmanlistesi.Name = "dgdepartmanlistesi";
            this.dgdepartmanlistesi.Size = new System.Drawing.Size(1511, 652);
            this.dgdepartmanlistesi.TabIndex = 2;
            this.dgdepartmanlistesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgdepartmanlistesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupcontrol1
            // 
            this.groupcontrol1.Controls.Add(this.txtaciklama);
            this.groupcontrol1.Controls.Add(this.txtdepartmanid);
            this.groupcontrol1.Controls.Add(this.labelControl7);
            this.groupcontrol1.Controls.Add(this.btnlistele);
            this.groupcontrol1.Controls.Add(this.btnsil);
            this.groupcontrol1.Controls.Add(this.btnguncelle);
            this.groupcontrol1.Controls.Add(this.btnkaydet);
            this.groupcontrol1.Controls.Add(this.labelControl2);
            this.groupcontrol1.Controls.Add(this.txtdepartmanadi);
            this.groupcontrol1.Controls.Add(this.labelControl1);
            this.groupcontrol1.Location = new System.Drawing.Point(1522, 12);
            this.groupcontrol1.Name = "groupcontrol1";
            this.groupcontrol1.Size = new System.Drawing.Size(355, 775);
            this.groupcontrol1.TabIndex = 5;
            this.groupcontrol1.Text = "DEPARTMAN İŞLEMLERİ";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(138, 82);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(207, 184);
            this.txtaciklama.TabIndex = 19;
            // 
            // txtdepartmanid
            // 
            this.txtdepartmanid.Enabled = false;
            this.txtdepartmanid.Location = new System.Drawing.Point(138, 31);
            this.txtdepartmanid.Name = "txtdepartmanid";
            this.txtdepartmanid.Size = new System.Drawing.Size(207, 20);
            this.txtdepartmanid.TabIndex = 18;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(74, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Departman ID :";
            // 
            // btnlistele
            // 
            this.btnlistele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.ImageOptions.Image")));
            this.btnlistele.Location = new System.Drawing.Point(138, 410);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(207, 40);
            this.btnlistele.TabIndex = 16;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(138, 364);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(207, 40);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "SİL";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(138, 318);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(207, 40);
            this.btnguncelle.TabIndex = 14;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(138, 272);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(207, 40);
            this.btnkaydet.TabIndex = 13;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 170);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Açıklama :";
            // 
            // txtdepartmanadi
            // 
            this.txtdepartmanadi.Location = new System.Drawing.Point(138, 57);
            this.txtdepartmanadi.Name = "txtdepartmanadi";
            this.txtdepartmanadi.Size = new System.Drawing.Size(207, 20);
            this.txtdepartmanadi.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Departman Ad :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbltoplmadepartman);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 100);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbltoplmadepartman
            // 
            this.lbltoplmadepartman.AutoSize = true;
            this.lbltoplmadepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplmadepartman.Location = new System.Drawing.Point(3, 58);
            this.lbltoplmadepartman.Name = "lbltoplmadepartman";
            this.lbltoplmadepartman.Size = new System.Drawing.Size(48, 17);
            this.lbltoplmadepartman.TabIndex = 1;
            this.lbltoplmadepartman.Text = "00000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Departman Sayısı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.llbltoplampersonel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(286, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 100);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(202, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // llbltoplampersonel
            // 
            this.llbltoplampersonel.AutoSize = true;
            this.llbltoplampersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llbltoplampersonel.Location = new System.Drawing.Point(3, 58);
            this.llbltoplampersonel.Name = "llbltoplampersonel";
            this.llbltoplampersonel.Size = new System.Drawing.Size(48, 17);
            this.llbltoplampersonel.TabIndex = 1;
            this.llbltoplampersonel.Text = "00000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam Personel Sayısı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblenfazlaperdepartman);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(567, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 100);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(202, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lblenfazlaperdepartman
            // 
            this.lblenfazlaperdepartman.AutoSize = true;
            this.lblenfazlaperdepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblenfazlaperdepartman.Location = new System.Drawing.Point(3, 58);
            this.lblenfazlaperdepartman.Name = "lblenfazlaperdepartman";
            this.lblenfazlaperdepartman.Size = new System.Drawing.Size(48, 17);
            this.lblenfazlaperdepartman.TabIndex = 1;
            this.lblenfazlaperdepartman.Text = "00000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "En Fazla Çalışanı Olan Departman";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.lblenazcalisandepartman);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(848, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 100);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(202, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // lblenazcalisandepartman
            // 
            this.lblenazcalisandepartman.AutoSize = true;
            this.lblenazcalisandepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblenazcalisandepartman.Location = new System.Drawing.Point(3, 58);
            this.lblenazcalisandepartman.Name = "lblenazcalisandepartman";
            this.lblenazcalisandepartman.Size = new System.Drawing.Size(48, 17);
            this.lblenazcalisandepartman.TabIndex = 1;
            this.lblenazcalisandepartman.Text = "00000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "En Az Çalışanı Olan Departman";
            // 
            // FrmDepartmanListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 861);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupcontrol1);
            this.Controls.Add(this.dgdepartmanlistesi);
            this.Name = "FrmDepartmanListesi";
            this.Text = "FrmDepartmanListesi";
            this.Load += new System.EventHandler(this.FrmDepartmanListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdepartmanlistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupcontrol1)).EndInit();
            this.groupcontrol1.ResumeLayout(false);
            this.groupcontrol1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdepartmanid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdepartmanadi.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupcontrol1;
        private DevExpress.XtraEditors.TextEdit txtdepartmanid;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtdepartmanadi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltoplmadepartman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label llbltoplampersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblenfazlaperdepartman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblenazcalisandepartman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtaciklama;
        private DevExpress.XtraGrid.GridControl dgdepartmanlistesi;
    }
}
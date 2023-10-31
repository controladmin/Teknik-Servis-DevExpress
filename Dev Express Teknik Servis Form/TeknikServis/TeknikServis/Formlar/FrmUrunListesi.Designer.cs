
namespace TeknikServis.Formlar
{
    partial class FrmUrunListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunListesi));
            this.grdurunlistesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txturunadi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txturunid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lupkategori = new DevExpress.XtraEditors.LookUpEdit();
            this.txtstok = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtsatisfiyati = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtalisfiyati = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtmarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdurunlistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txturunid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupkategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsatisfiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalisfiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmarka.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdurunlistesi
            // 
            this.grdurunlistesi.Location = new System.Drawing.Point(5, 12);
            this.grdurunlistesi.MainView = this.gridView1;
            this.grdurunlistesi.Name = "grdurunlistesi";
            this.grdurunlistesi.Size = new System.Drawing.Size(1511, 840);
            this.grdurunlistesi.TabIndex = 0;
            this.grdurunlistesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdurunlistesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürün Adı :";
            // 
            // txturunadi
            // 
            this.txturunadi.Location = new System.Drawing.Point(138, 57);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(207, 20);
            this.txturunadi.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.txturunid);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnlistele);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnguncelle);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.lupkategori);
            this.groupControl1.Controls.Add(this.txtstok);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtsatisfiyati);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtalisfiyati);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtmarka);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txturunadi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1522, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(355, 840);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // txturunid
            // 
            this.txturunid.Enabled = false;
            this.txturunid.Location = new System.Drawing.Point(138, 31);
            this.txturunid.Name = "txturunid";
            this.txturunid.Size = new System.Drawing.Size(207, 20);
            this.txturunid.TabIndex = 18;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(44, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Ürün ID :";
            // 
            // btnlistele
            // 
            this.btnlistele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.ImageOptions.Image")));
            this.btnlistele.Location = new System.Drawing.Point(138, 365);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(207, 40);
            this.btnlistele.TabIndex = 16;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(138, 319);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(207, 40);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "SİL";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(138, 273);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(207, 40);
            this.btnguncelle.TabIndex = 14;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(138, 227);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(207, 40);
            this.btnkaydet.TabIndex = 13;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 192);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Kategori :";
            // 
            // lupkategori
            // 
            this.lupkategori.Location = new System.Drawing.Point(138, 188);
            this.lupkategori.Name = "lupkategori";
            this.lupkategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupkategori.Properties.DisplayMember = "Ad";
            this.lupkategori.Properties.NullText = "Kategori Seciniz";
            this.lupkategori.Properties.ValueMember = "ID";
            this.lupkategori.Size = new System.Drawing.Size(207, 20);
            this.lupkategori.TabIndex = 11;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(138, 161);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(207, 20);
            this.txtstok.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 165);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Stok :";
            // 
            // txtsatisfiyati
            // 
            this.txtsatisfiyati.Location = new System.Drawing.Point(138, 135);
            this.txtsatisfiyati.Name = "txtsatisfiyati";
            this.txtsatisfiyati.Size = new System.Drawing.Size(207, 20);
            this.txtsatisfiyati.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 139);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Satış Fiyatı :";
            // 
            // txtalisfiyati
            // 
            this.txtalisfiyati.Location = new System.Drawing.Point(138, 109);
            this.txtalisfiyati.Name = "txtalisfiyati";
            this.txtalisfiyati.Size = new System.Drawing.Size(207, 20);
            this.txtalisfiyati.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Alış Fiyatı :";
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(138, 83);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(207, 20);
            this.txtmarka.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Marka :";
            // 
            // btntemizle
            // 
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(138, 411);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(207, 40);
            this.btntemizle.TabIndex = 19;
            this.btntemizle.Text = "TEMİZLE";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // FrmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1884, 861);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdurunlistesi);
            this.Name = "FrmUrunListesi";
            this.Text = "Marka :";
            this.Load += new System.EventHandler(this.FrmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdurunlistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txturunid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupkategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsatisfiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalisfiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmarka.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdurunlistesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txturunadi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lupkategori;
        private DevExpress.XtraEditors.TextEdit txtstok;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtsatisfiyati;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtalisfiyati;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtmarka;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.TextEdit txturunid;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
    }
}
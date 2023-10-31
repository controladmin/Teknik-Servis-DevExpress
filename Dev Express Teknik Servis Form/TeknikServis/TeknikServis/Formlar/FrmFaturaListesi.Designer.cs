
namespace TeknikServis.Formlar
{
    partial class FrmFaturaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListesi));
            this.txtseri = new DevExpress.XtraEditors.TextEdit();
            this.txtsirano = new System.Windows.Forms.TextBox();
            this.txtfaturaid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupcontrol1 = new DevExpress.XtraEditors.GroupControl();
            this.luepersonel = new DevExpress.XtraEditors.LookUpEdit();
            this.luecari = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtvergidairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtsaat = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txttarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgfaturalistesi = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtseri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfaturaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupcontrol1)).BeginInit();
            this.groupcontrol1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luepersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luecari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvergidairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgfaturalistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtseri
            // 
            this.txtseri.Location = new System.Drawing.Point(138, 57);
            this.txtseri.Name = "txtseri";
            this.txtseri.Size = new System.Drawing.Size(207, 20);
            this.txtseri.TabIndex = 2;
            // 
            // txtsirano
            // 
            this.txtsirano.Location = new System.Drawing.Point(138, 82);
            this.txtsirano.Name = "txtsirano";
            this.txtsirano.Size = new System.Drawing.Size(207, 21);
            this.txtsirano.TabIndex = 19;
            // 
            // txtfaturaid
            // 
            this.txtfaturaid.Enabled = false;
            this.txtfaturaid.Location = new System.Drawing.Point(138, 31);
            this.txtfaturaid.Name = "txtfaturaid";
            this.txtfaturaid.Size = new System.Drawing.Size(207, 20);
            this.txtfaturaid.TabIndex = 18;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Fatura ID :";
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
            this.labelControl2.Location = new System.Drawing.Point(9, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Sıra No :";
            // 
            // groupcontrol1
            // 
            this.groupcontrol1.Controls.Add(this.luepersonel);
            this.groupcontrol1.Controls.Add(this.luecari);
            this.groupcontrol1.Controls.Add(this.labelControl9);
            this.groupcontrol1.Controls.Add(this.labelControl5);
            this.groupcontrol1.Controls.Add(this.txtvergidairesi);
            this.groupcontrol1.Controls.Add(this.labelControl6);
            this.groupcontrol1.Controls.Add(this.txtsaat);
            this.groupcontrol1.Controls.Add(this.labelControl3);
            this.groupcontrol1.Controls.Add(this.txttarih);
            this.groupcontrol1.Controls.Add(this.labelControl4);
            this.groupcontrol1.Controls.Add(this.txtsirano);
            this.groupcontrol1.Controls.Add(this.txtfaturaid);
            this.groupcontrol1.Controls.Add(this.labelControl7);
            this.groupcontrol1.Controls.Add(this.btnlistele);
            this.groupcontrol1.Controls.Add(this.btnsil);
            this.groupcontrol1.Controls.Add(this.btnguncelle);
            this.groupcontrol1.Controls.Add(this.btnkaydet);
            this.groupcontrol1.Controls.Add(this.labelControl2);
            this.groupcontrol1.Controls.Add(this.txtseri);
            this.groupcontrol1.Controls.Add(this.labelControl1);
            this.groupcontrol1.Location = new System.Drawing.Point(1523, 14);
            this.groupcontrol1.Name = "groupcontrol1";
            this.groupcontrol1.Size = new System.Drawing.Size(355, 775);
            this.groupcontrol1.TabIndex = 13;
            this.groupcontrol1.Text = "FATURA İŞLEMLERİ";
            // 
            // luepersonel
            // 
            this.luepersonel.Location = new System.Drawing.Point(138, 213);
            this.luepersonel.Name = "luepersonel";
            this.luepersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luepersonel.Properties.DisplayMember = "Ad";
            this.luepersonel.Properties.NullText = "Personel Listesi";
            this.luepersonel.Properties.ValueMember = "ID";
            this.luepersonel.Size = new System.Drawing.Size(207, 20);
            this.luepersonel.TabIndex = 30;
            // 
            // luecari
            // 
            this.luecari.Location = new System.Drawing.Point(138, 186);
            this.luecari.Name = "luecari";
            this.luecari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luecari.Properties.DisplayMember = "Ad";
            this.luecari.Properties.NullText = "Cari Listesi";
            this.luecari.Properties.ValueMember = "ID";
            this.luecari.Size = new System.Drawing.Size(207, 20);
            this.luecari.TabIndex = 29;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(9, 217);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 13);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "Personel :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 190);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 13);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Cari :";
            // 
            // txtvergidairesi
            // 
            this.txtvergidairesi.Location = new System.Drawing.Point(138, 161);
            this.txtvergidairesi.Name = "txtvergidairesi";
            this.txtvergidairesi.Size = new System.Drawing.Size(207, 20);
            this.txtvergidairesi.TabIndex = 25;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 165);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Vergi Dairesi :";
            // 
            // txtsaat
            // 
            this.txtsaat.Location = new System.Drawing.Point(138, 134);
            this.txtsaat.Name = "txtsaat";
            this.txtsaat.Size = new System.Drawing.Size(207, 21);
            this.txtsaat.TabIndex = 23;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 138);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Saat :";
            // 
            // txttarih
            // 
            this.txttarih.Location = new System.Drawing.Point(138, 109);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(207, 20);
            this.txttarih.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 113);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Tarih :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Seri :";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgfaturalistesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // dgfaturalistesi
            // 
            this.dgfaturalistesi.Location = new System.Drawing.Point(6, 14);
            this.dgfaturalistesi.MainView = this.gridView1;
            this.dgfaturalistesi.Name = "dgfaturalistesi";
            this.dgfaturalistesi.Size = new System.Drawing.Size(1511, 775);
            this.dgfaturalistesi.TabIndex = 12;
            this.dgfaturalistesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FrmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 861);
            this.Controls.Add(this.groupcontrol1);
            this.Controls.Add(this.dgfaturalistesi);
            this.Name = "FrmFaturaListesi";
            this.Text = "FrmFaturaListesi";
            this.Load += new System.EventHandler(this.FrmFaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtseri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfaturaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupcontrol1)).EndInit();
            this.groupcontrol1.ResumeLayout(false);
            this.groupcontrol1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luepersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luecari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvergidairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgfaturalistesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtseri;
        private System.Windows.Forms.TextBox txtsirano;
        private DevExpress.XtraEditors.TextEdit txtfaturaid;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupcontrol1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dgfaturalistesi;
        private System.Windows.Forms.TextBox txtsaat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txttarih;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtvergidairesi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit luepersonel;
        private DevExpress.XtraEditors.LookUpEdit luecari;
    }
}
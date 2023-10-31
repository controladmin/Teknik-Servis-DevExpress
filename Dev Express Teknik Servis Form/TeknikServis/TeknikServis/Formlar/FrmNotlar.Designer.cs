
namespace TeknikServis.Formlar
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.rtctadres = new DevExpress.XtraEditors.GroupControl();
            this.cbdurum = new System.Windows.Forms.CheckBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txticerik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtnotid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtbaslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgokunannotlistesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgokunmayannotlistesi = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txttarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rtctadres)).BeginInit();
            this.rtctadres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txticerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgokunannotlistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgokunmayannotlistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rtctadres
            // 
            this.rtctadres.Controls.Add(this.txttarih);
            this.rtctadres.Controls.Add(this.labelControl4);
            this.rtctadres.Controls.Add(this.cbdurum);
            this.rtctadres.Controls.Add(this.labelControl2);
            this.rtctadres.Controls.Add(this.txticerik);
            this.rtctadres.Controls.Add(this.labelControl3);
            this.rtctadres.Controls.Add(this.txtnotid);
            this.rtctadres.Controls.Add(this.labelControl7);
            this.rtctadres.Controls.Add(this.btnlistele);
            this.rtctadres.Controls.Add(this.btnsil);
            this.rtctadres.Controls.Add(this.btnguncelle);
            this.rtctadres.Controls.Add(this.btnkaydet);
            this.rtctadres.Controls.Add(this.txtbaslik);
            this.rtctadres.Controls.Add(this.labelControl1);
            this.rtctadres.Location = new System.Drawing.Point(1523, 36);
            this.rtctadres.Name = "rtctadres";
            this.rtctadres.Size = new System.Drawing.Size(355, 813);
            this.rtctadres.TabIndex = 19;
            this.rtctadres.Text = "AJANDA İŞLEMLERİ";
            // 
            // cbdurum
            // 
            this.cbdurum.AutoSize = true;
            this.cbdurum.Location = new System.Drawing.Point(138, 150);
            this.cbdurum.Name = "cbdurum";
            this.cbdurum.Size = new System.Drawing.Size(77, 17);
            this.cbdurum.TabIndex = 25;
            this.cbdurum.Text = "checkBox1";
            this.cbdurum.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 152);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Durum :";
            // 
            // txticerik
            // 
            this.txticerik.Location = new System.Drawing.Point(138, 83);
            this.txticerik.Name = "txticerik";
            this.txticerik.Size = new System.Drawing.Size(207, 20);
            this.txticerik.TabIndex = 23;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "İçerik :";
            // 
            // txtnotid
            // 
            this.txtnotid.Enabled = false;
            this.txtnotid.Location = new System.Drawing.Point(138, 31);
            this.txtnotid.Name = "txtnotid";
            this.txtnotid.Size = new System.Drawing.Size(207, 20);
            this.txtnotid.TabIndex = 18;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Not ID :";
            // 
            // btnlistele
            // 
            this.btnlistele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.ImageOptions.Image")));
            this.btnlistele.Location = new System.Drawing.Point(138, 306);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(207, 40);
            this.btnlistele.TabIndex = 16;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(138, 260);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(207, 40);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "SİL";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(138, 214);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(207, 40);
            this.btnguncelle.TabIndex = 14;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(138, 168);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(207, 40);
            this.btnkaydet.TabIndex = 13;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtbaslik
            // 
            this.txtbaslik.Location = new System.Drawing.Point(138, 57);
            this.txtbaslik.Name = "txtbaslik";
            this.txtbaslik.Size = new System.Drawing.Size(207, 20);
            this.txtbaslik.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Başlık :";
            // 
            // dgokunannotlistesi
            // 
            this.dgokunannotlistesi.Location = new System.Drawing.Point(6, 36);
            this.dgokunannotlistesi.MainView = this.gridView1;
            this.dgokunannotlistesi.Name = "dgokunannotlistesi";
            this.dgokunannotlistesi.Size = new System.Drawing.Size(1511, 387);
            this.dgokunannotlistesi.TabIndex = 18;
            this.dgokunannotlistesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgokunannotlistesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "OKUNAN NOTLAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "OKUNMAYAN NOTLAR";
            // 
            // dgokunmayannotlistesi
            // 
            this.dgokunmayannotlistesi.Location = new System.Drawing.Point(6, 462);
            this.dgokunmayannotlistesi.MainView = this.gridView2;
            this.dgokunmayannotlistesi.Name = "dgokunmayannotlistesi";
            this.dgokunmayannotlistesi.Size = new System.Drawing.Size(1511, 387);
            this.dgokunmayannotlistesi.TabIndex = 21;
            this.dgokunmayannotlistesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.dgokunmayannotlistesi;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // txttarih
            // 
            this.txttarih.Location = new System.Drawing.Point(138, 109);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(207, 20);
            this.txttarih.TabIndex = 27;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 113);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Tarih :";
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 861);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgokunmayannotlistesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtctadres);
            this.Controls.Add(this.dgokunannotlistesi);
            this.Name = "FrmNotlar";
            this.Text = "FrmNotlar";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rtctadres)).EndInit();
            this.rtctadres.ResumeLayout(false);
            this.rtctadres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txticerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgokunannotlistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgokunmayannotlistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl rtctadres;
        private DevExpress.XtraEditors.TextEdit txticerik;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtnotid;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.TextEdit txtbaslik;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgokunannotlistesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl dgokunmayannotlistesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.CheckBox cbdurum;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txttarih;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}

namespace TeknikServis.Formlar
{
    partial class FrmFaturaKalemleriPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalemleriPopUp));
            this.dgfaturakalem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.dgfaturabilgi = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnpdf = new DevExpress.XtraEditors.SimpleButton();
            this.btnexcell = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgfaturakalem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgfaturabilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgfaturakalem
            // 
            this.dgfaturakalem.Location = new System.Drawing.Point(3, 152);
            this.dgfaturakalem.MainView = this.gridView1;
            this.dgfaturakalem.Name = "dgfaturakalem";
            this.dgfaturakalem.Size = new System.Drawing.Size(1097, 510);
            this.dgfaturakalem.TabIndex = 13;
            this.dgfaturakalem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgfaturakalem;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Location = new System.Drawing.Point(1106, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(50, 31);
            this.btnclose.TabIndex = 14;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dgfaturabilgi
            // 
            this.dgfaturabilgi.Location = new System.Drawing.Point(3, 3);
            this.dgfaturabilgi.MainView = this.gridView2;
            this.dgfaturabilgi.Name = "dgfaturabilgi";
            this.dgfaturabilgi.Size = new System.Drawing.Size(1097, 143);
            this.dgfaturabilgi.TabIndex = 15;
            this.dgfaturabilgi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.dgfaturabilgi;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // btnpdf
            // 
            this.btnpdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnpdf.ImageOptions.Image")));
            this.btnpdf.Location = new System.Drawing.Point(1106, 40);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(50, 31);
            this.btnpdf.TabIndex = 16;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // btnexcell
            // 
            this.btnexcell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexcell.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexcell.ImageOptions.Image")));
            this.btnexcell.Location = new System.Drawing.Point(1106, 77);
            this.btnexcell.Name = "btnexcell";
            this.btnexcell.Size = new System.Drawing.Size(50, 31);
            this.btnexcell.TabIndex = 17;
            this.btnexcell.Click += new System.EventHandler(this.btnexcell_Click);
            // 
            // FrmFaturaKalemleriPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1159, 664);
            this.Controls.Add(this.btnexcell);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.dgfaturabilgi);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dgfaturakalem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmFaturaKalemleriPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFaturaKalemleriPopUp";
            this.Load += new System.EventHandler(this.FrmFaturaKalemleriPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgfaturakalem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgfaturabilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgfaturakalem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnclose;
        private DevExpress.XtraGrid.GridControl dgfaturabilgi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnpdf;
        private DevExpress.XtraEditors.SimpleButton btnexcell;
    }
}
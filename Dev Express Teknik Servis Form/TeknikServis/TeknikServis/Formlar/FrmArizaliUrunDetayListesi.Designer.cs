
namespace TeknikServis.Formlar
{
    partial class FrmArizaliUrunDetayListesi
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
            this.grdarizadetaylistesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdarizadetaylistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdarizadetaylistesi
            // 
            this.grdarizadetaylistesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdarizadetaylistesi.Location = new System.Drawing.Point(0, 0);
            this.grdarizadetaylistesi.MainView = this.gridView1;
            this.grdarizadetaylistesi.Name = "grdarizadetaylistesi";
            this.grdarizadetaylistesi.Size = new System.Drawing.Size(1884, 861);
            this.grdarizadetaylistesi.TabIndex = 14;
            this.grdarizadetaylistesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdarizadetaylistesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // FrmArizaliUrunDetayListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 861);
            this.Controls.Add(this.grdarizadetaylistesi);
            this.Name = "FrmArizaliUrunDetayListesi";
            this.Text = "FrmArizaliUrunDetayListesi";
            this.Load += new System.EventHandler(this.FrmArizaliUrunDetayListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdarizadetaylistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdarizadetaylistesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
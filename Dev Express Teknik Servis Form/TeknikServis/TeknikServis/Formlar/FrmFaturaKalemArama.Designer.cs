
namespace TeknikServis.Formlar
{
    partial class FrmFaturaKalemArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalemArama));
            this.dgfaturakalemarama = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtserino = new System.Windows.Forms.TextBox();
            this.btnarama = new DevExpress.XtraEditors.SimpleButton();
            this.txtsirano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfaturaid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgfaturakalemarama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgfaturakalemarama
            // 
            this.dgfaturakalemarama.Location = new System.Drawing.Point(12, 78);
            this.dgfaturakalemarama.MainView = this.gridView1;
            this.dgfaturakalemarama.Name = "dgfaturakalemarama";
            this.dgfaturakalemarama.Size = new System.Drawing.Size(1511, 775);
            this.dgfaturakalemarama.TabIndex = 15;
            this.dgfaturakalemarama.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgfaturakalemarama;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seri No :";
            // 
            // txtserino
            // 
            this.txtserino.Location = new System.Drawing.Point(89, 27);
            this.txtserino.Name = "txtserino";
            this.txtserino.Size = new System.Drawing.Size(229, 20);
            this.txtserino.TabIndex = 17;
            // 
            // btnarama
            // 
            this.btnarama.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnarama.Appearance.Options.UseBackColor = true;
            this.btnarama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnarama.ImageOptions.Image")));
            this.btnarama.Location = new System.Drawing.Point(1070, 18);
            this.btnarama.Name = "btnarama";
            this.btnarama.Size = new System.Drawing.Size(157, 38);
            this.btnarama.TabIndex = 18;
            this.btnarama.Text = "ARA";
            this.btnarama.Click += new System.EventHandler(this.btnarama_Click);
            // 
            // txtsirano
            // 
            this.txtsirano.Location = new System.Drawing.Point(425, 27);
            this.txtsirano.Name = "txtsirano";
            this.txtsirano.Size = new System.Drawing.Size(229, 20);
            this.txtsirano.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(347, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sıra No :";
            // 
            // txtfaturaid
            // 
            this.txtfaturaid.Location = new System.Drawing.Point(779, 27);
            this.txtfaturaid.Name = "txtfaturaid";
            this.txtfaturaid.Size = new System.Drawing.Size(229, 20);
            this.txtfaturaid.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(695, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fatura ID :";
            // 
            // FrmFaturaKalemArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 861);
            this.Controls.Add(this.txtfaturaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsirano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnarama);
            this.Controls.Add(this.txtserino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgfaturakalemarama);
            this.Name = "FrmFaturaKalemArama";
            this.Text = "FrmFaturaKalemArama";
            ((System.ComponentModel.ISupportInitialize)(this.dgfaturakalemarama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgfaturakalemarama;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtserino;
        private DevExpress.XtraEditors.SimpleButton btnarama;
        private System.Windows.Forms.TextBox txtsirano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfaturaid;
        private System.Windows.Forms.Label label3;
    }
}
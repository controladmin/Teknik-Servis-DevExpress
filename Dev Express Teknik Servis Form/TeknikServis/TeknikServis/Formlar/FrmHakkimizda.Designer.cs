
namespace TeknikServis.Formlar
{
    partial class FrmHakkimizda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHakkimizda));
            this.label1 = new System.Windows.Forms.Label();
            this.txthakkimizda = new System.Windows.Forms.RichTextBox();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HAKKIMIZDA";
            // 
            // txthakkimizda
            // 
            this.txthakkimizda.Location = new System.Drawing.Point(12, 57);
            this.txthakkimizda.Name = "txthakkimizda";
            this.txthakkimizda.Size = new System.Drawing.Size(776, 309);
            this.txthakkimizda.TabIndex = 1;
            this.txthakkimizda.Text = "";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnguncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnguncelle.Appearance.Options.UseBackColor = true;
            this.btnguncelle.Appearance.Options.UseFont = true;
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(178, 372);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(403, 47);
            this.btnguncelle.TabIndex = 95;
            this.btnguncelle.Text = "GÜNCELLE";
            // 
            // FrmHakkimizda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txthakkimizda);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmHakkimizda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHakkimizda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txthakkimizda;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
    }
}
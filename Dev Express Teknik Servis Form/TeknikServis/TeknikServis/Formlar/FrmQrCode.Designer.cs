
namespace TeknikServis.Formlar
{
    partial class FrmQrCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQrCode));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqrcode = new DevExpress.XtraEditors.TextEdit();
            this.btnqrolustur = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqrcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERİ NO İÇİN QR CODE OLUŞTURMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seri No :";
            // 
            // txtqrcode
            // 
            this.txtqrcode.Location = new System.Drawing.Point(100, 99);
            this.txtqrcode.Name = "txtqrcode";
            this.txtqrcode.Properties.BeepOnError = false;
            this.txtqrcode.Size = new System.Drawing.Size(162, 20);
            this.txtqrcode.TabIndex = 2;
            // 
            // btnqrolustur
            // 
            this.btnqrolustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnqrolustur.ImageOptions.Image")));
            this.btnqrolustur.Location = new System.Drawing.Point(100, 125);
            this.btnqrolustur.Name = "btnqrolustur";
            this.btnqrolustur.Size = new System.Drawing.Size(162, 48);
            this.btnqrolustur.TabIndex = 5;
            this.btnqrolustur.Text = "QR OLUŞTUR";
            this.btnqrolustur.Click += new System.EventHandler(this.btnqrolustur_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Location = new System.Drawing.Point(380, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(21, 22);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(75, 179);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(250, 250);
            this.pictureEdit1.TabIndex = 7;
            // 
            // FrmQrCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(404, 446);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnqrolustur);
            this.Controls.Add(this.txtqrcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmQrCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQrCode";
            this.Load += new System.EventHandler(this.FrmQrCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtqrcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtqrcode;
        private DevExpress.XtraEditors.SimpleButton btnqrolustur;
        private System.Windows.Forms.Button btnclose;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
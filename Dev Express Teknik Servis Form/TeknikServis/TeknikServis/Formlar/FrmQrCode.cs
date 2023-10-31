using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec; // QR Code oluşturmak için bu kütüphaneyi Nudget kısmından indirdik

namespace TeknikServis.Formlar
{
    public partial class FrmQrCode : Form
    {
        public FrmQrCode()
        {
            InitializeComponent();
        }

        private void FrmQrCode_Load(object sender, EventArgs e)
        {

        }

        private void btnqrolustur_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureEdit1.Image = enc.Encode(txtqrcode.Text);

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

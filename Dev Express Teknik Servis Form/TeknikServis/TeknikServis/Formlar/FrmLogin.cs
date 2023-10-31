using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TblAdmin where x.KullaniciAdi == txtka.Text && x.Sifre == txtsifre.Text select x;
            if (sorgu.Any())
            {
                FrmAnaSayfa frm = new FrmAnaSayfa();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}

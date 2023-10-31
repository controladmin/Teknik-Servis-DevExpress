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
    public partial class FrmArizaDetay : Form
    {
        public FrmArizaDetay()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            TblUrunTakip ut = new TblUrunTakip();
            if (string.IsNullOrEmpty(txttarih.Text)!=true)
            {
                ut.Aciklama = txtaciklama.Text;
                ut.Tarih = DateTime.Parse(txttarih.Text);
                ut.SeriNo = txtserino.Text;
                db.TblUrunTakip.Add(ut);
                db.SaveChanges();
                MessageBox.Show("Ürün Arıza Detayları Güncellendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tarih Alanı Boş Geçilemez", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }  
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string urunid,serino;

        private void btnurundurumdetay_Click(object sender, EventArgs e)
        {
            // UrunKabuldeki urun durum detay güncelleme
            TblUrunKabul uk = new TblUrunKabul();
            int id = int.Parse(urunid);
            var deger = db.TblUrunKabul.Find(id);
            deger.UrunDurumDetay = cburundurumdetay.Text;
            db.SaveChanges();
        }

        private void FrmArizaDetay_Load(object sender, EventArgs e)
        {
            txtserino.Text = serino;
        }
    }
}

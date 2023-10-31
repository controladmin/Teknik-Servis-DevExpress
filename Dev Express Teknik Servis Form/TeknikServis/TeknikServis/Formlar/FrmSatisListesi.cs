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
    public partial class FrmSatisListesi : Form
    {
        public FrmSatisListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void dgsatislistesi_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmSatisListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TblUrunHareket
                           select new
                           {
                               x.ID,
                               Urun = x.TblUrunler.UrunAd,
                               Musteri = x.TblCari.Ad + " " + x.TblCari.Soyad,
                               Personel = x.TblPersonel.Ad + " " + x.TblPersonel.Soyad,
                               x.Tarih,
                               x.Adet,
                               x.Fiyat,
                               x.UrunSeriNo
                           };
            dgsatislistesi.DataSource = degerler.ToList();
        }
    }
}

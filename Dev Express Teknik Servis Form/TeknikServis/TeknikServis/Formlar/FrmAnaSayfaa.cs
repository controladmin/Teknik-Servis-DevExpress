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
    public partial class FrmAnaSayfaa : Form
    {
        public FrmAnaSayfaa()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        DateTime bugun = DateTime.Today;
        void Listele()
        {
            grdkritikseviye.DataSource = (from x in db.TblUrunler
                                          select new
                                          {
                                              x.UrunAd,
                                              x.Stok
                                          }).Where(x => x.Stok < 20).ToList();

            grdfihrist.DataSource = (from y in db.TblCari
                                     select new
                                     {
                                         AdSoyad = y.Ad + " " + y.Soyad,
                                         y.Telefon,
                                         y.Cep,
                                         y.IL,
                                         y.Ilce,
                                         y.Adres
                                     }).ToList();

            grdkategoriurun.DataSource = db.UrunKategori().ToList(); // Store proceduru çağırdık

            var deger = (from t in db.TblNotlarım.OrderBy(x => x.Tarih)
                         where (t.Tarih == bugun)
                         select new
                         {
                             t.Baslik,
                             t.Icerik,
                             t.Durum,
                             t.Tarih
                         }).ToList();
            grdbugunyapilacak.DataSource = deger;        
        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}

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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            lbltoplamurunsayisi.Text = db.TblUrunler.Count().ToString();
            lbltoplamkategori.Text = db.TblKategori.Count().ToString();
            lbltoplamstok.Text = db.TblUrunler.Sum(x => x.Stok).ToString();
            lblenfazlastok.Text = (from u in db.TblUrunler orderby u.Stok descending select u.UrunAd).FirstOrDefault(); // en fazla stoğa göre sıraladık  ve ilk sıradakini aldık
            lblenazstok.Text = (from x in db.TblUrunler orderby x.Stok ascending select x.UrunAd).FirstOrDefault();
            lblenyuksekfiyatliurun.Text = (from y in db.TblUrunler orderby y.SatisFiyati descending select y.UrunAd).FirstOrDefault();
            lblendusukfiyatliurun.Text = (from z in db.TblUrunler orderby z.SatisFiyati ascending select z.UrunAd).FirstOrDefault();
            lblbeyazesyastok.Text = db.TblUrunler.Count(x => x.Kategori == 1).ToString();
            lblbilgisayarstok.Text = db.TblUrunler.Count(y => y.Kategori == 2).ToString();
            lblevaletleri.Text = db.TblUrunler.Count(z => z.Kategori == 3).ToString();
            lbltoplammarka.Text = (from m in db.TblUrunler select m.Marka).Distinct().Count().ToString();  // Buradan markayı secip Distinct diyerek tekrarsız olarak alıyoruz değeri
            lblarizaliurunsayisi.Text = db.TblUrunKabul.Count().ToString();
            lblenfazlaurunkategori.Text = db.maksimumkategoriurun().FirstOrDefault();
            
        }
    }
}

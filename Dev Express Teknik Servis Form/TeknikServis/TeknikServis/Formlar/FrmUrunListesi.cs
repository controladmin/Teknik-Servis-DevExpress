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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void Listele()
        {
            var degerler = from u in db.TblUrunler
                           select new
                           {
                               u.ID,
                               u.UrunAd,
                               u.Marka,
                               u.Stok,
                               Kategori = u.TblKategori.Ad,
                               u.AlisFiyati,
                               u.SatisFiyati
                           };
            grdurunlistesi.DataSource = degerler.ToList();
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {

            // Bu sorgu tüm listeyi getirir
            //var degerler = db.TblUrunler.ToList();
            //grdurunlistesi.DataSource = degerler;

            Listele();
            var nkategori = from k in db.TblKategori
                            select new
                            {
                                k.ID,
                                k.Ad
                            };
            lupkategori.Properties.DataSource = nkategori.ToList();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TblUrunler u = new TblUrunler();
            u.UrunAd = txturunadi.Text;
            u.Marka = txtmarka.Text;
            u.AlisFiyati =decimal.Parse(txtalisfiyati.Text);
            u.SatisFiyati =decimal.Parse(txtsatisfiyati.Text);
            u.Stok = short.Parse(txtstok.Text);
            u.Durum = false;
            u.Kategori = byte.Parse(lupkategori.EditValue.ToString());
            db.TblUrunler.Add(u);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Eklendi","Bilgi",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            //var degerler = db.TblUrunler.ToList();
            //grdurunlistesi.DataSource = degerler;
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txturunid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txturunadi.Text = gridView1.GetFocusedRowCellValue("UrunAd").ToString();
                txtmarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
                txtalisfiyati.Text = gridView1.GetFocusedRowCellValue("AlisFiyati").ToString();
                txtsatisfiyati.Text = gridView1.GetFocusedRowCellValue("SatisFiyati").ToString();
                txtstok.Text = gridView1.GetFocusedRowCellValue("Stok").ToString();
                lupkategori.Text = gridView1.GetFocusedRowCellValue("Kategori").ToString();
            }
            catch
            {
                MessageBox.Show("Hata");
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txturunid.Text);
            var deger = db.TblUrunler.Find(id);
            db.TblUrunler.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Sistemden Silindi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txturunid.Text);
            var deger = db.TblUrunler.Find(id);
            deger.UrunAd = txturunadi.Text;
            deger.Marka = txtmarka.Text;
            deger.AlisFiyati = decimal.Parse(txtalisfiyati.Text);
            deger.SatisFiyati = decimal.Parse(txtsatisfiyati.Text);
            deger.Stok = short.Parse(txtstok.Text);
            deger.Kategori = byte.Parse(lupkategori.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txturunid.Text = "";
            txturunadi.Text = "";
            txtmarka.Text = "";
            txtalisfiyati.Text = "";
            txtsatisfiyati.Text = "";
            txtstok.Text = "";
        }
    }
}

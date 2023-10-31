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
    public partial class FrmKategoriListesi : Form
    {
        public FrmKategoriListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void Listele()
        {
            var nkategorilistesi = from k in db.TblKategori
                                   select new
                                   {
                                       k.ID,
                                       k.Ad
                                   };
            grdkategorilistesi.DataSource = nkategorilistesi.ToList();
        }

        private void FrmKategoriListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtkategoriadi.Text != "" && txtkategoriadi.Text.Length <= 50)
            {
                TblKategori nk = new TblKategori();
                nk.Ad = txtkategoriadi.Text;
                db.TblKategori.Add(nk);
                db.SaveChanges();
                MessageBox.Show("Kategori Sisteme Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez Ve Kategori Adı 50 Karakterden Uzun Olamaz", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtkategoriid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtkategoriadi.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtkategoriid.Text);
            var deger = db.TblKategori.Find(id);
            db.TblKategori.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Sistemden Silindi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtkategoriid.Text);
            var deger = db.TblKategori.Find(id);
            deger.Ad = txtkategoriadi.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtkategoriadi.Text = "";
            txtkategoriid.Text = "";
        }
    }
}

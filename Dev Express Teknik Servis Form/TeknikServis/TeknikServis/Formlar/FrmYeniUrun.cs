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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btburunekle_Click(object sender, EventArgs e)
        {
            TblUrunler u = new TblUrunler();
            u.UrunAd = txturunadi.Text;
            u.Marka = txtmarka.Text;
            u.AlisFiyati = decimal.Parse(txtalisfiyati.Text);
            u.SatisFiyati = decimal.Parse(txtsatisfiyati.Text);
            //u.Kategori =byte.Parse(txtkategori.Text);
            u.Stok = short.Parse(txtstok.Text);
            u.Kategori = byte.Parse(lupkategori.EditValue.ToString());
            db.TblUrunler.Add(u);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {

            var nkategori = from k in db.TblKategori
                           select new
                           {
                               k.ID,
                               k.Ad
                           };
            lupkategori.Properties.DataSource = nkategori.ToList();
        }
    }
}

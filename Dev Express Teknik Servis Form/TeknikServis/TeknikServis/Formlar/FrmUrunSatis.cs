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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void Listele()

        {
            lueurunid.Properties.DataSource = (from x in db.TblUrunler
                                               select new
                                               {
                                                   x.ID,
                                                   x.UrunAd,
                                               }).ToList();

            luemusteri.Properties.DataSource = (from y in db.TblCari
                                                select new
                                                {
                                                    y.ID,
                                                    Ad = y.Ad + " " + y.Soyad
                                                }).ToList();

            luepersonel.Properties.DataSource = (from z in db.TblPersonel
                                                 select new
                                                 {
                                                     z.ID,
                                                     Ad = z.Ad + " " + z.Soyad
                                                 }).ToList();
        }
        private void btnsatisekle_Click(object sender, EventArgs e)
        {
            TblUrunHareket t = new TblUrunHareket();
            //t.Urun = int.Parse(txturunid.Text);
            t.Urun = int.Parse(lueurunid.EditValue.ToString());
            //t.Musteri = int.Parse(txtmusteri.Text);
            t.Musteri = int.Parse(luemusteri.EditValue.ToString());
            //t.Personel = short.Parse(txtpersonel.Text);
            t.Personel = short.Parse(luepersonel.EditValue.ToString());
            t.Tarih = DateTime.Parse(txttarih.Text);
            t.Adet = short.Parse(txtadet.Text);
            t.Fiyat = decimal.Parse(txtsatisfiyati.Text);
            t.UrunSeriNo = txtserino.Text;
            db.TblUrunHareket.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Gerçekleştirildi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void FrmUrunSatis_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

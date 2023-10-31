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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void Listele()
        {
            var degerler = from x in db.TblFaturaDetay
                           select new
                           {
                               x.ID,
                               x.Urun,
                               x.Adet,
                               x.Fiyat,
                               x.Tutar,
                               x.FaturaID
                           };
            dgfaturadetaylistesi.DataSource = degerler.ToList();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TblFaturaDetay d = new TblFaturaDetay();
            d.Urun = txturun.Text;
            d.Adet=short.Parse(txtadet.Text);
            d.Fiyat = decimal.Parse(txtfiyat.Text);
            d.Tutar = decimal.Parse(txttutar.Text);
            d.FaturaID = int.Parse(txtfaturaid.Text);
            db.TblFaturaDetay.Add(d);
            db.SaveChanges();
            MessageBox.Show("Fatura Detay Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtfaturaid.Text);
            var deger = db.TblFaturaDetay.Find(id);
            db.TblFaturaDetay.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Detay Silindi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtfaturaid.Text);
            var deger = db.TblFaturaDetay.Find(id);
            deger.Urun = txturun.Text;
            deger.Adet = short.Parse(txtadet.Text);
            deger.Fiyat = decimal.Parse(txtfiyat.Text);
            deger.Tutar = decimal.Parse(txttutar.Text);
            deger.FaturaID = int.Parse(txtfaturaid.Text);
            db.SaveChanges();
            MessageBox.Show("Fatura Detay Güncellendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}

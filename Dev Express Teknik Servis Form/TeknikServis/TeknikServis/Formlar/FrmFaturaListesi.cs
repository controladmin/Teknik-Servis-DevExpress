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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void CariListesi()
        {
            luecari.Properties.DataSource = (from x in db.TblCari
                                             select new
                                             {
                                                 x.ID,
                                                 Ad=x.Ad+" "+x.Soyad
                                             }).ToList();
        }
        void PersonelListesi()
        {
            luepersonel.Properties.DataSource = (from y in db.TblPersonel
                                                 select new
                                                 {
                                                     y.ID,
                                                     Ad= y.Ad+" "+y.Soyad
                                                 }).ToList();
        }
        void FaturaListesi()
        {
            var degerler = from z in db.TblFaturaBilgi
                           select new
                           {
                               z.ID,
                               z.Seri,
                               z.SiraNo,
                               z.Tarih,
                               z.Saat,
                               z.VergiDairesi,
                               Cari = z.TblCari.Ad + " " + z.TblCari.Soyad,
                               Personel = z.TblPersonel.Ad + " " + z.TblPersonel.Soyad
                           };
            dgfaturalistesi.DataSource = degerler.ToList();
        }
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            FaturaListesi();
            CariListesi();
            PersonelListesi();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            FaturaListesi();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TblFaturaBilgi f = new TblFaturaBilgi();
            f.Seri = txtseri.Text;
            f.SiraNo = txtsirano.Text;
            f.Tarih = DateTime.Parse(txttarih.Text);
            f.Saat = txtsaat.Text;
            f.VergiDairesi = txtvergidairesi.Text;
            f.Cari = short.Parse(luecari.EditValue.ToString());
            f.Personel = short.Parse(luepersonel.EditValue.ToString());
            db.TblFaturaBilgi.Add(f);
            db.SaveChanges();
            MessageBox.Show("Fatura Bilgisi Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtfaturaid.Text);
            var deger = db.TblFaturaBilgi.Find(id);
            deger.Seri = txtseri.Text;
            deger.SiraNo = txtsirano.Text;
            deger.Tarih = DateTime.Parse(txttarih.Text);
            deger.Saat = txtsaat.Text;
            deger.VergiDairesi = txtvergidairesi.Text;
            deger.Cari = int.Parse(luecari.EditValue.ToString());
            deger.Personel = short.Parse(luepersonel.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtfaturaid.Text);
            var deger = db.TblFaturaBilgi.Find(id);
            db.TblFaturaBilgi.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Bilgisi Silindi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtfaturaid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtseri.Text = gridView1.GetFocusedRowCellValue("Seri").ToString();
            txtsirano.Text = gridView1.GetFocusedRowCellValue("SiraNo").ToString();
            txttarih.Text = gridView1.GetFocusedRowCellValue("Tarih").ToString();
            txtsaat.Text = gridView1.GetFocusedRowCellValue("Saat").ToString();
            txtvergidairesi.Text = gridView1.GetFocusedRowCellValue("VergiDairesi").ToString();
        }

      
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemleriPopUp frm = new FrmFaturaKalemleriPopUp();
            frm.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            frm.Show();
        }
    }
}

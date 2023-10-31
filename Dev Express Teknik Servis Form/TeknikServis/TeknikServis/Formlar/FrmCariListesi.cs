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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void Listele()
        {
            var degerler = from u in db.TblCari
                           select new
                           {
                               u.ID,
                               u.Ad,
                               u.Soyad,
                               u.IL,
                               u.Ilce,
                               u.Adres,
                               u.Telefon,
                               u.Mail,
                               u.Banka,
                               u.VergiDairesi,
                               u.VergiNo,
                               u.Statu
                           };
            grdcarilistesi.DataSource = degerler.ToList();
        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtcariid.Text);
            var deger = db.TblCari.Find(id);
            db.TblCari.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Cari Sistemden Silindi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtcariid.Text);
            var deger = db.TblCari.Find(id);
            deger.Ad = txtcariadi.Text;
            deger.Soyad = txtcarisoyadi.Text;
            deger.IL = lucariil.EditValue.ToString();
            deger.Ilce = lucariilce.EditValue.ToString();
            deger.Adres = rtctadres.Text;
            deger.Banka = txtbanka.Text;
            deger.VergiDairesi = txtcarivergidairesi.Text;
            deger.Statu = txtstatuu.Text;
            deger.VergiNo = txtvergino.Text;
            deger.Telefon = txtcaritelefon.Text;
            deger.Mail = txtcarimail.Text;
            db.SaveChanges();
            MessageBox.Show("Cari Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TblCari c = new TblCari();
            c.Ad = txtcariadi.Text;
            c.Soyad = txtcarisoyadi.Text;
            c.IL = lucariil.EditValue.ToString();
            c.Ilce = lucariilce.EditValue.ToString();
            c.Adres = txtcariadres.Text;
            c.Banka = txtbanka.Text;
            c.VergiDairesi = txtcarivergidairesi.Text;
            c.Statu = txtstatu.Text;
            c.VergiNo = txtvergino.Text;
            c.Telefon = txtcaritelefon.Text;
            c.Mail = txtcarimail.Text;
            db.TblCari.Add(c);
            db.SaveChanges();
            MessageBox.Show("Cari Sisteme Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtcariid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtcariadi.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtcarisoyadi.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            lucariil.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            lucariilce.Text = gridView1.GetFocusedRowCellValue("Ilce").ToString();
            rtctadres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            txtbanka.Text = gridView1.GetFocusedRowCellValue("Banka").ToString();
            txtcarivergidairesi.Text = gridView1.GetFocusedRowCellValue("VergiDairesi").ToString();
            txtstatuu.Text = gridView1.GetFocusedRowCellValue("Statu").ToString();
            txtvergino.Text = gridView1.GetFocusedRowCellValue("VergiNo)").ToString();
            txtcaritelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtcarimail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
        }
    }
}

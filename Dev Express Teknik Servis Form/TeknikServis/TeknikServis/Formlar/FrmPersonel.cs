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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
       

        void Listele()
        {
            var degerler = from x in db.TblPersonel
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               Departman=x.TblDepartman.Ad,
                               x.Mail,
                               x.Telefon,
                               x.CepTelefonu,
                               x.Adres
                           };
            dgpersonellistesi.DataSource = degerler.ToList();
            string Ad1, Soyad1, Ad2, Soyad2, Ad3, Soyad3, Ad4, Soyad4;
            Ad1 = db.TblPersonel.First(x => x.ID == 1).Ad;
            Soyad1 = db.TblPersonel.First(y => y.ID == 1).Soyad;
            lbladsoyad1.Text = Ad1 +" "+ Soyad1;
            lblmail1.Text = db.TblPersonel.First(z => z.ID == 1).Mail;
            lbldepartman1.Text = db.TblPersonel.First(u => u.ID == 1).TblDepartman.Ad;

            Ad2 = db.TblPersonel.First(x => x.ID == 2).Ad;
            Soyad2 = db.TblPersonel.First(y => y.ID == 2).Soyad;
            lbladsoyad2.Text = Ad2 + " " + Soyad2;
            lblmail2.Text = db.TblPersonel.First(z => z.ID == 2).Mail;
            lbldepartman2.Text = db.TblPersonel.First(u => u.ID == 2).TblDepartman.Ad;

            Ad3 = db.TblPersonel.First(x => x.ID == 3).Ad;
            Soyad3 = db.TblPersonel.First(y => y.ID == 3).Soyad;
            lbladsoyad3.Text = Ad3 + " " + Soyad3;
            lblmail3.Text = db.TblPersonel.First(z => z.ID == 3).Mail;
            lbldepartman3.Text = db.TblPersonel.First(u => u.ID == 3).TblDepartman.Ad;

            Ad4 = db.TblPersonel.First(x => x.ID == 4).Ad;
            Soyad4 = db.TblPersonel.First(y => y.ID == 4).Soyad;
            lbladsoyad4.Text = Ad4 + " " + Soyad4;
            lblmail4.Text = db.TblPersonel.First(z => z.ID == 4).Mail;
            lbldepartman4.Text = db.TblPersonel.First(u => u.ID == 4).TblDepartman.Ad;


            luedepartman.Properties.DataSource = (from t in db.TblDepartman
                                                  select new
                                                  {
                                                      t.ID,
                                                      t.Ad
                                                  }).ToList();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TblPersonel p = new TblPersonel();
            p.Ad = txtpersonelad.Text;
            p.Soyad = txtpersonelsoyad.Text;
            p.Mail = txtmail.Text;
            p.Telefon = txttelefon.Text;
            p.CepTelefonu = txtceptelefonu.Text;
            p.Adres = txtadres.Text;
            p.Departman = byte.Parse(luedepartman.EditValue.ToString());
            p.Fotograf = txtfotograf.Text;
            db.TblPersonel.Add(p);
            db.SaveChanges();
            MessageBox.Show("Personel Sisteme Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtpersonelid.Text);
            var deger = db.TblPersonel.Find(id);
            deger.Ad = txtpersonelad.Text;
            deger.Soyad = txtpersonelsoyad.Text;
            deger.Mail = txtmail.Text;
            deger.Telefon = txttelefon.Text;
            deger.CepTelefonu = txtceptelefonu.Text;
            deger.Adres = txtadres.Text;
            deger.Departman = byte.Parse(luedepartman.EditValue.ToString());
            deger.Fotograf = txtfotograf.Text;
            db.SaveChanges();
            MessageBox.Show("Personel Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtpersonelid.Text);
           var deger= db.TblPersonel.Find(id);
            db.TblPersonel.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtpersonelid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtpersonelad.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
                txtpersonelsoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
                txtmail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
                txttelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
                txtceptelefonu.Text = gridView1.GetFocusedRowCellValue("CepTelefonu").ToString();
                txtadres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
                txtfotograf.Text = gridView1.GetFocusedRowCellValue("Fotograf").ToString();
            }
            catch
            {
                MessageBox.Show("Hata", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}

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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void btncariekle_Click(object sender, EventArgs e)
        {
            TblCari c = new TblCari();
            c.Ad = txtcariadi.Text;
            c.Soyad = txtcarisoyadi.Text;
            c.IL = txtcariil.Text;
            c.Ilce = txtcariilce.Text;
            c.Adres = txtcariadres.Text;
            c.Banka = txtcaribanka.Text;
            c.VergiDairesi = txtcarivergidairesi.Text;
            c.Statu = txtcaristatu.Text;
            c.VergiNo = txtcarivergino.Text;
            c.Telefon = txtcaritelefon.Text;
            c.Mail = txtcarimail.Text;
            db.TblCari.Add(c);
            db.SaveChanges();
            MessageBox.Show("Cari Sisteme Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}

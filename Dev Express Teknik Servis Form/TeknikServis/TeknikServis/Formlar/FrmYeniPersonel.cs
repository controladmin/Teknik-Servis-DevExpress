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
    public partial class FrmYeniPersonel : Form
    {
        public FrmYeniPersonel()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btburunekle_Click(object sender, EventArgs e)
        {
            TblPersonel p = new TblPersonel();
            p.Ad = txtad.Text;
            p.Soyad = txtsoyad.Text;
            p.Mail = txtmail.Text;
            p.Telefon = txttelefon.Text;
            p.CepTelefonu = txtceptelefonu.Text;
            p.Adres = txtadres.Text;
            p.Departman = byte.Parse(lupdepartman.EditValue.ToString());
            p.Fotograf = txtfotograf.Text;
            db.TblPersonel.Add(p);
            db.SaveChanges();
            MessageBox.Show("Personel Sisteme Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void FrmYeniPersonel_Load(object sender, EventArgs e)
        {
            lupdepartman.Properties.DataSource = (from x in db.TblDepartman
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.Ad
                                                  }).ToString();
        }
    }
}

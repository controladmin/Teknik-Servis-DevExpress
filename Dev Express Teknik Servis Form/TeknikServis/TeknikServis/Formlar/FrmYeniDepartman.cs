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
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }

        private void FrmYeniDepartman_Load(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void btndepartmanekle_Click(object sender, EventArgs e)
        {
            TblDepartman d = new TblDepartman();
            if (txtdepartmanadi.Text.Length <= 50 && txtdepartmanadi.Text != null && txtaciklama.Text.Length >= 1)
            {
                d.Ad = txtdepartmanadi.Text;
                d.Aciklama = txtaciklama.Text;
                db.TblDepartman.Add(d);
                db.SaveChanges();
                MessageBox.Show("Departman Sisteme Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}

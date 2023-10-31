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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
      
        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkategoriekle_Click(object sender, EventArgs e)
        {
            if (txtkategoriadi.Text != "" && txtkategoriadi.Text.Length <= 50)
            {
                TblKategori k = new TblKategori();
                k.Ad = txtkategoriadi.Text;
                db.TblKategori.Add(k);
                db.SaveChanges();
                MessageBox.Show("Yeni Kategori Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve Kategori Adı 50 Karakterden Uzun Olamaz", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}

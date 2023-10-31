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
    public partial class FrmDepartmanListesi : Form
    {
        public FrmDepartmanListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void Listele()
        {
            var degerler = from d in db.TblDepartman
                           select new
                           {
                               d.ID,
                               d.Ad,
                               d.Aciklama
                           };
            dgdepartmanlistesi.DataSource = degerler.ToList();
        }
        private void FrmDepartmanListesi_Load(object sender, EventArgs e)
        {
            Listele();
            lbltoplmadepartman.Text = db.TblDepartman.Count().ToString();
            llbltoplampersonel.Text = db.TblPersonel.Count().ToString();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
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

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtdepartmanid.Text);
            var deger = db.TblDepartman.Find(id);
            db.TblDepartman.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Sisteme Silindi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtdepartmanid.Text);
            var deger = db.TblDepartman.Find(id);
            deger.Ad = txtdepartmanadi.Text;
            deger.Aciklama = txtaciklama.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Güncellendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtdepartmanadi.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtaciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
        }
    }
}

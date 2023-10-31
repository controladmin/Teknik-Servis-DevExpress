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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void OkunanListesi()
        {
            var degerler = from x in db.TblNotlarım.Where(y => y.Durum == true)
                           select new
                           {
                               x.ID,
                               x.Baslik,
                               x.Icerik,
                               x.Durum
                           };
            dgokunannotlistesi.DataSource = degerler.ToList();
        }

        void OkunmayanListesi()
        {
            var degerler = from x in db.TblNotlarım.Where(y => y.Durum == false)
                           select new
                           {
                               x.ID,
                               x.Baslik,
                               x.Icerik,
                               x.Durum
                           };
            dgokunmayannotlistesi.DataSource = degerler.ToList();
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            OkunanListesi();
            OkunmayanListesi();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TblNotlarım n = new TblNotlarım();
            n.Baslik = txtbaslik.Text;
            n.Icerik = txticerik.Text;
            n.Durum = false;
            n.Tarih =DateTime.Parse(txttarih.Text);
            db.TblNotlarım.Add(n);
            db.SaveChanges();
            MessageBox.Show("Not Sisteme Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtnotid.Text);
            var deger = db.TblNotlarım.Find(id);
            deger.Baslik = txtbaslik.Text;
            deger.Icerik = txticerik.Text;
            deger.Durum = true;
            deger.Tarih = DateTime.Parse(txttarih.Text);
            db.SaveChanges();
            OkunanListesi();
            OkunmayanListesi();
            MessageBox.Show("Seçili Not Güncellendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            if (cbdurum.Checked == true)
            {
                int id = int.Parse(txtnotid.Text);
                var deger = db.TblNotlarım.Find(id);
                db.TblNotlarım.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Seçili Not Silindi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not Okundu Durumu Seçilmedi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            OkunanListesi();
            OkunmayanListesi();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtnotid.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
            txtbaslik.Text = gridView2.GetFocusedRowCellValue("Baslik").ToString();
            txticerik.Text = gridView2.GetFocusedRowCellValue("Icerik").ToString();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //txtnotid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            //txtbaslik.Text = gridView1.GetFocusedRowCellValue("Baslik").ToString();
            //txticerik.Text = gridView1.GetFocusedRowCellValue("Icerik").ToString();
        }
    }
}

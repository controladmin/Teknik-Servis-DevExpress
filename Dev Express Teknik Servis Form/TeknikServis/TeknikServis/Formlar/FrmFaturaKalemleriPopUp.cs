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
    public partial class FrmFaturaKalemleriPopUp : Form
    {
        public FrmFaturaKalemleriPopUp()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        public int id;
        private void FrmFaturaKalemleriPopUp_Load(object sender, EventArgs e)
        {
            dgfaturakalem.DataSource = (from x in db.TblFaturaDetay
                                        select new
                                        {
                                            x.ID,
                                            x.Urun,
                                            x.Adet,
                                            x.Fiyat,
                                            x.Tutar,
                                            x.FaturaID
                                        }).Where(y => y.FaturaID == id).ToList();

            dgfaturabilgi.DataSource= (from z in db.TblFaturaBilgi
                                       select new
                                       {
                                           z.ID,
                                           z.Seri,
                                           z.SiraNo,
                                           z.Tarih,
                                           z.Saat,
                                           z.VergiDairesi,
                                           CariAdSoyad=z.TblCari.Ad+" "+z.TblCari.Soyad,
                                           PerosnelAdSoyad=z.TblPersonel.Ad+" "+z.TblPersonel.Soyad
                                       }).Where(t => t.ID == id).ToList();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.pdf";  // Bin debug içine kaydediyor
            dgfaturakalem.ExportToPdf(path);
            
        }

        private void btnexcell_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.xls"; // Bin debug içine atıyor
            dgfaturakalem.ExportToXls(path);
        }
    }
}

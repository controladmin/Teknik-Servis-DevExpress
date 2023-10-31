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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
         void Listele()
        {
            luemusteri.Properties.DataSource = (from y in db.TblCari
                                                select new
                                                {
                                                    y.ID,
                                                    Ad = y.Ad + " " + y.Soyad
                                                }).ToList();

            luepersonel.Properties.DataSource = (from z in db.TblPersonel
                                                 select new
                                                 {
                                                     z.ID,
                                                     Ad = z.Ad + " " + z.Soyad
                                                 }).ToList();
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TblUrunKabul uk = new TblUrunKabul();
            uk.Cari = int.Parse(luemusteri.EditValue.ToString());
            uk.Personel = short.Parse(luepersonel.EditValue.ToString());
            uk.GelisTarihi = DateTime.Parse(txttarih.Text);
            uk.UrunSeriNo = txtserino.Text;
            uk.UrunDurumDetay = "Ürün Kaydı Yapıldı";
            db.TblUrunKabul.Add(uk);
            db.SaveChanges();
            MessageBox.Show("Arızalı Ürün Kaydı Yapıldı", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void txttarih_Click(object sender, EventArgs e)
        {
            txttarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}

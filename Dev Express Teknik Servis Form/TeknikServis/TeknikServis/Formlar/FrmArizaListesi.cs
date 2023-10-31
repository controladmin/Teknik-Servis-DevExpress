using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServis.Formlar
{
    public partial class FrmArizaliUrunListesi : Form
    {
        public FrmArizaliUrunListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B34VKQ7\SQLEXPRESS01;Initial Catalog=TeknikServis;Integrated Security=True");
        void Listele()
        {
            var degerler = from x in db.TblUrunKabul
                           select new
                           {
                               x.ID,
                               Cari = x.TblCari.Ad +" "+ x.TblCari.Soyad,
                               Personel = x.TblPersonel.Ad +" "+ x.TblPersonel.Soyad,
                               x.GelisTarihi,
                               x.CikisTarihi,
                               x.UrunSeriNo
                           };
            grdarizalistesi.DataSource = degerler.ToList();
        }

        private void FrmArizaliUrunListesi_Load(object sender, EventArgs e)
        {
            Listele();
            lblarizaliurunsayisi.Text = db.TblUrunKabul.Count(x=>x.Durum==true).ToString(); // true tamiri devam eden
            lbltamiribitmisurunsayisi.Text = db.TblUrunKabul.Count(y => y.Durum == false).ToString(); // false tamiri bitmiş olan
            lblmesajbeklenen.Text = db.TblUrunler.Count().ToString();
            lblparcabekleyen.Text = db.TblUrunKabul.Count(t => t.UrunDurumDetay == "Parça Bekliyor").ToString();
            lblmesajbeklenen.Text = db.TblUrunKabul.Count(z => z.UrunDurumDetay == "Mesaj Bekleniyor").ToString();
            lbliptaledilen.Text= lblmesajbeklenen.Text = db.TblUrunKabul.Count(k => k.UrunDurumDetay == "İptal Bekleniyor").ToString();


            con.Open();
            SqlCommand cmd = new SqlCommand("select UrunDurumDetay,count(*) from TblUrunKabul group by UrunDurumDetay", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            con.Close();
            // Chart Kontrol Veri Ekleme
            // Form ekranında chart seçilir series seçilir sağ sayfada propertie seçilir legandtextPatern kısmına {A} yazılır chartta sağ taraftaki ifadelerde marka isimleri çıkıyor
            // PaletName den chart renkleri değiştirebilir
            //

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetay fr = new FrmArizaDetay();
            fr.urunid = gridView1.GetFocusedRowCellValue("ID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("UrunSeriNo").ToString();
            fr.Show();
        }
    }
}

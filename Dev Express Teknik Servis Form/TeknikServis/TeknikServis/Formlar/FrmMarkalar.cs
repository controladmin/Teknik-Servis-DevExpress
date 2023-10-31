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
    public partial class Frmmarkaistatisikleri : Form
    {
        public Frmmarkaistatisikleri()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B34VKQ7\SQLEXPRESS01;Initial Catalog=TeknikServis;Integrated Security=True");
        void Listele()
        {
            var degerler = db.TblUrunler.OrderBy(x => x.Marka).GroupBy(y => y.Marka).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            grdmarkalistesi.DataSource = degerler.ToList();
        }

      
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            Listele();
            lbltoplammarka.Text = (from x in db.TblUrunler select x.Marka).Distinct().Count().ToString();
            lbltoplamurunsayisi.Text = db.TblUrunler.Count().ToString();
            lblenyuksekfiyatmarka.Text = (from y in db.TblUrunler orderby y.SatisFiyati descending select y.Marka).FirstOrDefault();
            lblenfazlaurunumarka.Text = db.maksimumurunmarka().FirstOrDefault();

            con.Open();
            SqlCommand cmd= new SqlCommand("select  Marka,count(*) from TblUrunler group by Marka", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            con.Close();
            // Chart Kontrol Veri Ekleme
            // Form ekranında chart seçilir series seçilir sağ sayfada propertie seçilir legandtextPatern kısmına {A} yazılır chartta sağ taraftaki ifadelerde marka isimleri çıkıyor
            // PaletName den chart renkleri değiştirebilir
            //

            // 2. Chart veri çekme

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select k.Ad,count(*)from TblUrunler u inner join TblKategori k on k.ID=u.Kategori group by k.Ad", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                chartControl2.Series["Kategoriler"].Points.AddPoint(Convert.ToString(dr1[0]), int.Parse(dr1[1].ToString()));
            }
            con.Close();
        }
    }
}

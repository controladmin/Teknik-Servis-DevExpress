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
    public partial class FrmCariIller : Form
    {
        public FrmCariIller()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-B34VKQ7\SQLEXPRESS01;Initial Catalog=TeknikServis;Integrated Security=True");

        void Listele()
        {
            var degereler = db.TblCari.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new { İl = z.Key, Toplam = z.Count() }).ToList();
            grdcarillistesi.DataSource = degereler;
        }
        private void FrmCariIller_Load(object sender, EventArgs e)
        {
            Listele();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IL,count(*) from TblCari group by IL",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint( Convert.ToString(read[0]), int.Parse(read[1].ToString()));
            }
            baglanti.Close();
        }
    }
}

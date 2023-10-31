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
    public partial class FrmFaturaKalemArama : Form
    {
        public FrmFaturaKalemArama()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void Listele()
        {
            int id = Convert.ToInt32(txtfaturaid.Text);
            var degerler = (from x in db.TblFaturaDetay
                            select new
                            {
                                x.ID,
                                x.Urun,
                                x.Adet,
                                x.Fiyat,
                                x.Tutar,
                                x.FaturaID
                            }).Where(y => y.FaturaID == id);
            dgfaturakalemarama.DataSource = degerler.ToList();
        }
        private void btnarama_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}

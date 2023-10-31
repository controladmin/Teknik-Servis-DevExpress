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
    public partial class FrmArizaliUrunDetayListesi : Form
    {
        public FrmArizaliUrunDetayListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArizaliUrunDetayListesi_Load(object sender, EventArgs e)
        {
            grdarizadetaylistesi.DataSource = (from x in db.TblUrunTakip
                                               select new
                                               {
                                                   x.ID,
                                                   x.Aciklama,
                                                   x.Tarih,
                                                   x.SeriNo
                                               }).ToList();
        }
    }
}

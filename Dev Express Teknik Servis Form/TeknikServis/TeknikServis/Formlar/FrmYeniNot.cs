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
    public partial class FrmYeniNot : Form
    {
        public FrmYeniNot()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
     
        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnotekle_Click(object sender, EventArgs e)
        {
            TblNotlarım n = new TblNotlarım();
            n.Baslik = txtbaslik.Text;
            n.Icerik = txticerik.Text;
            n.Durum = false;
            db.TblNotlarım.Add(n);
            db.SaveChanges();
            MessageBox.Show("Not Sisteme Eklendi", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}

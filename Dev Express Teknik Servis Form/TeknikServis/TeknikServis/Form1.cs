using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        Formlar.FrmUrunListesi frmurunlistesi;
        private void btnurunlistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmurunlistesi == null || frmurunlistesi.IsDisposed)
            {
                frmurunlistesi= new Formlar.FrmUrunListesi();
                frmurunlistesi.MdiParent = this;
                frmurunlistesi.Show();
            }
        }

        private void btnyeniurun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniUrun frm = new Formlar.FrmYeniUrun();
            frm.Show();
        }

        Formlar.FrmKategoriListesi frmkategorilistesi;
        private void btnkategorilistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmkategorilistesi == null || frmkategorilistesi.IsDisposed)
            {

                frmkategorilistesi = new Formlar.FrmKategoriListesi();
                frmkategorilistesi.MdiParent = this;
                frmkategorilistesi.Show();
            }
        }

        
        private void btnyenikategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                Formlar.FrmYeniKategori frm = new Formlar.FrmYeniKategori();
                frm.Show();
        }

        Formlar.FrmIstatistik frmistatistik;
        private void btnurunistatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmistatistik == null || frmistatistik.IsDisposed)
            {
                frmistatistik = new Formlar.FrmIstatistik();
                frmistatistik.MdiParent = this;
                frmistatistik.Show();
            }
        }

        Formlar.Frmmarkaistatisikleri frmmarkaistatisikleri;
        private void btnmarkaistatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmmarkaistatisikleri == null || frmmarkaistatisikleri.IsDisposed)
            {
                frmmarkaistatisikleri = new Formlar.Frmmarkaistatisikleri();
                frmmarkaistatisikleri.MdiParent = this;
                frmmarkaistatisikleri.Show();
            }
        }

        Formlar.FrmCariListesi frmcarilistesi;
        private void btncarilistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmcarilistesi == null || frmcarilistesi.IsDisposed)
            {
                frmcarilistesi = new Formlar.FrmCariListesi();
                frmcarilistesi.MdiParent = this;
                frmcarilistesi.Show();
            }
        }

        Formlar.FrmCariIller frmcariiller;
        private void btncariilistatistigi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmcarilistesi == null || frmcarilistesi.IsDisposed)
            {
                frmcariiller = new Formlar.FrmCariIller();
                frmcariiller.MdiParent = this;
                frmcariiller.Show();
            }
        }

        private void btnyenicari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariEkle frm = new Formlar.FrmCariEkle();
            frm.Show();
        }
        Formlar.FrmAnaSayfaa fr;
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            if(fr==null||fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfaa();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        Formlar.FrmDepartmanListesi frmdepartmanlistesi;
        private void btndepartmanlistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmdepartmanlistesi == null || frmdepartmanlistesi.IsDisposed)
            {
                frmdepartmanlistesi = new Formlar.FrmDepartmanListesi();
                frmdepartmanlistesi.MdiParent = this;
                frmdepartmanlistesi.Show();
            }
        }

        private void btnyenidepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniDepartman frm = new Formlar.FrmYeniDepartman();
            frm.Show();
        }

        Formlar.FrmPersonel frmpersonellistesi;
        private void btnperosnellistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmpersonellistesi == null || frmpersonellistesi.IsDisposed)
            {
                frmpersonellistesi = new Formlar.FrmPersonel();
                frmpersonellistesi.MdiParent = this;
                frmpersonellistesi.Show();
            }
        }

        private void btnyenipersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniPersonel frm = new Formlar.FrmYeniPersonel();
            frm.Show();
        }

        private void btnhesapmakinasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btndovizkurlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKurlar frm = new Formlar.FrmKurlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void btnajanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmNotlar frm= new Formlar.FrmNotlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnyeninot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniNot frm = new Formlar.FrmYeniNot();
            frm.Show();
        }

        Formlar.FrmArizaliUrunListesi frmarizaliurunlistesi;
        private void btnarizaliurunlistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmarizaliurunlistesi ==null || frmarizaliurunlistesi.IsDisposed)
            {
                frmarizaliurunlistesi = new Formlar.FrmArizaliUrunListesi();
                frmarizaliurunlistesi.MdiParent = this;
                frmarizaliurunlistesi.Show();
            }
        }

        private void btnyeniurunsatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunSatis frm = new Formlar.FrmUrunSatis();
            frm.Show();
        }

        Formlar.FrmSatisListesi frmsatislistesi;
        private void btnsatislistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmsatislistesi == null || frmsatislistesi.IsDisposed)
            {
                frmsatislistesi = new Formlar.FrmSatisListesi();
                frmsatislistesi.MdiParent = this;
                frmsatislistesi.Show();
            }
        }

        private void btnqrkodolustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmQrCode frm = new Formlar.FrmQrCode();
            frm.Show();
        }

        Formlar.FrmFaturaListesi frmfaturalistesi;
        private void btnfaturalistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmfaturalistesi == null || frmfaturalistesi.IsDisposed)
            {
                frmfaturalistesi = new Formlar.FrmFaturaListesi();
                frmfaturalistesi.MdiParent = this;
                frmfaturalistesi.Show();
            }
        }

        Formlar.FrmFaturaKalem frmfaturakalem;
        private void btnfaturakalemgirisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmfaturakalem == null || frmfaturakalem.IsDisposed)
            {
                frmfaturakalem = new Formlar.FrmFaturaKalem();
                frmfaturakalem.MdiParent = this;
                frmfaturakalem.Show();
            }
        }

        Formlar.FrmFaturaKalemArama frmfaturakalemarama;
        private void btndetaylifaturasorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmfaturakalemarama == null || frmfaturakalemarama.IsDisposed)
            {
                frmfaturakalemarama = new Formlar.FrmFaturaKalemArama();
                frmfaturakalemarama.MdiParent = this;
                frmfaturakalemarama.Show();
            }
        }

        private void btnarizaliurunkaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaliUrunKaydi frm = new Formlar.FrmArizaliUrunKaydi();
            frm.Show();
        }

        private void btnarizaliurunaciklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaDetay frm = new Formlar.FrmArizaDetay();
            frm.Show();
        }

        Formlar.FrmArizaliUrunDetayListesi frmarizaliurundetaylistesi;
        private void btnarizaliurundetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmarizaliurundetaylistesi == null || frmarizaliurundetaylistesi.IsDisposed)
            {
                frmarizaliurundetaylistesi = new Formlar.FrmArizaliUrunDetayListesi();
                frmarizaliurundetaylistesi.MdiParent = this;
                frmarizaliurundetaylistesi.Show();
            }
        }

        Formlar.FrmHarita frmharita;
        private void btnharita_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmharita == null || frmharita.IsDisposed)
            {
                frmharita = new Formlar.FrmHarita();
                frmharita.MdiParent = this;
                frmharita.Show();
            }
        }

        private void btnraporsihirbazi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmRapor frm = new Formlar.FrmRapor();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void btnanasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null ||fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfaa();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}

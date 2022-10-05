using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Is_projesi.Entity;

namespace Is_projesi.Formlar
{
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        DbisTakibEntities db= new DbisTakibEntities();
        void Personeller()
        {

            var degerler = from x in db.C_TblPersonel
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.Email,
                               x.Telefon,
                               Departament=x.TblDepartmanlar.Ad,
                               x.Durum
                           };
            gridControl1.DataSource = degerler.Where(x => x.Durum == true). ToList();

        }
        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            Personeller();
            Departmanlar();

        }

        private void Departmanlar()
        {
            var departmanlar = (from x in db.TblDepartmanlar
                                select new
                                {
                                    x.ID,
                                    x.Ad

                                }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Ad";

            lookUpEdit1.Properties.DataSource = departmanlar;
        }

        private void ListeleBt_Click(object sender, EventArgs e)
        {
            Personeller();
        }

        private void ElaveEtBt_Click(object sender, EventArgs e)
        {
            TblPersonel t = new TblPersonel();
            t.Ad = TxtAd.Text;
            t.Soyad = TxtSoyad.Text; 
            t.Email= TxtEmail.Text;
            t.Telefon= TxtTelefon.Text;
            t.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            t.Durum = true;
            db.C_TblPersonel.Add(t);
            db.SaveChanges();
            MessageBox.Show(" Yeni isci Elave edildi", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            Personeller();
        }

        private void SilBt_Click(object sender, EventArgs e)
        {
            var x = int.Parse(TxtiD.Text);
            var deger = db.C_TblPersonel.Find(x);
            deger.Durum = false;
            db.SaveChanges();
           MessageBox.Show("Departman  basarili sekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Personeller();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            string departamentAd = gridView1.GetFocusedRowCellValue("Departament").ToString();

            TxtiD.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TxtEmail.Text = gridView1.GetFocusedRowCellValue("Email").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Departament").ToString();
        }

        private void GuncellemeBt_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtiD.Text);
            var deger = db.C_TblPersonel.Find(x);
            deger.Ad = TxtAd.Text;
            deger.Soyad= TxtSoyad.Text;
            deger.Email = TxtEmail.Text;
            deger.Telefon=TxtTelefon.Text;
            deger.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Departman  basarili sekilde Deyisdirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Personeller();
        }
    }
}

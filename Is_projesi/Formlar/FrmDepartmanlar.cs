using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Is_projesi.Entity;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Is_projesi.Formlar
{
    public partial class Departmanlar : Form
    {
        public readonly SqlConnection baglaa = new SqlConnection(@"Server=WIN-SAARC92B7A3\SSQL;Database=Dbis;Trusted_Connection=True;");
        public Departmanlar()
        {
            InitializeComponent();
        }
        //Crud--Create read update delete isdifade edecem
        DbisTakibEntities db = new DbisTakibEntities();

        private void Listele()
        {
            var degerler = (from x in db.TblDepartmanlar
                            select new
                            {
                                x.ID,
                                x.Ad
                            }).ToList();
            gridControl1.DataSource = degerler;

        }

        private void Listele_Click_1(object sender, EventArgs e)
        {
            Listele();
        }


     
        private void SilBt_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtiD.Text);
            var deger=db.TblDepartmanlar.Find(x);
            db.TblDepartmanlar.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman  basarili sekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtiD.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void GuncellemeBt_Click(object sender, EventArgs e)
        {
            //if(!)
            int x = int.Parse(TxtiD.Text);
            var deger = db.TblDepartmanlar.Find(x);
            deger.Ad = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Departman  basarili sekilde guncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }

        private void ElaveEtBt_Click(object sender, EventArgs e)
        {
            TblDepartmanlar t=new TblDepartmanlar();
            t.Ad=TxtAd.Text;
            db.TblDepartmanlar.Add(t);
            db.SaveChanges();
            MessageBox.Show("Departmanlar listeye qeyd edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        
    }
}

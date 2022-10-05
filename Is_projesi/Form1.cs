using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Is_projesi
{
    public partial class btnDepartamentListesi : Form
    {
        public btnDepartamentListesi()
        {
            InitializeComponent();
        }

        private void DepartamentSehifesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Departmanlar frm = new Formlar.Departmanlar();
            frm.MdiParent= this;
            frm.Show();
        }

        private void PrIscilerinMelumatlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersoneller frm2 = new Formlar.FrmPersoneller();
            frm2.MdiParent = this;
            frm2.Show();
        }
    }
}

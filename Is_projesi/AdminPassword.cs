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

namespace Is_projesi
{
    public partial class AdminPassword : Form
    {
        public AdminPassword()
        {
            InitializeComponent();
        }

      

        private void AdminPassword_Load(object sender, EventArgs e)
        {
            Usernametxt.Focus();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            DialogResult iExit;
            iExit = MessageBox.Show("You want to hang out in the safe", "Loqin System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=WIN-SAARC92B7A3\SSQL;Initial Catalog=AdminParol;Integrated Security=True");
            string query = $@"Select * from Adminparoltb where username='{Usernametxt.Text}'";
            SqlDataAdapter com = new SqlDataAdapter(query, baglanti);
            DataTable dt = new DataTable();
            com.Fill(dt);
          //  Usernametxt.Text = PasswordManager.GetPasswordHash("Elcan001");
           //  return;
            if (dt.Rows.Count == 1 && PasswordManager.Verify(Paswordtxt.Text, (string)dt.Rows[0][1]))
            {
                btnDepartamentListesi frm = new btnDepartamentListesi();
                frm.Show();
                frm.BackColor = Color.CadetBlue;
                Hide();
            }
            else
            {
                MessageBox.Show("username and Password error ", "Loqin System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

        }
    }
}

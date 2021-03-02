using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace yurtkayitsistemi
{
    public partial class frmgiderguncelle : Form
    {
        public frmgiderguncelle()
        {
            InitializeComponent();
        }

        public string id,elektrik, su, dogalgaz, gida,internet, diger, personel;

        private void frmgiderguncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmgiderlistesi fr = new frmgiderlistesi();

            fr.Show();

        }

        private void btnguncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update giderler set elektrik=@p2,su=@p3,dogalgaz=@p4,internet=@p5,gida=@p6,personel=@p7,diger=@p8 where odemeid=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtgiderid.Text);
            komut.Parameters.AddWithValue("@p2", txtelektrik.Text);
            komut.Parameters.AddWithValue("@p3", txtsu.Text);
            komut.Parameters.AddWithValue("@p4", txtdogalgaz.Text);
            komut.Parameters.AddWithValue("@p5", txtinternet.Text);
            komut.Parameters.AddWithValue("@p6", txtgida.Text);
            komut.Parameters.AddWithValue("@p7", txtpersonel.Text);
            komut.Parameters.AddWithValue("@p8", txtdiger.Text);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("basarili sekilde guncellendi... ");
            
        }

        sqlbaglantim bgl = new sqlbaglantim();


        private void btnguncelle_Click(object sender, EventArgs e)
        {
           

        }

        private void frmgiderguncelle_Load(object sender, EventArgs e)
        {

            txtgiderid.Text = id;
            txtelektrik.Text = elektrik;
            txtsu.Text = su;
            txtdogalgaz.Text = dogalgaz;
            txtgida.Text = gida;
            txtpersonel.Text = personel;
            txtdiger.Text = diger;
            txtinternet.Text = internet;
        }
    }
}

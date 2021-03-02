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
    public partial class frmgider : Form
    {
        public frmgider()
        {
            InitializeComponent();
        }

        sqlbaglantim baglan = new sqlbaglantim();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into giderler(elektrik,su,dogalgaz,internet,gida,personel,diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglan.baglanti()) ;

            komut.Parameters.AddWithValue("@p1",txtelektrik.Text);
            komut.Parameters.AddWithValue("@p2", txtsu.Text);
            komut.Parameters.AddWithValue("@p3", txtdogalgaz.Text);
            komut.Parameters.AddWithValue("@p4", txtinternet.Text);
            komut.Parameters.AddWithValue("@p5", txtgida.Text);
            komut.Parameters.AddWithValue("@p6", txtpersonel.Text);
            komut.Parameters.AddWithValue("@p7", txtdiger.Text);

            komut.ExecuteNonQuery();
            baglan.baglanti().Close();

            MessageBox.Show("giderler kaydedildi...");

        }
    }
}

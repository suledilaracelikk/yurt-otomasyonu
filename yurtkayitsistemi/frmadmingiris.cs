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

namespace yurtkayitsistemi
{
    public partial class frmadmingiris : Form
    {
        public frmadmingiris()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        sqlbaglantim bgl = new sqlbaglantim();

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from admin where yoneticiad=@p1 and yoneticisifre=@p2 ",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",txtkullaniciad.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);

            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                frmanasayfa fr = new frmanasayfa();
                fr.Show();
                this.Hide(); 

            }

            else
            {
                MessageBox.Show("hatali giris yaptiniz....");
                txtkullaniciad.Clear();
                txtsifre.Clear();
            }

            bgl.baglanti().Close();


        }
    }
}

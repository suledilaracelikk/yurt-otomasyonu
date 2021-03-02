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
    public partial class frmgeliristatistik : Form
    {
        public frmgeliristatistik()
        {
            InitializeComponent();
        }
        sqlbaglantim bgl = new sqlbaglantim();
        private void frmgeliristatistik_Load(object sender, EventArgs e)
        {

            //kasadaki toplam odeme miktari

            SqlCommand komut = new SqlCommand("select sum(odememiktar) from kasa ", bgl.baglanti()) ;

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                lblpara.Text = oku[0].ToString()+" TL";
            }

            bgl.baglanti().Close();


            //tekrarsiz olarak aylari listeleme

            SqlCommand komut1 = new SqlCommand("select distinct (odemeay) from kasa ", bgl.baglanti());

            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                cmbay.Items.Add(oku1[0].ToString());
            }

            bgl.baglanti().Close();


            //grafiklere veri tabanindan veri cekme

            SqlCommand komut9 = new SqlCommand("select odemeay,sum(odememiktar) from kasa group by odemeay",bgl.baglanti());

            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                this.chart1.Series["Aylik"].Points.AddXY(oku9[0],oku9[1]);
            }



            bgl.baglanti().Close();






        }

        private void cmbay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblay.Text = cmbay.SelectedItem.ToString();
        }
    }
}

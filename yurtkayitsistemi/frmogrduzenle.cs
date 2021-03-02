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
    public partial class frmogrduzenle : Form
    {
        public frmogrduzenle()
        {
            InitializeComponent();
        }


        public string id,ad,soyad,tc,telefon,dogum,bolum,mail,odano,veliadsoyad,velitelefon,veliadres;

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut6 = new SqlCommand("delete from ogrenci where ogrid=@p1",baglantim.baglanti());

            komut6.Parameters.AddWithValue("@p1",txtogrid.Text);
            komut6.ExecuteNonQuery();
            baglantim.baglanti().Close();
            MessageBox.Show("basariyla silindi...");


            //oda kontenjani artırma

            SqlCommand komut8 = new SqlCommand("update odalar set odaaktif=odaaktif-1 where odano=@p1",baglantim.baglanti());

            komut8.Parameters.AddWithValue("@p1",cmbogrodano.Text);

            komut8.ExecuteNonQuery();
            baglantim.baglanti().Close();




        }

        sqlbaglantim baglantim = new sqlbaglantim();

        public void guncelle()
        {
            SqlCommand komut = new SqlCommand("update ogrenci set ograd=@p1,ogrsoyad=@p2,ogrtc=@p3,ogrtelefon=@p4,ogrdogum=@p5,ogrbolum=@p6,ogrmail=@p7,ogrodano=@p8,ogrveliadsoyad=@p9,ogrvelitelefon=@p10,ogrveliadres=@p11 where ogrid='" + txtogrid.Text + "'", baglantim.baglanti());

            komut.Parameters.AddWithValue("@p1", txtograd.Text);
            komut.Parameters.AddWithValue("@p2", txtogrsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskogrtc.Text);
            komut.Parameters.AddWithValue("@p4", mskogrtelefon.Text);
            komut.Parameters.AddWithValue("@p5", mskogrdogum.Text);
            komut.Parameters.AddWithValue("@p6", cmbogrbolum.Text);
            komut.Parameters.AddWithValue("@p7", txtogrmail.Text);
            komut.Parameters.AddWithValue("@p8", cmbogrodano.Text);
            komut.Parameters.AddWithValue("@p9", txtveliadsoyad.Text);
            komut.Parameters.AddWithValue("@p10", mskvelitelefon.Text);
            komut.Parameters.AddWithValue("@p11", rtbogradres.Text);

            komut.ExecuteNonQuery();
            baglantim.baglanti().Close();
            MessageBox.Show("ogrenci basariyla guncellendi...");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            guncelle();

        }

        public void frmogrduzenle_Load(object sender, EventArgs e)
        {

            txtogrid.Text = id;
            txtograd.Text = ad;
            txtogrsoyad.Text = soyad;
            mskogrtc.Text = tc;
            mskogrtelefon.Text = telefon;
            mskogrdogum.Text = dogum;
            cmbogrbolum.Text = bolum;
            txtogrmail.Text = mail;
            cmbogrodano.Text = odano;
            txtveliadsoyad.Text = veliadsoyad;
            mskvelitelefon.Text = velitelefon;
            rtbogradres.Text = veliadres;
        }
    }
}

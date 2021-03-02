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
using System.Data.Sql;

namespace yurtkayitsistemi
{
    public partial class frmogrencikayit : Form
    {
        public frmogrencikayit()
        {
            InitializeComponent();
        }

        sqlbaglantim bgl = new sqlbaglantim();


        private void frmogrencikayit_Load(object sender, EventArgs e)
        {

            //bolumleri listedik

            

            SqlCommand komut = new SqlCommand("select bolumad from bolumler", bgl.baglanti());

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                cmbogrbolum.Items.Add(oku[0].ToString());
            }

            bgl.baglanti().Close();





            //bos odalari listeledik
          

            SqlCommand komut1 = new SqlCommand("select odano from odalar where odaaktif<odakapasite ",bgl.baglanti());

            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                cmbogrodano.Items.Add(oku1[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {


            //ogrenci bilglerinin sisteme kayıt edilmesi

            try
            {

                SqlCommand komut = new SqlCommand("insert into ogrenci(ograd,ogrsoyad,ogrtc,ogrtelefon,ogrdogum,ogrbolum,ogrmail,ogrodano,ogrveliadsoyad,ogrvelitelefon,ogrveliadres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());

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
                bgl.baglanti().Close();

                MessageBox.Show("ogrenci basariyla kaydedildi...");
            }
            catch (Exception)
            {
                MessageBox.Show("hata!!!");
            }




            //ogrenci id yi label12 ye cekme

            try
            {
                SqlCommand komut2 = new SqlCommand("select ogrid from ogrenci",bgl.baglanti());

                SqlDataReader oku = komut2.ExecuteReader();

                while (oku.Read())
                {

                    label12.Text = oku[0].ToString();

                }

                bgl.baglanti().Close();

            }

            catch (Exception r)
            {

                MessageBox.Show(r.ToString());
                
            }


            //ogrenci borc alani olusturma

            try
            {

                SqlCommand komut1 = new SqlCommand("insert into borclar(ogrid,ograd,ogrsoyad) values(@b1,@b2,@b3)",bgl.baglanti());

                komut1.Parameters.AddWithValue("@b1",label12.Text);
                komut1.Parameters.AddWithValue("@b2",txtograd.Text);
                komut1.Parameters.AddWithValue("@b3",txtogrsoyad.Text);

                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();

            }
            catch (Exception)
            {

                MessageBox.Show("hata...");
            }


            //ogrenci oda kontenjani azaltma

            SqlCommand komut5 = new SqlCommand("update odalar set odaaktif=odaaktif+1 where odano=@p1",bgl.baglanti());

            komut5.Parameters.AddWithValue("@p1",cmbogrodano.Text);
            komut5.ExecuteNonQuery();

            bgl.baglanti().Close();

        }
    }
}

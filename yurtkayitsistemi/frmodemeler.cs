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
    public partial class frmodemeler : Form
    {
        public frmodemeler()
        {
            InitializeComponent();
        }

        private void frmodemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtotomasyonuDataSet.borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtotomasyonuDataSet.borclar);
            // TODO: Bu kod satırı 'yurtotomasyonuDataSet.ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtotomasyonuDataSet.ogrenci);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalanborc;

            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalanborc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtid.Text = id;
            txtad.Text = ad;
            txtsoyad.Text = soyad;
            txtkalanborc.Text = kalanborc;

        }

        private void btnodemeal_Click(object sender, EventArgs e)
        {
            //kalan borctan odenini cikarma

            int odenen, kalan, yeniborc;

            odenen = Convert.ToInt32(txtodenen.Text);
            kalan = Convert.ToInt32(txtkalanborc.Text);
            yeniborc = kalan - odenen;
            txtkalanborc.Text = yeniborc.ToString();

            //yeni tutarı veri tabanına kaydetme

            sqlbaglantim x = new sqlbaglantim();

            SqlCommand komut = new SqlCommand("update borclar set ogrkalanborc=@p1 where ogrid=@p2",x.baglanti());

            komut.Parameters.AddWithValue("@p1",txtkalanborc.Text);
            komut.Parameters.AddWithValue("@p2",txtid.Text);

            komut.ExecuteNonQuery();
            x.baglanti().Close();

            MessageBox.Show("borc odendi...");
            this.borclarTableAdapter.Fill(this.yurtotomasyonuDataSet.borclar);


            //kasa tablosuna ekleme yapma 

            SqlCommand komut3 = new SqlCommand("insert into kasa(odemeay,odememiktar) values (@p1,@p2)",x.baglanti());

            komut3.Parameters.AddWithValue("@p1",txtodenenay.Text);
            komut3.Parameters.AddWithValue("@p2",txtodenen.Text);

            komut3.ExecuteNonQuery();
            x.baglanti().Close();

        }
    }
}

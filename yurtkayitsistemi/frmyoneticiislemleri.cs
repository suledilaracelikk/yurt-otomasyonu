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
    public partial class frmyoneticiislemleri : Form
    {
        public frmyoneticiislemleri()
        {
            InitializeComponent();
        }

        private void frmyoneticiislemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtotomasyonuDataSet.admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtotomasyonuDataSet.admin);

        }

        sqlbaglantim bgl = new sqlbaglantim();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into admin(yoneticiad,yoneticisifre) values (@p1,@p2)",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",txtkullaniciad.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("yonetici basariyla eklendi...");

            this.adminTableAdapter.Fill(this.yurtotomasyonuDataSet.admin);

        }

        int secilen;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtkullaniciad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtyoneticiid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("delete admin where yoneticiid=@p1",bgl.baglanti());

            komut4.Parameters.AddWithValue("@p1",txtyoneticiid.Text);
            komut4.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("basariyla silindi...");

            this.adminTableAdapter.Fill(this.yurtotomasyonuDataSet.admin);

            txtkullaniciad.Clear();
            txtsifre.Clear();
            txtyoneticiid.Clear();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update admin set yoneticiad=@p1,yoneticisifre=@p2 where yoneticiid=@p3 ",bgl.baglanti());

            komut2.Parameters.AddWithValue("@p1",txtkullaniciad.Text);
            komut2.Parameters.AddWithValue("@p2",txtsifre.Text);
            komut2.Parameters.AddWithValue("@p3", txtyoneticiid.Text);

            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("basariyla guncellendi...");

            this.adminTableAdapter.Fill(this.yurtotomasyonuDataSet.admin);

            txtkullaniciad.Clear();
            txtsifre.Clear();
            txtyoneticiid.Clear();

        }
    }
}

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
    public partial class frmpersonel : Form
    {
        public frmpersonel()
        {
            InitializeComponent();
        }

        private void frmpersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtotomasyonuDataSet.personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtotomasyonuDataSet.personel);

        }

        sqlbaglantim bgl = new sqlbaglantim();

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into personel(personeladsoyad,personeldepartman) values(@p1,@p2)",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2",txtpersonelgorev.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("personel basariyla kaydedildi..");
            this.personelTableAdapter.Fill(this.yurtotomasyonuDataSet.personel);
            txtpersonelid.Clear();
            txtpersonelad.Clear();
            txtpersonelgorev.Clear();
            txtpersonelad.Focus();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete personel where personelid=@p1",bgl.baglanti());

            komut2.Parameters.AddWithValue("@p1",txtpersonelid.Text);

            komut2.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("personel basariyla silindi...");
            this.personelTableAdapter.Fill(this.yurtotomasyonuDataSet.personel);

           
            txtpersonelid.Clear();
            txtpersonelad.Clear();
            txtpersonelgorev.Clear();
            txtpersonelad.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;

            secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtpersonelad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtpersonelgorev.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtpersonelid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update personel set personeladsoyad=@p1,personeldepartman=@p2 where personelid=@p3 ",bgl.baglanti());

            komut.Parameters.AddWithValue("@p3",txtpersonelid.Text);
            komut.Parameters.AddWithValue("@p1",txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2",txtpersonelgorev.Text);

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("personel basariyla guncellendi...");
            this.personelTableAdapter.Fill(this.yurtotomasyonuDataSet.personel);

            txtpersonelid.Clear();
            txtpersonelad.Clear();
            txtpersonelgorev.Clear();
        }
    }
}

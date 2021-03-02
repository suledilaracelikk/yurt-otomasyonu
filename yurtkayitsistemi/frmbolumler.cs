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
    public partial class frmbolumler : Form
    {
        public frmbolumler()
        {
            InitializeComponent();
        }

        sqlbaglantim bgl = new sqlbaglantim();

        private void frmbolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtotomasyonuDataSet1.bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter1.Fill(this.yurtotomasyonuDataSet1.bolumler);
            // TODO: Bu kod satırı 'yurtotomasyonuDataSet.bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtotomasyonuDataSet.bolumler);
            // TODO: Bu kod satırı 'yurtotomasyonuDataSet.admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtotomasyonuDataSet.admin);

        }

        private void pcbbolumekle_Click(object sender, EventArgs e)
        {
            try
            {
              

                SqlCommand komut = new SqlCommand("insert into bolumler(bolumad) values(@p1)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txtbolumad.Text);

                komut.ExecuteNonQuery();

                bgl.baglanti().Close();

                MessageBox.Show("bolum basariyla eklendi...");
                this.bolumlerTableAdapter1.Fill(this.yurtotomasyonuDataSet1.bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("hata olustu...");
            }

        }
        
        private void pcbbolumsil_Click(object sender, EventArgs e)
        {

            try
            {
                

                SqlCommand komut = new SqlCommand("delete from bolumler where bolumad='" + txtbolumad.Text + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                MessageBox.Show("bolum silindi...");
                this.bolumlerTableAdapter1.Fill(this.yurtotomasyonuDataSet1.bolumler);

                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("hata..");
            }
        }

        private void pcbbolumduzenle_Click(object sender, EventArgs e)
        {

            try
            {
            

                SqlCommand komut= new SqlCommand("update bolumler set bolumad=@p1 where bolumid=@p2 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1",txtbolumad.Text);
                komut.Parameters.AddWithValue("@p2",dataGridView1.Rows[secilen].Cells[0].Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("bolum guncellendi..");
                this.bolumlerTableAdapter1.Fill(this.yurtotomasyonuDataSet1.bolumler);

                bgl.baglanti().Close();

            }
            catch (Exception)
            {
                MessageBox.Show("hata...");
            }
        }

        int secilen;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtbolumad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }
    }
}

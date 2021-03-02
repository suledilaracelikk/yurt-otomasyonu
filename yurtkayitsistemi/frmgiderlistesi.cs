using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurtkayitsistemi
{
    public partial class frmgiderlistesi : Form
    {
        public frmgiderlistesi()
        {
            InitializeComponent();
        }

        private void frmgiderlistesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtotomasyonuDataSet.giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.yurtotomasyonuDataSet.giderler);
        

        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmgiderguncelle fr = new frmgiderguncelle();

            secilen = dataGridView1.SelectedCells[0].RowIndex;

            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.gida = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            this.Hide();
            fr.Show();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

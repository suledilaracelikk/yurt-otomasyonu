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
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU PROGRAM SULE DILARA CELIK TARAFINDAN 2 MART 2021 TARIHINDE YAZILMISTIR... ","OGRENCI YURT OTOMASYONU",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void frmanasayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtotomasyonuDataSet.ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtotomasyonuDataSet.ogrenci);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmogrencikayit fr = new frmogrencikayit();
            fr.Show();
        }

        private void ogrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmogrliste fr = new frmogrliste();
            fr.Show();
        }

        private void ogrenciDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmogrduzenle fr = new frmogrduzenle();
            fr.Show();  
        }

        private void bolumEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbolumler fr = new frmbolumler();
            fr.Show();
        }

        private void bolumDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbolumler fr = new frmbolumler();
            fr.Show();
        }

        private void odemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmodemeler fr = new frmodemeler();
            fr.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgider fr = new frmgider();
            fr.Show();
        }

        private void giderİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgiderlistesi fr = new frmgiderlistesi();
            fr.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgeliristatistik fr = new frmgeliristatistik();
            fr.Show();
        }

        private void sifreİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmyoneticiislemleri fr = new frmyoneticiislemleri();
            fr.Show();
        }

        private void personelDuzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpersonel fr = new frmpersonel();
            fr.Show();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnotekle fr = new frmnotekle();
            fr.Show();
        }

        private void cikisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

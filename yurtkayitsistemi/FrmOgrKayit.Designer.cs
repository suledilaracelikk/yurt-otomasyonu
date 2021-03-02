
namespace yurtkayitsistemi
{
    partial class frmogrencikayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmogrencikayit));
            this.label1 = new System.Windows.Forms.Label();
            this.txtograd = new System.Windows.Forms.TextBox();
            this.txtogrsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskogrtc = new System.Windows.Forms.MaskedTextBox();
            this.mskogrtelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskogrdogum = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbogrbolum = new System.Windows.Forms.ComboBox();
            this.txtogrmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbogrodano = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtveliadsoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskvelitelefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rtbogradres = new System.Windows.Forms.RichTextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ogrenci Ad:";
            // 
            // txtograd
            // 
            this.txtograd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtograd.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtograd.Location = new System.Drawing.Point(185, 5);
            this.txtograd.Name = "txtograd";
            this.txtograd.Size = new System.Drawing.Size(248, 35);
            this.txtograd.TabIndex = 1;
            // 
            // txtogrsoyad
            // 
            this.txtogrsoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtogrsoyad.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtogrsoyad.Location = new System.Drawing.Point(185, 46);
            this.txtogrsoyad.Name = "txtogrsoyad";
            this.txtogrsoyad.Size = new System.Drawing.Size(248, 35);
            this.txtogrsoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ogrenci Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(133, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC:";
            // 
            // mskogrtc
            // 
            this.mskogrtc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mskogrtc.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskogrtc.Location = new System.Drawing.Point(185, 87);
            this.mskogrtc.Mask = "00000000000";
            this.mskogrtc.Name = "mskogrtc";
            this.mskogrtc.Size = new System.Drawing.Size(248, 35);
            this.mskogrtc.TabIndex = 5;
            // 
            // mskogrtelefon
            // 
            this.mskogrtelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mskogrtelefon.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskogrtelefon.Location = new System.Drawing.Point(185, 128);
            this.mskogrtelefon.Mask = "(999) 000-0000";
            this.mskogrtelefon.Name = "mskogrtelefon";
            this.mskogrtelefon.Size = new System.Drawing.Size(248, 35);
            this.mskogrtelefon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(73, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // mskogrdogum
            // 
            this.mskogrdogum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mskogrdogum.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskogrdogum.Location = new System.Drawing.Point(185, 169);
            this.mskogrdogum.Mask = "00/00/0000";
            this.mskogrdogum.Name = "mskogrdogum";
            this.mskogrdogum.Size = new System.Drawing.Size(248, 35);
            this.mskogrdogum.TabIndex = 9;
            this.mskogrdogum.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(13, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dogum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ogrenci Bolum:";
            // 
            // cmbogrbolum
            // 
            this.cmbogrbolum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbogrbolum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbogrbolum.FormattingEnabled = true;
            this.cmbogrbolum.Location = new System.Drawing.Point(185, 210);
            this.cmbogrbolum.Name = "cmbogrbolum";
            this.cmbogrbolum.Size = new System.Drawing.Size(248, 33);
            this.cmbogrbolum.TabIndex = 11;
            // 
            // txtogrmail
            // 
            this.txtogrmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtogrmail.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtogrmail.Location = new System.Drawing.Point(185, 249);
            this.txtogrmail.Name = "txtogrmail";
            this.txtogrmail.Size = new System.Drawing.Size(248, 35);
            this.txtogrmail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(109, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mail:";
            // 
            // cmbogrodano
            // 
            this.cmbogrodano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbogrodano.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbogrodano.FormattingEnabled = true;
            this.cmbogrodano.Location = new System.Drawing.Point(185, 290);
            this.cmbogrodano.Name = "cmbogrodano";
            this.cmbogrodano.Size = new System.Drawing.Size(248, 33);
            this.cmbogrodano.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(85, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Oda No:";
            // 
            // txtveliadsoyad
            // 
            this.txtveliadsoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtveliadsoyad.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtveliadsoyad.Location = new System.Drawing.Point(185, 329);
            this.txtveliadsoyad.Name = "txtveliadsoyad";
            this.txtveliadsoyad.Size = new System.Drawing.Size(248, 35);
            this.txtveliadsoyad.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Veli Ad Soyad:";
            // 
            // mskvelitelefon
            // 
            this.mskvelitelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mskvelitelefon.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskvelitelefon.Location = new System.Drawing.Point(185, 370);
            this.mskvelitelefon.Mask = "(999) 000-0000";
            this.mskvelitelefon.Name = "mskvelitelefon";
            this.mskvelitelefon.Size = new System.Drawing.Size(248, 35);
            this.mskvelitelefon.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(13, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Veli Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(97, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Adres:";
            // 
            // rtbogradres
            // 
            this.rtbogradres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rtbogradres.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbogradres.Location = new System.Drawing.Point(185, 416);
            this.rtbogradres.Name = "rtbogradres";
            this.rtbogradres.Size = new System.Drawing.Size(248, 57);
            this.rtbogradres.TabIndex = 21;
            this.rtbogradres.Text = "";
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Yellow;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkaydet.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.ForeColor = System.Drawing.Color.Red;
            this.btnkaydet.Location = new System.Drawing.Point(242, 491);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(134, 43);
            this.btnkaydet.TabIndex = 22;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "label12";
            // 
            // frmogrencikayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(449, 546);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.rtbogradres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskvelitelefon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtveliadsoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbogrodano);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtogrmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbogrbolum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskogrdogum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskogrtelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskogrtc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtogrsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtograd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmogrencikayit";
            this.Text = "Ogrenci Kayit";
            this.Load += new System.EventHandler(this.frmogrencikayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtograd;
        private System.Windows.Forms.TextBox txtogrsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskogrtc;
        private System.Windows.Forms.MaskedTextBox mskogrtelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskogrdogum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbogrbolum;
        private System.Windows.Forms.TextBox txtogrmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbogrodano;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtveliadsoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskvelitelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtbogradres;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label12;
    }
}


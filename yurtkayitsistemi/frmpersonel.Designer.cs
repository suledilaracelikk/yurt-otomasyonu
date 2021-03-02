
namespace yurtkayitsistemi
{
    partial class frmpersonel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtpersonelid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpersonelad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpersonelgorev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtotomasyonuDataSet = new yurtkayitsistemi.yurtotomasyonuDataSet();
            this.yurtotomasyonuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new yurtkayitsistemi.yurtotomasyonuDataSetTableAdapters.personelTableAdapter();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeladsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeldepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpersonelid
            // 
            this.txtpersonelid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtpersonelid.Enabled = false;
            this.txtpersonelid.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpersonelid.Location = new System.Drawing.Point(205, 17);
            this.txtpersonelid.Name = "txtpersonelid";
            this.txtpersonelid.Size = new System.Drawing.Size(282, 35);
            this.txtpersonelid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel ID :";
            // 
            // txtpersonelad
            // 
            this.txtpersonelad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtpersonelad.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpersonelad.Location = new System.Drawing.Point(205, 58);
            this.txtpersonelad.Name = "txtpersonelad";
            this.txtpersonelad.Size = new System.Drawing.Size(282, 35);
            this.txtpersonelad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(36, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Ad :";
            // 
            // txtpersonelgorev
            // 
            this.txtpersonelgorev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtpersonelgorev.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpersonelgorev.Location = new System.Drawing.Point(205, 99);
            this.txtpersonelgorev.Name = "txtpersonelgorev";
            this.txtpersonelgorev.Size = new System.Drawing.Size(282, 35);
            this.txtpersonelgorev.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Wheat;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Gorev:";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnkaydet.Location = new System.Drawing.Point(28, 164);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(149, 35);
            this.btnkaydet.TabIndex = 11;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnsil.Location = new System.Drawing.Point(183, 166);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(149, 31);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "SIL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnguncelle.Location = new System.Drawing.Point(338, 166);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(149, 30);
            this.btnguncelle.TabIndex = 9;
            this.btnguncelle.Text = "GUNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personeladsoyadDataGridViewTextBoxColumn,
            this.personeldepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 144);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurtotomasyonuDataSet
            // 
            this.yurtotomasyonuDataSet.DataSetName = "yurtotomasyonuDataSet";
            this.yurtotomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yurtotomasyonuDataSetBindingSource
            // 
            this.yurtotomasyonuDataSetBindingSource.DataSource = this.yurtotomasyonuDataSet;
            this.yurtotomasyonuDataSetBindingSource.Position = 0;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.yurtotomasyonuDataSetBindingSource;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "personelid";
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personeladsoyadDataGridViewTextBoxColumn
            // 
            this.personeladsoyadDataGridViewTextBoxColumn.DataPropertyName = "personeladsoyad";
            this.personeladsoyadDataGridViewTextBoxColumn.HeaderText = "personeladsoyad";
            this.personeladsoyadDataGridViewTextBoxColumn.Name = "personeladsoyadDataGridViewTextBoxColumn";
            // 
            // personeldepartmanDataGridViewTextBoxColumn
            // 
            this.personeldepartmanDataGridViewTextBoxColumn.DataPropertyName = "personeldepartman";
            this.personeldepartmanDataGridViewTextBoxColumn.HeaderText = "personeldepartman";
            this.personeldepartmanDataGridViewTextBoxColumn.Name = "personeldepartmanDataGridViewTextBoxColumn";
            // 
            // frmpersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txtpersonelgorev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpersonelad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpersonelid);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpersonel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.frmpersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpersonelid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpersonelad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpersonelgorev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource yurtotomasyonuDataSetBindingSource;
        private yurtotomasyonuDataSet yurtotomasyonuDataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private yurtotomasyonuDataSetTableAdapters.personelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeladsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeldepartmanDataGridViewTextBoxColumn;
    }
}
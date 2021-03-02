
namespace yurtkayitsistemi
{
    partial class frmbolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbolumler));
            this.pcbbolumsil = new System.Windows.Forms.PictureBox();
            this.pcbbolumekle = new System.Windows.Forms.PictureBox();
            this.pcbbolumduzenle = new System.Windows.Forms.PictureBox();
            this.txtbolumad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yurtotomasyonuDataSet = new yurtkayitsistemi.yurtotomasyonuDataSet();
            this.yurtotomasyonuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new yurtkayitsistemi.yurtotomasyonuDataSetTableAdapters.adminTableAdapter();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumlerTableAdapter = new yurtkayitsistemi.yurtotomasyonuDataSetTableAdapters.bolumlerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtotomasyonuDataSet1 = new yurtkayitsistemi.yurtotomasyonuDataSet1();
            this.bolumlerTableAdapter1 = new yurtkayitsistemi.yurtotomasyonuDataSet1TableAdapters.bolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbbolumsil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbbolumekle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbbolumduzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbbolumsil
            // 
            this.pcbbolumsil.Image = ((System.Drawing.Image)(resources.GetObject("pcbbolumsil.Image")));
            this.pcbbolumsil.Location = new System.Drawing.Point(510, 242);
            this.pcbbolumsil.Name = "pcbbolumsil";
            this.pcbbolumsil.Size = new System.Drawing.Size(87, 76);
            this.pcbbolumsil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbbolumsil.TabIndex = 0;
            this.pcbbolumsil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbbolumsil, "sil");
            this.pcbbolumsil.Click += new System.EventHandler(this.pcbbolumsil_Click);
            // 
            // pcbbolumekle
            // 
            this.pcbbolumekle.Image = ((System.Drawing.Image)(resources.GetObject("pcbbolumekle.Image")));
            this.pcbbolumekle.Location = new System.Drawing.Point(510, 353);
            this.pcbbolumekle.Name = "pcbbolumekle";
            this.pcbbolumekle.Size = new System.Drawing.Size(82, 76);
            this.pcbbolumekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbbolumekle.TabIndex = 1;
            this.pcbbolumekle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbbolumekle, "ekle");
            this.pcbbolumekle.Click += new System.EventHandler(this.pcbbolumekle_Click);
            // 
            // pcbbolumduzenle
            // 
            this.pcbbolumduzenle.Image = ((System.Drawing.Image)(resources.GetObject("pcbbolumduzenle.Image")));
            this.pcbbolumduzenle.Location = new System.Drawing.Point(510, 131);
            this.pcbbolumduzenle.Name = "pcbbolumduzenle";
            this.pcbbolumduzenle.Size = new System.Drawing.Size(87, 76);
            this.pcbbolumduzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbbolumduzenle.TabIndex = 2;
            this.pcbbolumduzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbbolumduzenle, "duzenle");
            this.pcbbolumduzenle.Click += new System.EventHandler(this.pcbbolumduzenle_Click);
            // 
            // txtbolumad
            // 
            this.txtbolumad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtbolumad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbolumad.Location = new System.Drawing.Point(157, 36);
            this.txtbolumad.Name = "txtbolumad";
            this.txtbolumad.Size = new System.Drawing.Size(440, 35);
            this.txtbolumad.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bolum Ad:";
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
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this.yurtotomasyonuDataSetBindingSource;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtotomasyonuDataSetBindingSource;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 298);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "bolumid";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumadDataGridViewTextBoxColumn
            // 
            this.bolumadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumadDataGridViewTextBoxColumn.DataPropertyName = "bolumad";
            this.bolumadDataGridViewTextBoxColumn.HeaderText = "bolumad";
            this.bolumadDataGridViewTextBoxColumn.Name = "bolumadDataGridViewTextBoxColumn";
            this.bolumadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumlerBindingSource1
            // 
            this.bolumlerBindingSource1.DataMember = "bolumler";
            this.bolumlerBindingSource1.DataSource = this.yurtotomasyonuDataSet1;
            // 
            // yurtotomasyonuDataSet1
            // 
            this.yurtotomasyonuDataSet1.DataSetName = "yurtotomasyonuDataSet1";
            this.yurtotomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter1
            // 
            this.bolumlerTableAdapter1.ClearBeforeFill = true;
            // 
            // frmbolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(604, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbolumad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbbolumduzenle);
            this.Controls.Add(this.pcbbolumekle);
            this.Controls.Add(this.pcbbolumsil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbolumler";
            this.Text = "Bolumler";
            this.Load += new System.EventHandler(this.frmbolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbbolumsil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbbolumekle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbbolumduzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonuDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbbolumsil;
        private System.Windows.Forms.PictureBox pcbbolumekle;
        private System.Windows.Forms.PictureBox pcbbolumduzenle;
        private System.Windows.Forms.TextBox txtbolumad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource yurtotomasyonuDataSetBindingSource;
        private yurtotomasyonuDataSet yurtotomasyonuDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private yurtotomasyonuDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private yurtotomasyonuDataSetTableAdapters.bolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yurtotomasyonuDataSet1 yurtotomasyonuDataSet1;
        private System.Windows.Forms.BindingSource bolumlerBindingSource1;
        private yurtotomasyonuDataSet1TableAdapters.bolumlerTableAdapter bolumlerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumadDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
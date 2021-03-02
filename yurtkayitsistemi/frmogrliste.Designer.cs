
namespace yurtkayitsistemi
{
    partial class frmogrliste
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrdogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrbolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrodanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrveliadsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrvelitelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrveliadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtotomasyonuDataSet = new yurtkayitsistemi.yurtotomasyonuDataSet();
            this.ogrenciTableAdapter = new yurtkayitsistemi.yurtotomasyonuDataSetTableAdapters.ogrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.ogrtcDataGridViewTextBoxColumn,
            this.ogrtelefonDataGridViewTextBoxColumn,
            this.ogrdogumDataGridViewTextBoxColumn,
            this.ogrbolumDataGridViewTextBoxColumn,
            this.ogrmailDataGridViewTextBoxColumn,
            this.ogrodanoDataGridViewTextBoxColumn,
            this.ogrveliadsoyadDataGridViewTextBoxColumn,
            this.ogrvelitelefonDataGridViewTextBoxColumn,
            this.ogrveliadresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1247, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ograd";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ograd";
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            // 
            // ogrtcDataGridViewTextBoxColumn
            // 
            this.ogrtcDataGridViewTextBoxColumn.DataPropertyName = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.HeaderText = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.Name = "ogrtcDataGridViewTextBoxColumn";
            // 
            // ogrtelefonDataGridViewTextBoxColumn
            // 
            this.ogrtelefonDataGridViewTextBoxColumn.DataPropertyName = "ogrtelefon";
            this.ogrtelefonDataGridViewTextBoxColumn.HeaderText = "ogrtelefon";
            this.ogrtelefonDataGridViewTextBoxColumn.Name = "ogrtelefonDataGridViewTextBoxColumn";
            // 
            // ogrdogumDataGridViewTextBoxColumn
            // 
            this.ogrdogumDataGridViewTextBoxColumn.DataPropertyName = "ogrdogum";
            this.ogrdogumDataGridViewTextBoxColumn.HeaderText = "ogrdogum";
            this.ogrdogumDataGridViewTextBoxColumn.Name = "ogrdogumDataGridViewTextBoxColumn";
            // 
            // ogrbolumDataGridViewTextBoxColumn
            // 
            this.ogrbolumDataGridViewTextBoxColumn.DataPropertyName = "ogrbolum";
            this.ogrbolumDataGridViewTextBoxColumn.HeaderText = "ogrbolum";
            this.ogrbolumDataGridViewTextBoxColumn.Name = "ogrbolumDataGridViewTextBoxColumn";
            // 
            // ogrmailDataGridViewTextBoxColumn
            // 
            this.ogrmailDataGridViewTextBoxColumn.DataPropertyName = "ogrmail";
            this.ogrmailDataGridViewTextBoxColumn.HeaderText = "ogrmail";
            this.ogrmailDataGridViewTextBoxColumn.Name = "ogrmailDataGridViewTextBoxColumn";
            // 
            // ogrodanoDataGridViewTextBoxColumn
            // 
            this.ogrodanoDataGridViewTextBoxColumn.DataPropertyName = "ogrodano";
            this.ogrodanoDataGridViewTextBoxColumn.HeaderText = "ogrodano";
            this.ogrodanoDataGridViewTextBoxColumn.Name = "ogrodanoDataGridViewTextBoxColumn";
            // 
            // ogrveliadsoyadDataGridViewTextBoxColumn
            // 
            this.ogrveliadsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrveliadsoyad";
            this.ogrveliadsoyadDataGridViewTextBoxColumn.HeaderText = "ogrveliadsoyad";
            this.ogrveliadsoyadDataGridViewTextBoxColumn.Name = "ogrveliadsoyadDataGridViewTextBoxColumn";
            // 
            // ogrvelitelefonDataGridViewTextBoxColumn
            // 
            this.ogrvelitelefonDataGridViewTextBoxColumn.DataPropertyName = "ogrvelitelefon";
            this.ogrvelitelefonDataGridViewTextBoxColumn.HeaderText = "ogrvelitelefon";
            this.ogrvelitelefonDataGridViewTextBoxColumn.Name = "ogrvelitelefonDataGridViewTextBoxColumn";
            // 
            // ogrveliadresDataGridViewTextBoxColumn
            // 
            this.ogrveliadresDataGridViewTextBoxColumn.DataPropertyName = "ogrveliadres";
            this.ogrveliadresDataGridViewTextBoxColumn.HeaderText = "ogrveliadres";
            this.ogrveliadresDataGridViewTextBoxColumn.Name = "ogrveliadresDataGridViewTextBoxColumn";
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtotomasyonuDataSet;
            // 
            // yurtotomasyonuDataSet
            // 
            this.yurtotomasyonuDataSet.DataSetName = "yurtotomasyonuDataSet";
            this.yurtotomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // frmogrliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1247, 450);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmogrliste";
            this.Text = "frmogrliste";
            this.Load += new System.EventHandler(this.frmogrliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtotomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yurtotomasyonuDataSet yurtotomasyonuDataSet;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private yurtotomasyonuDataSetTableAdapters.ogrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrdogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrbolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrodanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrveliadsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrvelitelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrveliadresDataGridViewTextBoxColumn;
    }
}
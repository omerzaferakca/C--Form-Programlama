namespace ogrenciNotSistemi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_No = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.msk_Ortalama = new System.Windows.Forms.MaskedTextBox();
            this.cmb_DersAd = new System.Windows.Forms.ComboBox();
            this.txt_Harf = new System.Windows.Forms.TextBox();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_Istatistik = new System.Windows.Forms.Button();
            this.btn_Grafikler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciNotSistemiVeriTabaniDataSet2 = new ogrenciNotSistemi.OgrenciNotSistemiVeriTabaniDataSet2();
            this.ogrenciNotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenci_NotTableAdapter = new ogrenciNotSistemi.OgrenciNotSistemiVeriTabaniDataSet2TableAdapters.ogrenci_NotTableAdapter();
            this.ogrenciNotSistemiVeriTabaniDataSet = new ogrenciNotSistemi.OgrenciNotSistemiVeriTabaniDataSet();
            this.ogrenciNotSistemiVeriTabaniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersVizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersOrtalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersHarfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msk_Vize = new System.Windows.Forms.MaskedTextBox();
            this.msk_Final = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotSistemiVeriTabaniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotSistemiVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotSistemiVeriTabaniDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ders Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vize Notu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Final Notu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 300);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ortalaması:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 348);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Harf Notu:";
            // 
            // txt_No
            // 
            this.txt_No.Enabled = false;
            this.txt_No.Location = new System.Drawing.Point(145, 27);
            this.txt_No.Margin = new System.Windows.Forms.Padding(2);
            this.txt_No.Name = "txt_No";
            this.txt_No.Size = new System.Drawing.Size(139, 29);
            this.txt_No.TabIndex = 1;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(145, 68);
            this.txt_Ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(139, 29);
            this.txt_Ad.TabIndex = 1;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(145, 109);
            this.txt_Soyad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(139, 29);
            this.txt_Soyad.TabIndex = 2;
            // 
            // msk_Ortalama
            // 
            this.msk_Ortalama.Enabled = false;
            this.msk_Ortalama.Location = new System.Drawing.Point(145, 294);
            this.msk_Ortalama.Margin = new System.Windows.Forms.Padding(2);
            this.msk_Ortalama.Mask = "00,00";
            this.msk_Ortalama.Name = "msk_Ortalama";
            this.msk_Ortalama.Size = new System.Drawing.Size(139, 29);
            this.msk_Ortalama.TabIndex = 7;
            this.msk_Ortalama.ValidatingType = typeof(int);
            // 
            // cmb_DersAd
            // 
            this.cmb_DersAd.FormattingEnabled = true;
            this.cmb_DersAd.Items.AddRange(new object[] {
            "Mikroişlemciler",
            "Diferansiyel Denklemler",
            "Bilgisayar Ağları",
            "Elektrik ve Elektronik Devreler",
            "Ayrık Matematik"});
            this.cmb_DersAd.Location = new System.Drawing.Point(145, 156);
            this.cmb_DersAd.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_DersAd.Name = "cmb_DersAd";
            this.cmb_DersAd.Size = new System.Drawing.Size(139, 30);
            this.cmb_DersAd.TabIndex = 3;
            // 
            // txt_Harf
            // 
            this.txt_Harf.Enabled = false;
            this.txt_Harf.Location = new System.Drawing.Point(145, 341);
            this.txt_Harf.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Harf.Name = "txt_Harf";
            this.txt_Harf.Size = new System.Drawing.Size(139, 29);
            this.txt_Harf.TabIndex = 8;
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(63, 28);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(159, 37);
            this.btn_Listele.TabIndex = 6;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(63, 78);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(159, 37);
            this.btn_Kaydet.TabIndex = 7;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(63, 129);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(159, 37);
            this.btn_Sil.TabIndex = 8;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(63, 183);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(159, 37);
            this.btn_Guncelle.TabIndex = 9;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(63, 239);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(159, 37);
            this.btn_Temizle.TabIndex = 10;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Istatistik
            // 
            this.btn_Istatistik.Location = new System.Drawing.Point(63, 296);
            this.btn_Istatistik.Name = "btn_Istatistik";
            this.btn_Istatistik.Size = new System.Drawing.Size(159, 37);
            this.btn_Istatistik.TabIndex = 11;
            this.btn_Istatistik.Text = "İstatistik";
            this.btn_Istatistik.UseVisualStyleBackColor = true;
            // 
            // btn_Grafikler
            // 
            this.btn_Grafikler.Location = new System.Drawing.Point(63, 348);
            this.btn_Grafikler.Name = "btn_Grafikler";
            this.btn_Grafikler.Size = new System.Drawing.Size(159, 37);
            this.btn_Grafikler.TabIndex = 12;
            this.btn_Grafikler.Text = "Grafikler";
            this.btn_Grafikler.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msk_Final);
            this.groupBox1.Controls.Add(this.msk_Vize);
            this.groupBox1.Controls.Add(this.txt_Harf);
            this.groupBox1.Controls.Add(this.cmb_DersAd);
            this.groupBox1.Controls.Add(this.msk_Ortalama);
            this.groupBox1.Controls.Add(this.txt_Soyad);
            this.groupBox1.Controls.Add(this.txt_Ad);
            this.groupBox1.Controls.Add(this.txt_No);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 414);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Grafikler);
            this.groupBox2.Controls.Add(this.btn_Istatistik);
            this.groupBox2.Controls.Add(this.btn_Temizle);
            this.groupBox2.Controls.Add(this.btn_Guncelle);
            this.groupBox2.Controls.Add(this.btn_Sil);
            this.groupBox2.Controls.Add(this.btn_Kaydet);
            this.groupBox2.Controls.Add(this.btn_Listele);
            this.groupBox2.Location = new System.Drawing.Point(462, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 414);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1000, 152);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciNoDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.dersAdiDataGridViewTextBoxColumn,
            this.dersVizeDataGridViewTextBoxColumn,
            this.dersFinalDataGridViewTextBoxColumn,
            this.dersOrtalamaDataGridViewTextBoxColumn,
            this.dersHarfDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciNotBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(994, 124);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ogrenciNotSistemiVeriTabaniDataSet2
            // 
            this.ogrenciNotSistemiVeriTabaniDataSet2.DataSetName = "OgrenciNotSistemiVeriTabaniDataSet2";
            this.ogrenciNotSistemiVeriTabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciNotBindingSource
            // 
            this.ogrenciNotBindingSource.DataMember = "ogrenci_Not";
            this.ogrenciNotBindingSource.DataSource = this.ogrenciNotSistemiVeriTabaniDataSet2;
            // 
            // ogrenci_NotTableAdapter
            // 
            this.ogrenci_NotTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciNotSistemiVeriTabaniDataSet
            // 
            this.ogrenciNotSistemiVeriTabaniDataSet.DataSetName = "OgrenciNotSistemiVeriTabaniDataSet";
            this.ogrenciNotSistemiVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciNotSistemiVeriTabaniDataSetBindingSource
            // 
            this.ogrenciNotSistemiVeriTabaniDataSetBindingSource.DataSource = this.ogrenciNotSistemiVeriTabaniDataSet;
            this.ogrenciNotSistemiVeriTabaniDataSetBindingSource.Position = 0;
            // 
            // ogrenciNoDataGridViewTextBoxColumn
            // 
            this.ogrenciNoDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_No";
            this.ogrenciNoDataGridViewTextBoxColumn.HeaderText = "ogrenci_No";
            this.ogrenciNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciNoDataGridViewTextBoxColumn.Name = "ogrenciNoDataGridViewTextBoxColumn";
            this.ogrenciNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrenciNoDataGridViewTextBoxColumn.Width = 115;
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_Ad";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "ogrenci_Ad";
            this.ogrenciAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            this.ogrenciAdDataGridViewTextBoxColumn.Width = 115;
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrenci_Soyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "ogrenci_Soyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Width = 115;
            // 
            // dersAdiDataGridViewTextBoxColumn
            // 
            this.dersAdiDataGridViewTextBoxColumn.DataPropertyName = "ders_Adi";
            this.dersAdiDataGridViewTextBoxColumn.HeaderText = "ders_Adi";
            this.dersAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersAdiDataGridViewTextBoxColumn.Name = "dersAdiDataGridViewTextBoxColumn";
            this.dersAdiDataGridViewTextBoxColumn.Width = 115;
            // 
            // dersVizeDataGridViewTextBoxColumn
            // 
            this.dersVizeDataGridViewTextBoxColumn.DataPropertyName = "ders_Vize";
            this.dersVizeDataGridViewTextBoxColumn.HeaderText = "ders_Vize";
            this.dersVizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersVizeDataGridViewTextBoxColumn.Name = "dersVizeDataGridViewTextBoxColumn";
            this.dersVizeDataGridViewTextBoxColumn.Width = 115;
            // 
            // dersFinalDataGridViewTextBoxColumn
            // 
            this.dersFinalDataGridViewTextBoxColumn.DataPropertyName = "ders_Final";
            this.dersFinalDataGridViewTextBoxColumn.HeaderText = "ders_Final";
            this.dersFinalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersFinalDataGridViewTextBoxColumn.Name = "dersFinalDataGridViewTextBoxColumn";
            this.dersFinalDataGridViewTextBoxColumn.Width = 115;
            // 
            // dersOrtalamaDataGridViewTextBoxColumn
            // 
            this.dersOrtalamaDataGridViewTextBoxColumn.DataPropertyName = "ders_Ortalama";
            this.dersOrtalamaDataGridViewTextBoxColumn.HeaderText = "ders_Ortalama";
            this.dersOrtalamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersOrtalamaDataGridViewTextBoxColumn.Name = "dersOrtalamaDataGridViewTextBoxColumn";
            this.dersOrtalamaDataGridViewTextBoxColumn.Width = 115;
            // 
            // dersHarfDataGridViewTextBoxColumn
            // 
            this.dersHarfDataGridViewTextBoxColumn.DataPropertyName = "ders_Harf";
            this.dersHarfDataGridViewTextBoxColumn.HeaderText = "ders_Harf";
            this.dersHarfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersHarfDataGridViewTextBoxColumn.Name = "dersHarfDataGridViewTextBoxColumn";
            this.dersHarfDataGridViewTextBoxColumn.Width = 115;
            // 
            // msk_Vize
            // 
            this.msk_Vize.Location = new System.Drawing.Point(145, 200);
            this.msk_Vize.Mask = "000";
            this.msk_Vize.Name = "msk_Vize";
            this.msk_Vize.Size = new System.Drawing.Size(139, 29);
            this.msk_Vize.TabIndex = 9;
            this.msk_Vize.ValidatingType = typeof(int);
            // 
            // msk_Final
            // 
            this.msk_Final.Location = new System.Drawing.Point(145, 242);
            this.msk_Final.Mask = "000";
            this.msk_Final.Name = "msk_Final";
            this.msk_Final.Size = new System.Drawing.Size(139, 29);
            this.msk_Final.TabIndex = 10;
            this.msk_Final.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1011, 705);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotSistemiVeriTabaniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotSistemiVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotSistemiVeriTabaniDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_No;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.MaskedTextBox msk_Ortalama;
        private System.Windows.Forms.ComboBox cmb_DersAd;
        private System.Windows.Forms.TextBox txt_Harf;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button btn_Istatistik;
        private System.Windows.Forms.Button btn_Grafikler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OgrenciNotSistemiVeriTabaniDataSet2 ogrenciNotSistemiVeriTabaniDataSet2;
        private System.Windows.Forms.BindingSource ogrenciNotBindingSource;
        private OgrenciNotSistemiVeriTabaniDataSet2TableAdapters.ogrenci_NotTableAdapter ogrenci_NotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersVizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersOrtalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersHarfDataGridViewTextBoxColumn;
        private OgrenciNotSistemiVeriTabaniDataSet ogrenciNotSistemiVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource ogrenciNotSistemiVeriTabaniDataSetBindingSource;
        private System.Windows.Forms.MaskedTextBox msk_Final;
        private System.Windows.Forms.MaskedTextBox msk_Vize;
    }
}


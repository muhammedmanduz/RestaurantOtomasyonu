namespace RestaurantOtomasyonu
{
    partial class Baskets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baskets));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LvKategoriler = new System.Windows.Forms.ListView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LvUrunler = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvSiparisler = new System.Windows.Forms.DataGridView();
            this.BtnHepsiniAktar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgvOdenecekler = new System.Windows.Forms.DataGridView();
            this.BtnOdeme = new System.Windows.Forms.Button();
            this.CbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.BtnOdemeSifirla = new System.Windows.Forms.Button();
            this.LBLMasaNo = new System.Windows.Forms.Label();
            this.LBLToplamFiyat = new System.Windows.Forms.Label();
            this.LBLOdenecekFiyat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSiparisler)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOdenecekler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LvKategoriler);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategoriler";
            // 
            // LvKategoriler
            // 
            this.LvKategoriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvKategoriler.HideSelection = false;
            this.LvKategoriler.LargeImageList = this.ımageList1;
            this.LvKategoriler.Location = new System.Drawing.Point(3, 26);
            this.LvKategoriler.Name = "LvKategoriler";
            this.LvKategoriler.Size = new System.Drawing.Size(558, 152);
            this.LvKategoriler.TabIndex = 0;
            this.LvKategoriler.UseCompatibleStateImageBehavior = false;
            this.LvKategoriler.DoubleClick += new System.EventHandler(this.LvKategoriler_DoubleClick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kategori.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LvUrunler);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 342);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // LvUrunler
            // 
            this.LvUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvUrunler.HideSelection = false;
            this.LvUrunler.LargeImageList = this.ımageList1;
            this.LvUrunler.Location = new System.Drawing.Point(3, 26);
            this.LvUrunler.Name = "LvUrunler";
            this.LvUrunler.Size = new System.Drawing.Size(558, 313);
            this.LvUrunler.TabIndex = 1;
            this.LvUrunler.UseCompatibleStateImageBehavior = false;
            this.LvUrunler.DoubleClick += new System.EventHandler(this.LvUrunler_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvSiparisler);
            this.groupBox3.Location = new System.Drawing.Point(591, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 166);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Siparişler";
            // 
            // DgvSiparisler
            // 
            this.DgvSiparisler.AllowUserToAddRows = false;
            this.DgvSiparisler.AllowUserToDeleteRows = false;
            this.DgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSiparisler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSiparisler.Location = new System.Drawing.Point(3, 26);
            this.DgvSiparisler.Name = "DgvSiparisler";
            this.DgvSiparisler.ReadOnly = true;
            this.DgvSiparisler.RowHeadersWidth = 51;
            this.DgvSiparisler.Size = new System.Drawing.Size(407, 137);
            this.DgvSiparisler.TabIndex = 0;
            this.DgvSiparisler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSiparisler_CellClick);
            this.DgvSiparisler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSiparisler_CellDoubleClick);
            // 
            // BtnHepsiniAktar
            // 
            this.BtnHepsiniAktar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnHepsiniAktar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHepsiniAktar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnHepsiniAktar.Location = new System.Drawing.Point(594, 221);
            this.BtnHepsiniAktar.Name = "BtnHepsiniAktar";
            this.BtnHepsiniAktar.Size = new System.Drawing.Size(132, 30);
            this.BtnHepsiniAktar.TabIndex = 10;
            this.BtnHepsiniAktar.Text = "Hepsini Aktar";
            this.BtnHepsiniAktar.UseVisualStyleBackColor = false;
            this.BtnHepsiniAktar.Click += new System.EventHandler(this.BtnHepsiniAktar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgvOdenecekler);
            this.groupBox4.Location = new System.Drawing.Point(589, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 158);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ödenecekler :";
            // 
            // DgvOdenecekler
            // 
            this.DgvOdenecekler.AllowUserToAddRows = false;
            this.DgvOdenecekler.AllowUserToDeleteRows = false;
            this.DgvOdenecekler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOdenecekler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvOdenecekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOdenecekler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvOdenecekler.Location = new System.Drawing.Point(3, 26);
            this.DgvOdenecekler.Name = "DgvOdenecekler";
            this.DgvOdenecekler.ReadOnly = true;
            this.DgvOdenecekler.RowHeadersWidth = 51;
            this.DgvOdenecekler.Size = new System.Drawing.Size(406, 129);
            this.DgvOdenecekler.TabIndex = 0;
            this.DgvOdenecekler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOdenecekler_CellDoubleClick);
            // 
            // BtnOdeme
            // 
            this.BtnOdeme.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOdeme.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnOdeme.Location = new System.Drawing.Point(836, 508);
            this.BtnOdeme.Name = "BtnOdeme";
            this.BtnOdeme.Size = new System.Drawing.Size(162, 30);
            this.BtnOdeme.TabIndex = 11;
            this.BtnOdeme.Text = "Ödeme Gerçekleştir";
            this.BtnOdeme.UseVisualStyleBackColor = false;
            this.BtnOdeme.Click += new System.EventHandler(this.BtnOdeme_Click);
            // 
            // CbOdemeTipi
            // 
            this.CbOdemeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOdemeTipi.FormattingEnabled = true;
            this.CbOdemeTipi.Items.AddRange(new object[] {
            "Ödeme Seçiniz",
            "Kredi Kartı",
            "Nakit"});
            this.CbOdemeTipi.Location = new System.Drawing.Point(588, 510);
            this.CbOdemeTipi.Name = "CbOdemeTipi";
            this.CbOdemeTipi.Size = new System.Drawing.Size(202, 33);
            this.CbOdemeTipi.TabIndex = 12;
            // 
            // BtnOdemeSifirla
            // 
            this.BtnOdemeSifirla.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnOdemeSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOdemeSifirla.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnOdemeSifirla.Location = new System.Drawing.Point(589, 474);
            this.BtnOdemeSifirla.Name = "BtnOdemeSifirla";
            this.BtnOdemeSifirla.Size = new System.Drawing.Size(409, 30);
            this.BtnOdemeSifirla.TabIndex = 13;
            this.BtnOdemeSifirla.Text = "Ödenecek Listesini Sıfırla";
            this.BtnOdemeSifirla.UseVisualStyleBackColor = false;
            this.BtnOdemeSifirla.Click += new System.EventHandler(this.BtnOdemeSifirla_Click);
            // 
            // LBLMasaNo
            // 
            this.LBLMasaNo.BackColor = System.Drawing.Color.Brown;
            this.LBLMasaNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLMasaNo.Location = new System.Drawing.Point(893, 12);
            this.LBLMasaNo.Name = "LBLMasaNo";
            this.LBLMasaNo.Size = new System.Drawing.Size(105, 27);
            this.LBLMasaNo.TabIndex = 14;
            this.LBLMasaNo.Text = "Masa No : 2";
            this.LBLMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLToplamFiyat
            // 
            this.LBLToplamFiyat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLToplamFiyat.Location = new System.Drawing.Point(878, 221);
            this.LBLToplamFiyat.Name = "LBLToplamFiyat";
            this.LBLToplamFiyat.Size = new System.Drawing.Size(120, 30);
            this.LBLToplamFiyat.TabIndex = 15;
            this.LBLToplamFiyat.Text = "150,75 TL";
            this.LBLToplamFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLOdenecekFiyat
            // 
            this.LBLOdenecekFiyat.BackColor = System.Drawing.Color.LightPink;
            this.LBLOdenecekFiyat.Location = new System.Drawing.Point(590, 440);
            this.LBLOdenecekFiyat.Name = "LBLOdenecekFiyat";
            this.LBLOdenecekFiyat.Size = new System.Drawing.Size(408, 30);
            this.LBLOdenecekFiyat.TabIndex = 16;
            this.LBLOdenecekFiyat.Text = "Ödenecek Tutar :125,50 TL";
            this.LBLOdenecekFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Baskets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 553);
            this.Controls.Add(this.LBLOdenecekFiyat);
            this.Controls.Add(this.LBLToplamFiyat);
            this.Controls.Add(this.LBLMasaNo);
            this.Controls.Add(this.BtnOdemeSifirla);
            this.Controls.Add(this.CbOdemeTipi);
            this.Controls.Add(this.BtnOdeme);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BtnHepsiniAktar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Baskets";
            this.Text = "Baskets";
            this.Load += new System.EventHandler(this.Baskets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSiparisler)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOdenecekler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnHepsiniAktar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnOdeme;
        private System.Windows.Forms.ComboBox CbOdemeTipi;
        private System.Windows.Forms.Button BtnOdemeSifirla;
        private System.Windows.Forms.ListView LvKategoriler;
        private System.Windows.Forms.ListView LvUrunler;
        private System.Windows.Forms.DataGridView DgvSiparisler;
        private System.Windows.Forms.Label LBLToplamFiyat;
        private System.Windows.Forms.Label LBLOdenecekFiyat;
        private System.Windows.Forms.DataGridView DgvOdenecekler;
        public System.Windows.Forms.Label LBLMasaNo;
        private System.Windows.Forms.ImageList ımageList1;
    }
}
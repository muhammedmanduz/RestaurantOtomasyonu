namespace RestaurantOtomasyonu
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MsKategoriler = new System.Windows.Forms.ToolStripMenuItem();
            this.MsUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.MsMasalar = new System.Windows.Forms.ToolStripMenuItem();
            this.MsSiparisler = new System.Windows.Forms.ToolStripMenuItem();
            this.MsKasa = new System.Windows.Forms.ToolStripMenuItem();
            this.MsPersoneller = new System.Windows.Forms.ToolStripMenuItem();
            this.MsRezervasyonlar = new System.Windows.Forms.ToolStripMenuItem();
            this.MsCikisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsKategoriler,
            this.MsUrunler,
            this.MsMasalar,
            this.MsSiparisler,
            this.MsKasa,
            this.MsPersoneller,
            this.MsRezervasyonlar,
            this.MsCikisYap});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MsKategoriler
            // 
            this.MsKategoriler.Name = "MsKategoriler";
            this.MsKategoriler.Size = new System.Drawing.Size(140, 24);
            this.MsKategoriler.Text = "KATEGORİLER(F2)";
            this.MsKategoriler.Click += new System.EventHandler(this.MsKategoriler_Click);
            // 
            // MsUrunler
            // 
            this.MsUrunler.Name = "MsUrunler";
            this.MsUrunler.Size = new System.Drawing.Size(112, 24);
            this.MsUrunler.Text = "ÜRÜNLER(F3)";
            this.MsUrunler.Click += new System.EventHandler(this.MsUrunler_Click);
            // 
            // MsMasalar
            // 
            this.MsMasalar.Name = "MsMasalar";
            this.MsMasalar.Size = new System.Drawing.Size(154, 24);
            this.MsMasalar.Text = "MASALAR(CTRL+N)";
            this.MsMasalar.Click += new System.EventHandler(this.MsMasalar_Click);
            // 
            // MsSiparisler
            // 
            this.MsSiparisler.Name = "MsSiparisler";
            this.MsSiparisler.Size = new System.Drawing.Size(97, 24);
            this.MsSiparisler.Text = "SİPARİŞLER";
            this.MsSiparisler.Click += new System.EventHandler(this.MsSiparisler_Click);
            // 
            // MsKasa
            // 
            this.MsKasa.Name = "MsKasa";
            this.MsKasa.Size = new System.Drawing.Size(60, 24);
            this.MsKasa.Text = "KASA";
            this.MsKasa.Click += new System.EventHandler(this.MsKasa_Click);
            // 
            // MsPersoneller
            // 
            this.MsPersoneller.Name = "MsPersoneller";
            this.MsPersoneller.Size = new System.Drawing.Size(117, 24);
            this.MsPersoneller.Text = "PERSONELLER";
            this.MsPersoneller.Click += new System.EventHandler(this.MsPersoneller_Click);
            // 
            // MsRezervasyonlar
            // 
            this.MsRezervasyonlar.Name = "MsRezervasyonlar";
            this.MsRezervasyonlar.Size = new System.Drawing.Size(147, 24);
            this.MsRezervasyonlar.Text = "REZERVASYONLAR";
            this.MsRezervasyonlar.Click += new System.EventHandler(this.MsRezervasyonlar_Click);
            // 
            // MsCikisYap
            // 
            this.MsCikisYap.Name = "MsCikisYap";
            this.MsCikisYap.Size = new System.Drawing.Size(86, 24);
            this.MsCikisYap.Text = "ÇIKIŞ YAP";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 494);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MsKategoriler;
        private System.Windows.Forms.ToolStripMenuItem MsUrunler;
        private System.Windows.Forms.ToolStripMenuItem MsMasalar;
        private System.Windows.Forms.ToolStripMenuItem MsSiparisler;
        private System.Windows.Forms.ToolStripMenuItem MsKasa;
        private System.Windows.Forms.ToolStripMenuItem MsPersoneller;
        private System.Windows.Forms.ToolStripMenuItem MsRezervasyonlar;
        private System.Windows.Forms.ToolStripMenuItem MsCikisYap;
    }
}
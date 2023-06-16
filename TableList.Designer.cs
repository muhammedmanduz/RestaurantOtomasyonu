namespace RestaurantOtomasyonu
{
    partial class TableList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableList));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LvListele = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "MasaAcik.png");
            this.ımageList1.Images.SetKeyName(1, "MasaKapali.PNG");
            this.ımageList1.Images.SetKeyName(2, "Rezervasyonlu.png");
            // 
            // LvListele
            // 
            this.LvListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvListele.HideSelection = false;
            this.LvListele.LargeImageList = this.ımageList1;
            this.LvListele.Location = new System.Drawing.Point(0, 0);
            this.LvListele.Name = "LvListele";
            this.LvListele.Size = new System.Drawing.Size(781, 414);
            this.LvListele.TabIndex = 0;
            this.LvListele.UseCompatibleStateImageBehavior = false;
            this.LvListele.DoubleClick += new System.EventHandler(this.LvListele_DoubleClick);
            // 
            // TableList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(781, 414);
            this.Controls.Add(this.LvListele);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableList";
            this.Text = "TableList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TableList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ListView LvListele;
    }
}
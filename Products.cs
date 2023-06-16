using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonu
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        RestaurantDatabaseEntities db = new RestaurantDatabaseEntities();
        private void Doldur()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("Ürün");
            dt.Columns.Add("Fiyat");
            dt.Columns.Add("Durumu");
            foreach (var item in db.TBLProducts.ToList())
            {
                dt.Rows.Add(item.id,
                    item.ProductName,
                    Convert.ToDecimal(item.Price).ToString("C"),
                    item.Status);
            }
            DgvListele.DataSource = dt;
        }
        private void Products_Load(object sender, EventArgs e)
        {
            Doldur();
            CbKategori.DataSource = db.TBLCategories.ToList();
            CbKategori.ValueMember = "id"; // Yazılımcıının Göreceği
            CbKategori.DisplayMember = "CategoryName"; // Bu Kullanıcının göreceği.
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Combobax VeriTabanı tarafından dolduruluyorsa, Selected özelliği kullanılır. Selected ile birlikte Value yada Text özelliği alınır.

            TBLProducts model = new TBLProducts();
            model.Price = decimal.Parse(TxtUrunFiyati.Text);
            model.ProductName = TxtUrunAdi.Text;
            model.CategoriesId = int.Parse(CbKategori.SelectedValue.ToString());
            model.Status = CbDurumu.Text == "Aktif" ? true : false;
            model.Images = "";
            model.Contents = TxtUrunIcerik.Text;
            db.TBLProducts.Add(model);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            Doldur();
        }

        private void DgvListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int AlinanID = int.Parse(DgvListele.Rows[e.RowIndex].Cells[0].Value.ToString());

            TBLProducts model = db.TBLProducts.Find(AlinanID);

            TxtUrunAdi.Text = model.ProductName;
            TxtUrunFiyati.Text = model.Price.ToString();
            TxtUrunIcerik.Text = model.Contents;
            CbKategori.Text = db.TBLCategories.Where(x => x.id == model.CategoriesId).First().CategoryName;
            CbDurumu.Text = model.Status == true ? "Aktif" : "Pasif";

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
          
            int TiklananSatir = int.Parse(DgvListele.CurrentRow.Index.ToString());

            int AlinanID = int.Parse(DgvListele.Rows[TiklananSatir].Cells[0].Value.ToString());

            TBLProducts model = db.TBLProducts.Find(AlinanID);
            model.Price = decimal.Parse(TxtUrunFiyati.Text);
            model.ProductName = TxtUrunAdi.Text;
            model.CategoriesId = int.Parse(CbKategori.SelectedValue.ToString());
            model.Status = CbDurumu.Text == "Aktif" ? true : false;
            model.Images = "";
            model.Contents = TxtUrunIcerik.Text;
            db.SaveChanges();

            MessageBox.Show("İşlem Başarılı");
            Doldur();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int TiklananSatir = int.Parse(DgvListele.CurrentRow.Index.ToString());
            int AlinanID = int.Parse(DgvListele.Rows[TiklananSatir].Cells[0].Value.ToString());

            TBLProducts model = db.TBLProducts.Find(AlinanID);
            db.TBLProducts.Remove(model);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            Doldur();
        }
    }
}

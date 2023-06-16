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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        RestaurantDatabaseEntities1 db=new RestaurantDatabaseEntities1();
        private void Doldur()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("Kategori");
            dt.Columns.Add("Durumu");
            foreach (var item in db.TBLCategories.ToList())
            {
                dt.Rows.Add(item.id,item.CategoryName,item.Status);
            }
            DgvListele.DataSource = dt;
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLCategories model = new TBLCategories();
            model.CategoryName = TxtKategoriAdi.Text;
            model.Status = (CbDurumu.Text == "Aktif" ? true : false);
            db.TBLCategories.Add(model);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            Doldur();
        }

        private void DgvListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKategoriAdi.Text = DgvListele.Rows[e.RowIndex].Cells[1].Value.ToString();
            CbDurumu.Text = (DgvListele.Rows[e.RowIndex].Cells[2].Value.ToString() == "True" ? "Aktif" : "Pasif");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            // Tıklanan Satırın Index'ini Al.
            int TiklananSatir = int.Parse(DgvListele.CurrentRow.Index.ToString());

            // Tıklanan Satırdaki İstenilen Sütunu ver.
            int AlinanID = int.Parse(DgvListele.Rows[TiklananSatir].Cells[0].Value.ToString());

            TBLCategories model = db.TBLCategories.Find(AlinanID);
            model.CategoryName = TxtKategoriAdi.Text;
            model.Status = (CbDurumu.Text == "Aktif" ? true : false);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");

            Doldur();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {  
            // Tıklanan Satırın Index'ini Al.
            int TiklananSatir = int.Parse(DgvListele.CurrentRow.Index.ToString());

            // Tıklanan Satırdaki İstenilen Sütunu ver.
            int AlinanID = int.Parse(DgvListele.Rows[TiklananSatir].Cells[0].Value.ToString());

            TBLCategories model = db.TBLCategories.Find(AlinanID);
            db.TBLCategories.Remove(model);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılıdır");
            Doldur();
        }
    }
}

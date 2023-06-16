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
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }
        RestaurantDatabaseEntities db = new RestaurantDatabaseEntities();
        private void Doldur()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("Masa");
            foreach (var item in db.TBLTables.ToList())
            {
                dt.Rows.Add(item.id,item.TableNo);
            }
            DgvListele.DataSource = dt;
        }
        private void Tables_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLTables model = new TBLTables();
            model.TableNo = TxtMasaAdi.Text;
            db.TBLTables.Add(model);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            Doldur();
        }

        private void DgvListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtMasaAdi.Text = DgvListele.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int TiklananSatir = int.Parse(DgvListele.CurrentRow.Index.ToString());
            int AlinanID = int.Parse(DgvListele.Rows[TiklananSatir].Cells[0].Value.ToString());

            TBLTables model = db.TBLTables.Find(AlinanID);
            model.TableNo = TxtMasaAdi.Text;
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            Doldur();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int TiklananSatir = int.Parse(DgvListele.CurrentRow.Index.ToString());
            int AlinanID = int.Parse(DgvListele.Rows[TiklananSatir].Cells[0].Value.ToString());
            TBLTables model = db.TBLTables.Find(AlinanID);
            db.TBLTables.Remove(model);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            Doldur();
        }
    }
}

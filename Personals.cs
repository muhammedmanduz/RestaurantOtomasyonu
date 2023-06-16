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
    public partial class Personals : Form
    {
        public Personals()
        {
            InitializeComponent();
        }
        RestaurantDatabaseEntities db = new RestaurantDatabaseEntities();
        private void Doldur()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("Email");
            dt.Columns.Add("Telefon");
            dt.Columns.Add("Yetki");
            foreach (var item in db.TBLPersonals.ToList())
            {
                dt.Rows.Add(item.id,item.Email,item.Phone,item.Roles);
            }
            DgvListe.DataSource = dt;
        }


        private void Personals_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLPersonals model = new TBLPersonals();
            model.Passwords = TxtSifre.Text;
            model.Email = TxtEmail.Text;
            model.Roles = CbRole.Text;
            model.Status = CbDurumu.Text == "Aktif" ? true:false;
            model.Phone = TxtTelefon.Text;
            db.TBLPersonals.Add(model);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            Doldur();
        }

        private void DgvListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int TiklananID = int.Parse(DgvListe.Rows[e.RowIndex].Cells[0].Value.ToString());
            TBLPersonals model = db.TBLPersonals.Find(TiklananID);
            TxtEmail.Text = model.Email;
            TxtSifre.Text = model.Passwords;
            TxtTelefon.Text = model.Phone;
            CbDurumu.Text = model.Status == true ? "Aktif":"Pasif";
            CbRole.Text = model.Roles;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        { 
           
            int TiklananSatir = int.Parse(DgvListe.CurrentRow.Index.ToString());

            int AlinanID = int.Parse(DgvListe.Rows[TiklananSatir].Cells[0].Value.ToString());

            TBLPersonals model = db.TBLPersonals.Find(AlinanID);
            model.Passwords = TxtSifre.Text;
            model.Email = TxtEmail.Text;
            model.Roles = CbRole.Text;
            model.Status = CbDurumu.Text == "Aktif" ? true : false;
            model.Phone = TxtTelefon.Text;
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            Doldur();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int TiklananSatir = int.Parse(DgvListe.CurrentRow.Index.ToString());

            int AlinanID = int.Parse(DgvListe.Rows[TiklananSatir].Cells[0].Value.ToString());
            TBLPersonals model = db.TBLPersonals.Find(AlinanID);
            db.TBLPersonals.Remove(model);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            Doldur();
        }
    }
}

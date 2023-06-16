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
    public partial class Rezervations : Form
    {
        public Rezervations()
        {
            InitializeComponent();
        }
        RestaurantDatabaseEntities db = new RestaurantDatabaseEntities();
        private void Doldur()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("Adı Soyadı");
            dt.Columns.Add("Telefon");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("Saat");
            foreach (var item in db.TBLRezervation.ToList())
            {
                dt.Rows.Add(item.id,item.NameSurName,item.Phone,Convert.ToDateTime(item.RezervationDate).ToString("dd/MM/yyyy"), Convert.ToDateTime(item.RezervationTime.ToString()).ToString("hh:mm"));
            }
            DgvListele.DataSource = dt;
        }
        private void Rezervations_Load(object sender, EventArgs e)
        {
            CbMasa.DisplayMember = "TableNo";
            CbMasa.ValueMember = "TableNo";
            CbMasa.DataSource = db.TBLTables.ToList();
            Doldur();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DateTime SecilenTarih = Convert.ToDateTime(DtpTarih.Text);
            TimeSpan SecilenSaat = TimeSpan.Parse(TxtSaat.Text);
            string SecilenMasa = CbMasa.SelectedItem.ToString();

            if (db.TBLRezervation.Any(x => x.TableNo == SecilenMasa && x.RezervationDate == SecilenTarih && x.RezervationTime == SecilenSaat))
            {
                MessageBox.Show("Seçilen Tarihte ve Saatte Bu Masa Doludur");
            }
            else
            {
                TBLRezervation model = new TBLRezervation();
                model.RezervationDate = Convert.ToDateTime(DtpTarih.Text);
                model.RezervationTime = TimeSpan.Parse(TxtSaat.Text);
                model.NameSurName = TxtAdSoyad.Text;
                model.TableNo = CbMasa.SelectedItem.ToString();
                model.PersonNumber = int.Parse(CbKisiSayisi.Text);
                model.Phone = TxtTelefon.Text;
                db.TBLRezervation.Add(model);
                db.SaveChanges();
                MessageBox.Show("İşlem Başarılı");
                Doldur();
            }
            
        }

        private void DgvListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int TiklananId = int.Parse(DgvListele.Rows[e.RowIndex].Cells[0].Value.ToString());

            TBLRezervation model = db.TBLRezervation.Find(TiklananId);
            TxtAdSoyad.Text = model.NameSurName;
            TxtTelefon.Text = model.Phone;
            TxtSaat.Text = model.RezervationTime.ToString();
            CbKisiSayisi.Text = model.PersonNumber.ToString();
            CbMasa.SelectedText = model.TableNo;
            DtpTarih.Text = model.RezervationDate.ToString();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            // Tıklanan Satırın Index'ini Al.
            int TiklananSatir = int.Parse(DgvListele.CurrentRow.Index.ToString());
            // Tıklanan Satırdaki İstenilen Sütunu ver.
            int AlinanID = int.Parse(DgvListele.Rows[TiklananSatir].Cells[0].Value.ToString());

            TBLRezervation model = db.TBLRezervation.Find(AlinanID);
            model.RezervationDate = Convert.ToDateTime(DtpTarih.Text);
            model.RezervationTime = TimeSpan.Parse(TxtSaat.Text);
            model.NameSurName = TxtAdSoyad.Text;
            model.TableNo = CbMasa.SelectedItem.ToString();
            model.PersonNumber = int.Parse(CbKisiSayisi.Text);
            model.Phone = TxtTelefon.Text;
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            Doldur();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int TiklananSatir = int.Parse(DgvListele.CurrentRow.Index.ToString());
            int AlinanID = int.Parse(DgvListele.Rows[TiklananSatir].Cells[0].Value.ToString());

            TBLRezervation model = db.TBLRezervation.Find(AlinanID);
            db.TBLRezervation.Remove(model);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            Doldur();

        }
    }
}

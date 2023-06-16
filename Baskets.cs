using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonu
{
    public partial class Baskets : Form
    {
        public Baskets()
        {
            InitializeComponent();
        }
       RestaurantDatabaseEntities1 db=new RestaurantDatabaseEntities1();
        DataTable dtSiparisler = new DataTable();
        DataTable dtOdenecekler = new DataTable();
        private void SiparisDoldur()
        {
            dtSiparisler.Rows.Clear();
            foreach (var item in db.TBLBasket.Where(x => x.TablesNo == LBLMasaNo.Text).ToList())
            {
                dtSiparisler.Rows.Add(item.id,
                    item.ProductName,
                    item.Piece,
                    Convert.ToDecimal(item.Price).ToString("N"));
            }
            DgvSiparisler.DataSource = dtSiparisler;

            decimal ToplamFiyat = 0;
            foreach (var item in db.TBLBasket.Where(x => x.TablesNo == LBLMasaNo.Text))
            {
                ToplamFiyat += Convert.ToDecimal(item.Price) * Convert.ToInt16(item.Piece);
            }
            LBLToplamFiyat.Text = ToplamFiyat.ToString("N");
        }

        private void Baskets_Load(object sender, EventArgs e)
        {
            dtSiparisler.Columns.Add("id");
            dtSiparisler.Columns.Add("Ürün");
            dtSiparisler.Columns.Add("Adet");
            dtSiparisler.Columns.Add("Fiyat");

            dtOdenecekler.Columns.Add("id");
            dtOdenecekler.Columns.Add("Ürün");
            dtOdenecekler.Columns.Add("Adet");
            dtOdenecekler.Columns.Add("Fiyat");

            DgvOdenecekler.DataSource = dtOdenecekler;

            SiparisDoldur();

            int i = 0;
            foreach (var item in db.TBLCategories.ToList())
            {
                LvKategoriler.Items.Add(item.CategoryName);
                LvKategoriler.Items[i].ImageKey = "Kategori.png";
                i++;
            }
        }

        private void LvKategoriler_DoubleClick(object sender, EventArgs e)
        {
            string Secilen = LvKategoriler.SelectedItems[0].Text;

            TBLCategories model = db.TBLCategories.Where(x => x.CategoryName == Secilen).First();

            // Select * From Products Where CategoriesId = model.id;

            LvUrunler.Items.Clear();
            int i = 0;
            foreach (var item in db.TBLProducts.Where(x => x.CategoriesId == model.id).ToList())
            {
                LvUrunler.Items.Add(item.ProductName);
                LvUrunler.Items[i].ImageKey = "Kategori.png";
                i++;
            }
        }

        private void LvUrunler_DoubleClick(object sender, EventArgs e)
        {
            string TiklananUrunAdi = LvUrunler.SelectedItems[0].Text;

            var StoktakiUrun = db.TBLProducts.Where(x => x.ProductName == TiklananUrunAdi).First();

            var SepettekiUrun = db.TBLBasket.Where(x => x.TablesNo == LBLMasaNo.Text && StoktakiUrun.ProductName == x.ProductName).FirstOrDefault();

            if (SepettekiUrun != null)
            {
                SepettekiUrun.Piece++;
                db.SaveChanges();
            }
            else
            {
                TBLBasket model = new TBLBasket();
                model.ProductName = StoktakiUrun.ProductName;
                model.Price = StoktakiUrun.Price;
                model.TablesNo = LBLMasaNo.Text;
                model.Piece = 1;
                db.TBLBasket.Add(model);
                db.SaveChanges();
            }
            SiparisDoldur();
        }

        private void DgvSiparisler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int UrunId = Convert.ToInt16(DgvSiparisler.Rows[e.RowIndex].Cells[0].Value.ToString());

            TBLBasket model = db.TBLBasket.Find(UrunId);
            if (model.Piece > 1)
            {
                model.Piece--;

            }
            else
            {
                db.TBLBasket.Remove(model);
            }
            db.SaveChanges();
            SiparisDoldur();

        }

        private void BtnHepsiniAktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtSiparisler.Rows.Count; i++)
            {
                dtOdenecekler.Rows.Add(
                    dtSiparisler.Rows[i]["id"].ToString(),
                    dtSiparisler.Rows[i]["Ürün"].ToString(),
                    dtSiparisler.Rows[i]["Adet"].ToString(),
                    dtSiparisler.Rows[i]["Fiyat"].ToString()
                    );
            }
            dtSiparisler.Rows.Clear();
            LBLToplamFiyat.Text = "0";

            decimal odenecekFiyat = 0;
            for (int i = 0; i < dtOdenecekler.Rows.Count; i++)
            {
                odenecekFiyat += Convert.ToDecimal(dtOdenecekler.Rows[i]["Fiyat"].ToString()) * Convert.ToDecimal(dtOdenecekler.Rows[i]["Adet"].ToString());
            }

            LBLOdenecekFiyat.Text = odenecekFiyat.ToString("N");
        }

        private void DgvOdenecekler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id = DgvOdenecekler.Rows[e.RowIndex].Cells[0].Value.ToString();

            var OdenecekUrun = dtOdenecekler.Select("id = " + Id + "");

            var SepettekiUrun = dtSiparisler.Select("id= " + OdenecekUrun[0]["id"] +"");

            if (SepettekiUrun.Count() == 0)
            {
                dtSiparisler.Rows.Add(
                    OdenecekUrun[0]["id"],OdenecekUrun[0]["Ürün"],1,OdenecekUrun[0]["Fiyat"]);
                if (int.Parse(OdenecekUrun[0]["Adet"].ToString()) > 1)
                {
                    OdenecekUrun[0]["Adet"] = int.Parse(OdenecekUrun[0]["Adet"].ToString()) - 1;
                }
                else
                {
                    dtOdenecekler.Rows.Remove(OdenecekUrun[0]);
                }
            }
            else
            {
                if (int.Parse(OdenecekUrun[0]["Adet"].ToString()) > 1)
                {
                    SepettekiUrun[0]["Adet"] = int.Parse(SepettekiUrun[0]["Adet"].ToString()) + 1;
                    OdenecekUrun[0]["Adet"] = int.Parse(OdenecekUrun[0]["Adet"].ToString()) - 1;
                }
                else
                {
                    if (SepettekiUrun.Count() == 0)
                    {
                        dtSiparisler.Rows.Add(OdenecekUrun[0]["id"],OdenecekUrun[0]["Ürün"],1,OdenecekUrun[0]["Fiyat"] );
                        dtOdenecekler.Rows.Remove(OdenecekUrun[0]);
                    }
                    else
                    {
                        SepettekiUrun[0]["Adet"] = int.Parse(SepettekiUrun[0]["Adet"].ToString()) + 1;
                        dtOdenecekler.Rows.Remove(OdenecekUrun[0]); 
                    }
                }
            }

            decimal odenecekFiyat = 0;
            for (int i = 0; i < dtOdenecekler.Rows.Count; i++)
            {
                odenecekFiyat += Convert.ToDecimal(dtOdenecekler.Rows[i]["Fiyat"].ToString()) * Convert.ToDecimal(dtOdenecekler.Rows[i]["Adet"].ToString());
            }

            LBLOdenecekFiyat.Text = odenecekFiyat.ToString("N");

            decimal ToplamFiyat = 0;
            for (int i = 0; i < dtSiparisler.Rows.Count; i++)
            {
                ToplamFiyat += Convert.ToDecimal(dtSiparisler.Rows[i]["Fiyat"].ToString()) * Convert.ToDecimal(dtSiparisler.Rows[i]["Adet"].ToString());
            }

            LBLToplamFiyat.Text = ToplamFiyat.ToString("N");
        }

        private void DgvSiparisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id = DgvSiparisler.Rows[e.RowIndex].Cells[0].Value.ToString();

            var SiparisUrunu = dtSiparisler.Select("id= " + Id + "");

            var OdenecekUrun = dtOdenecekler.Select("Id=" + Id + "");

            if (OdenecekUrun.Count()!=0)
            {
                SiparisUrunu[0]["Adet"] = int.Parse(SiparisUrunu[0]["Adet"].ToString()) + 1;

            }
            else
            {
                dtSiparisler.Rows.Remove(SiparisUrunu[0]);

            }



        }

        private void BtnOdemeSifirla_Click(object sender, EventArgs e)
        {
            SiparisDoldur();
            dtOdenecekler.Clear();


        }

        private void BtnOdeme_Click(object sender, EventArgs e)
        {
            if (DgvOdenecekler.Rows.Count>0&& CbOdemeTipi.SelectedIndex!=-1)
            {
                TBLOrders orders = new TBLOrders();
                orders.TotalPrice = decimal.Parse(LBLToplamFiyat.Text);
                orders.PaymentDate = DateTime.Now;
                orders.Discount = 0;
                orders.PaymentType = (CbOdemeTipi.Text == "Kredi Kartı" ? true : false);
                orders.PersonalsId = 0;
                orders.TablesNo=LBLMasaNo.Text;
                db.TBLOrders.Add(orders);
                db.SaveChanges();


                int SiparisNo=db.TBLOrders.OrderByDescending(x=>x.id).First().id;

                for (int i = 0; i < dtOdenecekler.Rows.Count; i++)
                {
                    int Id = int.Parse(dtOdenecekler.Rows[i]["id"].ToString());
                    int Adet = int.Parse(dtOdenecekler.Rows[i]["Adet"].ToString());

                    TBLBasket model = db.TBLBasket.Find(Id);
                    if (model.Piece>Adet)
                    {
                        model.Piece -= Adet;
                    }
                   
                    else if (model.Piece==Adet)
                    {
                        db.TBLBasket.Remove(model);

                    }
                    db.SaveChanges() ;
                    TBLOrderDetails orderDetails = new TBLOrderDetails();
                    orderDetails.Price = model.Price;   
                    orderDetails.ProductName = model.ProductName;
                    orderDetails.Piece = Adet;
                    orderDetails.OrdersId = SiparisNo;
                    db.TBLOrderDetails.Add(orderDetails);
                    db.SaveChanges();

                }

                MessageBox.Show("Ödeme Gerçekletirildi");
                SiparisDoldur();
                dtOdenecekler.Clear();
                

            }
            else
            {
                MessageBox.Show("Lütfen Ödeme Yöntemini yada ödenecek ürünü seçiniz");
            }
        }
    }
}

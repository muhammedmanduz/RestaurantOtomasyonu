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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MsKategoriler_Click(object sender, EventArgs e)
        {
            Categories Frm = new Categories();
            AcikKapaliKontrolu(Frm);
        }

        //Form Açık Yada Kapalı olduğunu Kontrol edip Ona Göre açıksa Ön Plana getirme, Kapalı ise Açma işlemlerini gerçekleştiren Metot

        private void AcikKapaliKontrolu(Form Frm)
        {
            bool Durum = false;

            foreach (var item in MdiChildren)
            {
                if (item.Text == Frm.Text)
                {
                    Durum = true;
                }
            }
            if (Durum)
            {
                Frm.Activate();
            }
            else
            {
                Frm.MdiParent = this;
                Frm.Show();
            }
        }

        private void MsUrunler_Click(object sender, EventArgs e)
        {
            Products Frm = new Products();
            AcikKapaliKontrolu(Frm);
        }

        private void MsMasalar_Click(object sender, EventArgs e)
        {
            Tables Frm = new Tables();
            AcikKapaliKontrolu(Frm);
        }

        private void MsSiparisler_Click(object sender, EventArgs e)
        {
            TableList Frm = new TableList();
            AcikKapaliKontrolu(Frm);
        }

        private void MsKasa_Click(object sender, EventArgs e)
        {
            Orders Frm = new Orders();
            AcikKapaliKontrolu(Frm);
        }

        private void MsPersoneller_Click(object sender, EventArgs e)
        {
            Personals Frm = new Personals();
            AcikKapaliKontrolu(Frm);
        }

        private void MsRezervasyonlar_Click(object sender, EventArgs e)
        {
            Rezervations Frm = new Rezervations();
            AcikKapaliKontrolu(Frm);
        }

        private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {


        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2)
            {
                Categories frm = new Categories();
                AcikKapaliKontrolu(frm);
            }
            else if (e.KeyCode==Keys.F3) 
            { Products frm = new Products();
                AcikKapaliKontrolu(frm);
            }
            else if (e.Modifiers==Keys.Control&& e.KeyCode==Keys.N) 
            {
                Tables frm = new Tables();
                AcikKapaliKontrolu(frm);
            }

        }
    }
}

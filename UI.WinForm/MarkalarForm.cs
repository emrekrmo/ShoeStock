using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.WinForm
{
    public partial class MarkalarForm : Form
    {
        Marka seciliMarka = null;
        MarkaLabel seciliLabel = null;
        public MarkalarForm()
        {
            InitializeComponent();
        }

        internal void MarkaLabelEkle(MarkaLabel lbl) //MarkaLabel ile aynı seviye olması için internal oldu.
        {
            lbl.Click += Marka_Click;
            flowLayoutPanel1.Controls.Add(lbl);
        }

        private void MarkalarForm_Load(object sender, EventArgs e)
        {
            MarkaRepository rep = new MarkaRepository();
            List<Marka> hepsi = rep.TumMarkalar();

            foreach (var item in hepsi)
            {
                MarkaLabel lbl = new MarkaLabel();
                lbl.MarkaId = item.Id;
                lbl.Text = item.MarkaAdi;

                //Label lbl = new Label() //üstteki ile aynı
                //{
                //    Text = item.MarkaAdi
                //};
                lbl.Click += Marka_Click;

                flowLayoutPanel1.Controls.Add(lbl);
            }
        }
        //birşeyi object içine atmaya boxin, cast ile çıkarmaya unboxing denir
        private void Marka_Click(object sender, EventArgs e)
        {
            foreach (MarkaLabel item in flowLayoutPanel1.Controls)
            {
                item.SeciliMi = false;
            }
            MarkaLabel tiklanan = (MarkaLabel)sender;

            seciliLabel = tiklanan;

            //tiklanan.SeciliMi = true; //taşıma gerekli değildi. nasıl olacağını görmek için MarkaLabel a taşındı
            seciliMarka = new Marka()
            {
                Id = tiklanan.MarkaId,
                MarkaAdi = tiklanan.Text
            };
            txtMarkalar.Text = seciliLabel.Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MarkaRepository rep = new MarkaRepository();
            rep.MarkaSil(seciliMarka.Id);

            flowLayoutPanel1.Controls.Remove(seciliLabel);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (seciliLabel == null)
            {
                MessageBox.Show("Marka seçin");
                return; //metottan çıkar
            }

            panel1.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            seciliMarka.MarkaAdi = txtMarkalar.Text;

            MarkaRepository rep = new MarkaRepository();
            if (rep.MarkaGuncelle(seciliMarka))
            {
                seciliLabel.Text = txtMarkalar.Text;
                MessageBox.Show("Güncellendi");
            }
            else
            {
                MessageBox.Show("Hata oluştu");
            }
        }
    }
}

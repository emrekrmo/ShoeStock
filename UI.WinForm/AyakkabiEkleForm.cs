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
    public partial class AyakkabiEkleForm : Form
    {
        MarkaRepository markaRep = new MarkaRepository();
        AyakkabiRepository ayakkabiRep = new AyakkabiRepository();
        public AyakkabiEkleForm()
        {
            InitializeComponent();
        }

        private void AyakkabiEkleForm_Load(object sender, EventArgs e)
        {
            cmbMarka.DisplayMember = "MarkaAdi";
            cmbMarka.ValueMember = "Id";
            cmbMarka.DataSource = markaRep.TumMarkalar();

            Type t = typeof(Cins);
            string[] secenekler = Enum.GetNames(t); //t yerine sadece typeof(Cins) yazabilirdik
            cmbCins.DataSource = secenekler;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ayakkabi a = new Ayakkabi();
            a.MarkaId = (int)cmbMarka.SelectedValue;
            a.Model = txtModel.Text;
            a.Cins = (Cins)cmbCins.SelectedIndex;
            a.Cinsiyet = rbKadin.Checked ? Cinsiyet.Kadın : rbErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Unisex;

            bool sonuc = ayakkabiRep.AyakkabiEkle(a);
            if (sonuc)
            {
                AyakkabilarForm f = (AyakkabilarForm)FormHelper.Create(typeof(AyakkabilarForm));

                f.Yenile();

                MessageBox.Show("Kaydedildi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }
    }
}

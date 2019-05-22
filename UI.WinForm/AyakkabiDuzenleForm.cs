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
    public partial class AyakkabiDuzenleForm : Form
    {
        MarkaRepository markaRep = new MarkaRepository();
        AyakkabiRepository ayakkabiRep = new AyakkabiRepository();
        public Ayakkabi ayakkabi;
        public AyakkabiDuzenleForm()
        {
            InitializeComponent();
        }

        private void AyakkabiDuzenleForm_Load(object sender, EventArgs e)
        {
            cmbMarka.DisplayMember = "MarkaAdi";
            cmbMarka.ValueMember = "Id";
            cmbMarka.DataSource = markaRep.TumMarkalar();

            Type t = typeof(Cins);
            string[] secenekler = Enum.GetNames(t); //t yerine sadece typeof(Cins) yazabilirdik
            cmbCins.DataSource = secenekler;

            cmbMarka.SelectedValue = ayakkabi.MarkaId;
            cmbCins.SelectedIndex = (int)ayakkabi.Cins; //Cins enum olduğu için index ini alıyoruz
            txtModel.Text = ayakkabi.Model;
            rbKadin.Checked = ayakkabi.Cinsiyet == Cinsiyet.Kadın ? true : false;
            //rbKadin.Checked = ayakkabi.Cinsiyet == Cinsiyet.Kadın; //aynı
            rbErkek.Checked = ayakkabi.Cinsiyet == Cinsiyet.Erkek;
            rbUnisex.Checked = ayakkabi.Cinsiyet == Cinsiyet.Unisex;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ayakkabi sonHali = new Ayakkabi();     

            sonHali.MarkaId = (int)cmbMarka.SelectedValue;
            sonHali.Id = ayakkabi.Id;
            sonHali.Model = txtModel.Text;
            sonHali.Cins = (Cins)cmbCins.SelectedIndex;
            sonHali.Cinsiyet = rbKadin.Checked ? Cinsiyet.Kadın : rbErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Unisex;

            ayakkabiRep.AyakkabiGuncelle(sonHali);

            bool olduMu = ayakkabiRep.AyakkabiGuncelle(sonHali);

            if (olduMu)
            {
                AyakkabilarForm f = (AyakkabilarForm)FormHelper.Create(typeof(AyakkabilarForm));
                f.Yenile();
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }
    }
}

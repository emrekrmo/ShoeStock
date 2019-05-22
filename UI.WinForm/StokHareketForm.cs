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
    public partial class StokHareketForm : Form
    {
        MarkaRepository markaRep = new MarkaRepository();
        AyakkabiRepository ayakkabiRep = new AyakkabiRepository();
        public StokHareketForm()
        {
            InitializeComponent();
        }
        private void StokHareketForm_Load(object sender, EventArgs e)
        {
            cmbMarka.ValueMember = "Id";
            cmbMarka.DisplayMember = "MarkaAdi";
            cmbMarka.DataSource = markaRep.TumMarkalar();
        }
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMarka.SelectedItem != null)
            {
                cmbAyakkabi.DisplayMember = "Model";
                cmbAyakkabi.ValueMember = "Id";
                cmbAyakkabi.DataSource = ayakkabiRep.MarkayaGoreGetir((int)cmbMarka.SelectedValue);
            }
        }
        StokManager mng = new StokManager();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            StokHareketViewModel vm = new StokHareketViewModel();

            vm.AyakkabiId = (int)cmbAyakkabi.SelectedValue;
            vm.Adet = (int)nudAdet.Value;
            vm.No = (byte)nudAdet.Value;
            vm.Tip = rbGiris.Checked ? StokHareketIslemTipi.Giris : StokHareketIslemTipi.Cikis;

            bool olduMu = mng.StokHareketiOlustur(vm);

            if (olduMu)
            {
                MessageBox.Show("Kaydedildi");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}

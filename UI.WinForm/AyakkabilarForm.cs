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
    public partial class AyakkabilarForm : Form
    {
        AyakkabiRepository rep = new AyakkabiRepository();
        public AyakkabilarForm()
        {
            InitializeComponent();
        }
        public void Yenile()
        {
            lbAyakkabilarForm.DataSource = null; //datasource yapılan yerlerde verinin değişmesi için dolu olan tabloyu boşaltmak lazım. yoksa dataSource işlem yapmaz
            lbAyakkabilarForm.DisplayMember = "ListBoxGosterim";
            lbAyakkabilarForm.DataSource = rep.TumAtakkabilar();
        }

        private void AyakkabilarForm_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void lbAyakkabilarForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAyakkabilarForm.SelectedItem != null) //veri ilk yüklendiğinde çalışmaması için önlem
            {
                groupBox1.Visible = true;
                Ayakkabi a = (Ayakkabi)lbAyakkabilarForm.SelectedItem;
                lblCins.Text = a.Cins.ToString();
                lblCinsiyet.Text = a.Cinsiyet.ToString();
                lblModel.Text = a.Model;
                lblMarka.Text = a.Marka.MarkaAdi;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = ((Ayakkabi)lbAyakkabilarForm.SelectedItem).Id;
            if (rep.AyakkabiSil(id))
            {
                Yenile();
                groupBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Hata");
            }
            //AyakkabiRepository rep = new AyakkabiRepository();
            //Ayakkabi a = new Ayakkabi();
            //a = (Ayakkabi)lbAyakkabilarForm.SelectedItem;
            //rep.AyakkabiSil(a.Id);
            //Yenile();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lbAyakkabilarForm.SelectedItem != null)
            {
            AyakkabiDuzenleForm f = (AyakkabiDuzenleForm)FormHelper.Create(typeof(AyakkabiDuzenleForm));
            f.ayakkabi = (Ayakkabi)lbAyakkabilarForm.SelectedItem;
            f.Show();
            }
            else
            {
                MessageBox.Show("Ayakkabi Secin");
            }
        }
    }
}

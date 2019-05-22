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
    public partial class MarkaEkleForm : Form
    {
        public MarkaEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Marka m = new Marka();
            m.MarkaAdi = txtMarkaAdi.Text;

            //Marka m = new Marka() //üsttekinin farklı hali
            //{
            //    MarkaAdi = txtMarkaAdi.Text
            //};

            MarkaRepository rep = new MarkaRepository();
            int mid = 0;
            bool result = rep.MarkaEkle(m, out mid);

            if (result)
            {
                MarkaLabel lbl = new MarkaLabel();
                lbl.Text = txtMarkaAdi.Text;
                lbl.MarkaId = 0;

                MarkalarForm f = (MarkalarForm)Application.OpenForms["MarkalarForm"];
                if (f != null)
                {
                    f.MarkaLabelEkle(lbl);
                }

                txtMarkaAdi.Clear();
                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }
    }
}

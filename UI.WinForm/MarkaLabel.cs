using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.WinForm
{
    class MarkaLabel : Label
    {
        public int MarkaId { get; set; }
        private bool _seciliMi;

        public bool SeciliMi
        {
            get { return _seciliMi; }
            set
            {
                if (value)
                {
                    this.BackColor = Color.Yellow;
                }
                else
                {
                    this.BackColor = Color.White;
                    //this.BackColor = SystemColors.Control; //sistem rengine döndürür
                }
                _seciliMi = value;
            }
        }
        public MarkaLabel()
        {
            Width = 250;
            Height = 50;
            Margin = new Padding(10);
            BackColor = Color.White;
            Font = new Font(FontFamily.GenericSansSerif, 22f);
        }
        protected override void OnClick(EventArgs e)
        {
            SeciliMi = !SeciliMi;
            base.OnClick(e);
        }
    }
}

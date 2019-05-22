using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ayakkabi
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public Cins Cins { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public int MarkaId { get; set; } //Tablolar arası ilişkiyi temsil ediyor
        public Marka Marka { get; set; }
        public string ListBoxGosterim
        {
            get
            {
                return Marka.MarkaAdi + " " + Model;
            }
        }
    }
    public enum Cins
    {
        Diğer, Süet, Deri
    }
    public enum Cinsiyet
    {
        Unisex, Kadın, Erkek
    }
}

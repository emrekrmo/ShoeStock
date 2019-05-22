using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AyakkabiRepository
    {
        public List<Ayakkabi> TumAtakkabilar()
        {
            List<Ayakkabi> liste = new List<Ayakkabi>();

            DataTable dtbl = DataHelper.TabloGetir(@"
                select a.*, m.MarkaAdi 
                from tblAyakkabi as a 
                inner join tblMarka as m on m.Id = a.MarkaId");
            foreach (DataRow item in dtbl.Rows)
            {
                Ayakkabi a = new Ayakkabi();
                a.Id = (int)item["Id"];
                a.MarkaId = (int)item["MarkaId"];
                a.Model = item["Model"].ToString();
                a.Cinsiyet = (Cinsiyet)item["Cinsiyet"];
                a.Cins = (Cins)item["Cins"];

                a.Marka = new Marka();
                a.Marka.Id = (int)item["MarkaId"];
                a.Marka.MarkaAdi = item["MarkaAdi"].ToString();

                liste.Add(a);
            }
            return liste;
        }
        public bool AyakkabiEkle(Ayakkabi yeni)
        {
            string sql = "insert into tblAyakkabi(MarkaId, Model, Cinsiyet, Cins) values(@markaId, @model, @cinsiyet, @cins)";

            SqlParameter p1 = new SqlParameter("markaId", yeni.MarkaId);
            SqlParameter p2 = new SqlParameter("model", yeni.Model);
            SqlParameter p3 = new SqlParameter("cinsiyet", yeni.Cinsiyet);
            SqlParameter p4 = new SqlParameter("cins", yeni.Cins);

            return DataHelper.KomutCalistir(sql, p1, p2, p3, p4);
        }
        public bool AyakkabiSil(int id)
        {
            string sql = "delete from tblAyakkabi where Id = @id";

            SqlParameter p1 = new SqlParameter("id", id);

            return DataHelper.KomutCalistir(sql, p1);
        }
        public bool AyakkabiGuncelle(Ayakkabi yeni)
        {
            string sql = "update tblAyakkabi set MarkaId = @markaId, Model = @model, Cinsiyet = @cinsiyet, Cins = @cins where Id = @id";

            SqlParameter p1 = new SqlParameter("markaId", yeni.MarkaId);
            SqlParameter p2 = new SqlParameter("model", yeni.Model);
            SqlParameter p3 = new SqlParameter("cinsiyet", yeni.Cinsiyet);
            SqlParameter p4 = new SqlParameter("cins", yeni.Cins);
            SqlParameter p5 = new SqlParameter("id", yeni.Id);

            return DataHelper.KomutCalistir(sql, p1, p2, p3, p4, p5);
        }
        public List<Ayakkabi> MarkayaGoreGetir(int markaId)
        {
            string sql = "select * from tblAyakkabi where MarkaId = " + markaId;
            //SqlParameter p1 = new SqlParameter("id", markaId);

            List<Ayakkabi> liste = new List<Ayakkabi>();

            DataTable dtbl = DataHelper.TabloGetir(sql);
            foreach (DataRow item in dtbl.Rows)
            {
                Ayakkabi a = new Ayakkabi();
                a.Id = (int)item["Id"];
                a.MarkaId = (int)item["MarkaId"];
                a.Model = item["Model"].ToString();
                a.Cinsiyet = (Cinsiyet)item["Cinsiyet"];
                a.Cins = (Cins)item["Cins"];

                //a.Marka = new Marka();
                //a.Marka.Id = (int)item["MarkaId"];
                //a.Marka.MarkaAdi = item["MarkaAdi"].ToString();

                liste.Add(a);
            }
            return liste;
        }
    }
}
using DAL;
using Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MarkaRepository //sadece CRUD işlemleri yapacağımız için MarkaRepository seçtik, MarkaManager yerine
    {
        public List<Marka> TumMarkalar()
        {
            DataTable dtbl = DataHelper.TabloGetir("select * from tblMarka");

            List<Marka> liste = new List<Marka>();

            foreach (DataRow item in dtbl.Rows)//DataRow yazdık ki indexleme yapılabilsin
            {
                Marka m = new Marka();
                m.Id = (int)item["Id"];
                m.MarkaAdi = item["MarkaAdi"].ToString();
                liste.Add(m);
            }
            return liste;
        }
        public bool MarkaEkle(Marka yeni, out int id) //ilk değeri olmayan ve gelen değeri istediğimiz de out diyoruz
        {
            string sql = "insert into tblMarka(MarkaAdi) values(@markaAdi)";
            SqlParameter p1 = new SqlParameter("markaAdi", yeni.MarkaAdi);

            bool result = DataHelper.KomutCalistir(sql, p1);
            if (result)
            {
                //string sql2 = "select Scope_Identity()"; //aynı
                /*string sql2 = "select @@Identity"*/;
                string sql2 = "select max(Id) from tblMarka";
                DataTable dtbl = DataHelper.TabloGetir(sql2);
                id = (int)dtbl.Rows[0][0];
            }
            else
            {
                id = -1;
            }
            return result;
        }
        public bool MarkaSil(int id)
        {
            string sql = "delete from tblMarka where Id = @id";
            SqlParameter p1 = new SqlParameter("id", id);

            return DataHelper.KomutCalistir(sql, p1);
        }
        public bool MarkaGuncelle(Marka yeni)
        {
            string sql = "update tblMarka set MarkaAdi = @markaAdi where Id = @id";
            SqlParameter p1 = new SqlParameter("id", yeni.Id);
            SqlParameter p2 = new SqlParameter("markaAdi", yeni.MarkaAdi);

            return DataHelper.KomutCalistir(sql, p1, p2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DataHelper
    {
        private static SqlConnection con = new SqlConnection(); //private yaptık çünkü sadece DataHelper SQL ile iletişim kursun. WFA da static yapıyoruz... web de değil
        static DataHelper()
        {
            con.ConnectionString = "Server = .; Database = AyakkabiDB; User Id = WissenCalisma; Password = Wissen2019";
        }
        //static ise: DataHelper.Tablogetir("Sorgumuz");
        //statik değilse: DataHelper dh = new DataHelper(); dh.TabloGetir("Sorgumuz");
        public static DataTable TabloGetir(string sql)
        {
            //Disconnected mimari
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable dtbl = new DataTable();
            dap.Fill(dtbl);
            return dtbl;
        }
        public static bool KomutCalistir(string sql, params SqlParameter[] parameters)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddRange(parameters);
            int enq = cmd.ExecuteNonQuery();
            con.Close();
            return enq > 0;
        }
    }
}

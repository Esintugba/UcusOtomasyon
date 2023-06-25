using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace UcusOtomasyon
{
    public class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=FIRUZE\SQLEXPRESS;Initial Catalog=DbUcus;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}

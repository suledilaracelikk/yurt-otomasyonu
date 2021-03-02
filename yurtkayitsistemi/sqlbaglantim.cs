using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace yurtkayitsistemi
{
    public class sqlbaglantim
    {
        public SqlConnection baglanti() 
        {

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-J541L4J\\MSSQLSERVER02;Initial Catalog=yurtotomasyonu;Integrated Security=True");
            
            baglan.Open();

            return baglan;

        }

    }
}

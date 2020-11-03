using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace InfoStorage
{
    public static  class ClientInfoStorageDB
    {
         public static SqlConnection GetConnection()
        {
            string connectionS = ConfigurationManager.ConnectionStrings["InfoStorageConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionS);
            return conn;
        }
    }
}

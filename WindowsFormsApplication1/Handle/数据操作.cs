using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Handle
{
    class 数据操作
    {
        static string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        
        static public int 操作(string sql)
        {
            SqlConnection con = new SqlConnection(connStr);

            con.Open();

            SqlCommand myco = new SqlCommand(sql, con);
            int flag = myco.ExecuteNonQuery();

            return flag;
        }
    }
}

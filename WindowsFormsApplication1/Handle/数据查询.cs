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
    class 数据查询
    {
        static string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;

        static public DataSet 查询(string sql)
        {
            SqlConnection con = new SqlConnection(connStr);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);

            return ds;
        }
        
    }
}

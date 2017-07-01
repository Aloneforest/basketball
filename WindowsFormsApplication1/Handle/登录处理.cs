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
    class 登录处理
    {
        static string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;

        static public bool 检查(string uname, string pwd, int id)
        {
            SqlConnection con = new SqlConnection(connStr);

            string sql = "";
            if (id == 1)
                sql = "select tmpwd from Team where tmnum = '" + uname + "'";
            else if (id == 2)
                sql = "select ppwd from Player where pnum = '" + uname + "'";
            else if (id == 3)
                sql = "select fpwd from Fans where fnum = '" + uname + "'";
            else if (id == 4)
                sql = "select aapwd from AAdm where aanum = '" + uname + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                string _pwd = (string)ds.Tables[0].Rows[0][0];
                _pwd = _pwd.Trim();

                if (pwd == _pwd)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}

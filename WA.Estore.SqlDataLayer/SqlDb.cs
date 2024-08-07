using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.Estore.SqlDataLayer
{
    public class SqlDb
    {
        public string GetconnString(string key)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[key].ToString();
        }

        public SqlConnection Getconn(string key)
        {
            string connStr = GetconnString(key);
            return new SqlConnection(connStr);
        }
    }
}

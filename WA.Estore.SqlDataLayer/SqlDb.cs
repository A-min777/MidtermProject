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
        public static string GetconnString(string key)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[key].ToString();
        }

        public SqlConnection Getconn(string key)
        {
            string connStr = GetconnString(key);
            return new SqlConnection(connStr);
        }
		public T Get<T>(string key, string sql, Func<SqlDataReader, T> func)
		{			
			using (var conn = Getconn(key))
			{
				conn.Open();

				using (SqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					SqlDataReader reader = cmd.ExecuteReader();
					return func(reader);
				}
			}
			
		}

		public List<T> Select<T>(string key, string sql, Func<SqlDataReader,T> func)
        {
            List<T> list = new List<T>();
            using (var conn = Getconn(key))
            {
                conn.Open();

                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        T item = func(reader);
                        list.Add(item);
                    }
                }
            }
            return list;
        }
		public String ExcuteScalar(string key, string sql, SqlParameter[] parameters = null)
		{
			using (var conn = Getconn(key))
			{
				conn.Open();

				using (SqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					if (parameters != null && parameters.Length > 0)
					{
						cmd.Parameters.AddRange(parameters);
					}
					object result = cmd.ExecuteScalar();
					return result.ToString();
				}
			}
		}
		public void ExecuteNonQuery(string key, string sql, SqlParameter[] parameters = null)
		{
			using (var conn = Getconn(key))
			{
				conn.Open();

				using (SqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					if (parameters != null && parameters.Length > 0)
					{
						cmd.Parameters.AddRange(parameters);
					}
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}

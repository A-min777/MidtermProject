using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.Estore.SqlDataLayer
{
	public class MemberRepo
	{
		private readonly string _connStr;

		public MemberRepo()
        {
			_connStr = SqlDb.GetconnString("default");

		}
        public Member Get(int id)
		{
			var sql = $"SELECT Name , Age , Gender , Birthday From Members WHERE Id = {id}";

			using (var conn = new SqlConnection(_connStr))
			{
				return conn.QueryFirstOrDefault<Member>(sql, new { Id = id });
			}
		}

		public Member Get(string MemberName)
		{
			string sql = "SELECT Id FROM Members WHERE Name = @Name";

			using (var conn = new SqlConnection(_connStr))
			{
				return conn.QueryFirstOrDefault<Member>(sql, new { Name = MemberName });
			}
		}

		public void Update(Member member)
		{
			string sql = "UPDATE Members SET Name=@Name, Age=@Age, Gender=@Gender, Birthday=@Birthday  WHERE Id = @Id";

			using (var conn = new SqlConnection(_connStr))
			{
				conn.Execute(sql, member);
			}
		}
	}
}

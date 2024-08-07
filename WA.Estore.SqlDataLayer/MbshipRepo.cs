using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WA.Estore.SqlDataLayer
{
	public class MbshipRepo
	{
		public List<MbshipsDto> GetAll()
		{
			var sql = $"SELECT * FROM Memberships  ORDER By displayOrder";
			var db = new SqlDb();

			Func<SqlDataReader, MbshipsDto> func = (reader) =>
			{
				int id = (int)reader["Id"];
				string mbshipLv = reader["MembershipLevel"].ToString();
				int displayOrder = (int)reader["DisplayOrder"];

				return new MbshipsDto { Id = id, MembershipLevel = mbshipLv, DisplayOrder = displayOrder };
			};
			List<MbshipsDto> mbshipsDtos = db.Select("default", sql, func);
			return mbshipsDtos;
		}
		public MbshipsDto GetData(int id)
		{
			var sql = $"SELECT * FROM Memberships Where id = {id}";
			var db = new SqlDb();

			Func<SqlDataReader, MbshipsDto> func = (reader) =>
			{
				if (reader.Read()) // 確保有讀取到資料
				{
					id = (int)reader["Id"];
					string mbshipLv = reader["MembershipLevel"].ToString();
					int displayOrder = (int)reader["DisplayOrder"];

					return new MbshipsDto { Id = id, MembershipLevel = mbshipLv, DisplayOrder = displayOrder };
				}
				return new MbshipsDto { Id = 1, MembershipLevel = "ERROR", DisplayOrder = 00 };
			};
			MbshipsDto mbships = db.Get("default", sql, func);
			return mbships;
		}
		public void Update(MbshipsDto dto)
		{
			var db = new SqlDb();
			var sql = $"UPDATE MemberShips SET MembershipLevel = @MembershipLevel, DisplayOrder = @DisplayOrder WHERE Id = @Id";

			var parameters = new SqlParameter[]
			{
				new SqlParameter("@MembershipLevel", dto.MembershipLevel),
				new SqlParameter("@DisplayOrder", dto.DisplayOrder),
				new SqlParameter("Id", dto.Id),
			};
			db.ExecuteNonQuery("default", sql, parameters);
		}
		public bool IsExists(string name, int id = -1)
		{
			var sql = $"SELECT COUNT(*) FROM Memberships WHERE MembershipLevel = @MembershipLevel AND ID!={id}";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter ("@MembershipLevel",name),
			};

			var db = new SqlDb();


			var result = db.ExcuteScalar("default", sql, parameters);
			return result == "1";
		}


	}
}

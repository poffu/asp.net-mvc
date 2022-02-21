using LabeledData.Models;
using LabeledData.Utility;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;
using Npgsql;

namespace LabeledData.Dao.Impl
{
	public class MstCategoryDaoImpl : IMstCategoryDao
	{
		private LabeledDataContext labeledDataContext;
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public MstCategoryDaoImpl()
		{
			labeledDataContext = new LabeledDataContext();
		}

		public List<MstCategoryDto> GetAllListCategory()
		{
			List<MstCategoryDto> mstCategoryList = new List<MstCategoryDto>();
			StringBuilder sql = new StringBuilder();
			using (NpgsqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT m.*, e.name AS type FROM mst_category m");
						sql.AppendLine(" INNER JOIN mst_english_type AS e");
						sql.AppendLine(" ON m.tag_type = e.tag_type");
						NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), conn);
						var reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							MstCategoryDto mstCategoryDto = GetMstCategoryDto(reader);
							mstCategoryDto.Type = reader["type"].ToString();
							mstCategoryList.Add(mstCategoryDto);
						}
					}
				}
				catch (Exception e)
				{
					logger.Error(string.Format("{0}:: Sql={1} - Error:{2}", Common.GetMethodInfor(), sql, e.Message));
					throw;
				}
				finally
				{
					labeledDataContext.CloseConnection(conn);
				}
			}
			return mstCategoryList;
		}

		public int GetTotalCategory(string name, int tagType)
		{
			int totalCategory = 0;
			StringBuilder sql = new StringBuilder();
			using (NpgsqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT COUNT(*) FROM mst_category m");
						sql.AppendLine(" INNER JOIN mst_english_type AS e");
						sql.AppendLine(" ON m.tag_type = e.tag_type");
						sql.AppendLine(" WHERE UPPER(m.name) LIKE UPPER(@name)");
						if (tagType != -1)
						{
							sql.Append(" AND m.tag_type=@tagType");
						}
						NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), conn);
						cmd.Parameters.AddWithValue("@name", string.Format("%{0}%", Common.EncodeWildCard(name)));
						if (tagType != -1)
						{
							cmd.Parameters.AddWithValue("@tagType", tagType);
						}
						totalCategory = Convert.ToInt32(cmd.ExecuteScalar());
					}
				}
				catch (Exception e)
				{
					logger.Error(string.Format("{0}:: Sql={1} - Error:{2}", Common.GetMethodInfor(), sql, e.Message));
					throw;
				}
				finally
				{
					labeledDataContext.CloseConnection(conn);
				}
			}
			return totalCategory;
		}

		public List<MstCategoryDto> GetAllCategory(string name, int tagType, int limitRecord, int offset)
		{
			List<MstCategoryDto> mstCategoryList = new List<MstCategoryDto>();
			StringBuilder sql = new StringBuilder();
			using (NpgsqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT m.*, e.name AS type FROM mst_category m");
						sql.AppendLine(" INNER JOIN mst_english_type AS e");
						sql.AppendLine(" ON m.tag_type = e.tag_type");
						sql.AppendLine(" WHERE UPPER(m.name) LIKE UPPER(@name)");
						if (tagType != -1)
						{
							sql.Append(" AND m.tag_type=@tagType");
						}
						sql.AppendLine(" ORDER BY e.tag_type ASC, LOWER(m.name) ASC");
						sql.AppendLine(" LIMIT @limit OFFSET @offset");
						NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), conn);
						cmd.Parameters.AddWithValue("@name", string.Format("%{0}%", Common.EncodeWildCard(name)));
						if (tagType != -1)
						{
							cmd.Parameters.AddWithValue("@tagType", tagType);
						}
						cmd.Parameters.AddWithValue("@limit", limitRecord);
						cmd.Parameters.AddWithValue("@offset", offset);
						var reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							MstCategoryDto mstCategoryDto = GetMstCategoryDto(reader);
							mstCategoryDto.Type = reader["type"].ToString();
							mstCategoryList.Add(mstCategoryDto);
						}
					}
				}
				catch (Exception e)
				{
					logger.Error(string.Format("{0}:: Sql={1} - Error:{2}", Common.GetMethodInfor(), sql, e.Message));
					throw;
				}
				finally
				{
					labeledDataContext.CloseConnection(conn);
				}
			}
			return mstCategoryList;
		}

		public Dictionary<int, string> GetAllListType()
		{
			Dictionary<int, string> typeList = new Dictionary<int, string>();
			StringBuilder sql = new StringBuilder();
			using (NpgsqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT DISTINCT * FROM mst_english_type AS e");
						sql.AppendLine(" ORDER BY e.tag_type ASC");
						NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), conn);
						var reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							typeList.Add(Common.ConvertStringToInt(reader["tag_type"].ToString(), -1), reader["name"].ToString());
						}
					}
				}
				catch (Exception e)
				{
					logger.Error(string.Format("{0}:: Sql={1} - Error:{2}", Common.GetMethodInfor(), sql, e.Message));
					throw;
				}
				finally
				{
					labeledDataContext.CloseConnection(conn);
				}
			}
			return typeList;
		}

		public bool CheckExistName(int id, string name)
		{
			bool check = false;
			List<MstCategoryDto> mstCategoryList = GetAllListCategory().Where(x => x.Name.ToLower().Equals(name.ToLower()) && x.Id != id).ToList();
			if (mstCategoryList.Count > 0)
			{
				check = true;
			}
			return check;
		}

		public void InsertCategory(MstCategoryDto mstCategoryDto)
		{
			StringBuilder sql = new StringBuilder();
			using NpgsqlConnection conn = labeledDataContext.GetConnection();
			int tagType = mstCategoryDto.TagType;
			try
			{
				conn.Open();
				if (conn != null)
				{
					sql.AppendLine("INSERT INTO mst_category (name, tag_type)");
					sql.AppendLine("VALUES (@name, @tagType)");
					NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), conn);
					cmd.Parameters.AddWithValue("@name", mstCategoryDto.Name);
					cmd.Parameters.AddWithValue("@tagType", tagType);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Sql={1} - Error:{2}", Common.GetMethodInfor(), sql, e.Message));
				throw;
			}
			finally
			{
				labeledDataContext.CloseConnection(conn);
			}
		}

		public void UpdateCategory(MstCategoryDto mstCategoryDto)
		{
			StringBuilder sql = new StringBuilder();
			using NpgsqlConnection conn = labeledDataContext.GetConnection();
			try
			{
				conn.Open();
				if (conn != null)
				{
					sql.AppendLine("UPDATE mst_category SET name=@name, tag_type=@tagType");
					sql.Append(" WHERE id=@id");
					NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), conn);
					cmd.Parameters.AddWithValue("@name", mstCategoryDto.Name);
					cmd.Parameters.AddWithValue("@tagType", mstCategoryDto.TagType);
					cmd.Parameters.AddWithValue("@id", mstCategoryDto.Id);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Sql={1} - Error:{2}", Common.GetMethodInfor(), sql, e.Message));
				throw;
			}
			finally
			{
				labeledDataContext.CloseConnection(conn);
			}
		}

		public MstCategoryDto GetDataCategory(int id)
		{
			MstCategoryDto mstCategoryDto = new MstCategoryDto();
			StringBuilder sql = new StringBuilder();
			using (NpgsqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT * FROM mst_category WHERE id=@id LIMIT 1");
						NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), conn);
						cmd.Parameters.AddWithValue("@id", id);
						var reader = cmd.ExecuteReader();
						if (reader.Read())
						{
							mstCategoryDto = GetMstCategoryDto(reader);
						}
					}
				}
				catch (Exception e)
				{
					logger.Error(string.Format("{0}:: Sql={1} - Error:{2}", Common.GetMethodInfor(), sql, e.Message));
					throw;
				}
				finally
				{
					labeledDataContext.CloseConnection(conn);
				}
			}
			return mstCategoryDto;
		}

		public void DeleteDataCategory(int id)
		{
			StringBuilder sql = new StringBuilder();
			using NpgsqlConnection conn = labeledDataContext.GetConnection();
			try
			{
				conn.Open();
				if (conn != null)
				{
					sql.AppendLine("DELETE FROM mst_category WHERE id=@id");
					NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), conn);
					cmd.Parameters.AddWithValue("@id", id);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Sql={1} - Error:{2}", Common.GetMethodInfor(), sql, e.Message));
				throw;
			}
			finally
			{
				labeledDataContext.CloseConnection(conn);
			}
		}

		private MstCategoryDto GetMstCategoryDto(NpgsqlDataReader reader)
		{
			MstCategoryDto mstCategoryDto = new MstCategoryDto
			{
				Id = Common.ConvertStringToInt(reader["id"].ToString(), 0),
				Name = reader["name"].ToString(),
				TagType = Common.ConvertStringToInt(reader["tag_type"].ToString(), -1)
			};
			return mstCategoryDto;
		}
	}
}

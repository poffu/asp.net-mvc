using log4net;
using LabeledData.Models;
using LabeledData.Utility;
using MySqlConnector;
using System;
using System.Reflection;
using System.Text;
using System.Collections.Generic;

namespace LabeledData.Dao.Impl
{
	public class TblUserDaoImpl : ITblUserDao
	{
		private LabeledDataContext labeledDataContext;
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public TblUserDaoImpl()
		{
			labeledDataContext = new LabeledDataContext();
		}

		public TblUserDto ChangePassword(TblUserDto tblUserDto, string newPassword)
		{
			TblUserDto tblUser = new TblUserDto();
			StringBuilder sql = new StringBuilder();
			using (MySqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("UPDATE tbl_user SET password=@password WHERE user_id=@userId");
						MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
						string password = Common.SignUp(newPassword);
						cmd.Parameters.AddWithValue("@password", password);
						cmd.Parameters.AddWithValue("@userId", tblUserDto.UserId);
						cmd.ExecuteNonQuery();
						tblUser = new TblUserDto
						{
							UserId = tblUserDto.UserId,
							FullName = tblUserDto.FullName,
							LoginName = tblUserDto.LoginName,
							Password = password,
							Rule = tblUserDto.Rule
						};
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
			return tblUser;
		}

		public bool CheckExistLoginName(string loginName, int userId)
		{
			bool check = false;
			StringBuilder sql = new StringBuilder();
			using MySqlConnection conn = labeledDataContext.GetConnection();
			try
			{
				conn.Open();
				if (conn != null)
				{
					sql.AppendLine("SELECT * FROM tbl_user WHERE user_id!=@userId AND login_name=@loginName LIMIT 1");
					MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
					cmd.Parameters.AddWithValue("@userId", userId);
					cmd.Parameters.AddWithValue("@loginName", loginName);
					var reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						check = true;
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
			return check;
		}

		public void InsertUser(TblUserDto tblUserDto)
		{
			StringBuilder sql = new StringBuilder();
			using MySqlConnection conn = labeledDataContext.GetConnection();
			try
			{
				conn.Open();
				if (conn != null)
				{
					sql.AppendLine("INSERT INTO tbl_user (login_name, full_name, password, rule)");
					sql.AppendLine("VALUES (@loginName, @fullName, @password, @rule)");
					MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
					cmd.Parameters.AddWithValue("@loginName", tblUserDto.LoginName);
					cmd.Parameters.AddWithValue("@fullName", tblUserDto.FullName);
					cmd.Parameters.AddWithValue("@password", Common.SignUp(tblUserDto.Password));
					cmd.Parameters.AddWithValue("@rule", 1);
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

		public TblUserDto Login(string loginName, string password)
		{
			TblUserDto tblUser = new TblUserDto();
			StringBuilder sql = new StringBuilder();
			using (MySqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT * FROM tbl_user WHERE login_name=@loginName LIMIT 1");
						MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
						cmd.Parameters.AddWithValue("@loginName", loginName);
						var reader = cmd.ExecuteReader();
						if (reader.Read())
						{
							tblUser = GetTblUserDto(reader);
						}
						if (tblUser.UserId != 0)
						{
							if (!Common.SignIn(password, tblUser.Password))
							{
								return new TblUserDto();
							}
						}
						else
						{
							tblUser = new TblUserDto();
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
			return tblUser;
		}

		public int GetTotalUser(string username)
		{
			int totalUser = 0;
			StringBuilder sql = new StringBuilder();
			using (MySqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT COUNT(*) FROM tbl_user WHERE rule!=@rule AND login_name LIKE @username");
						MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
						cmd.Parameters.AddWithValue("@rule", 0);
						cmd.Parameters.AddWithValue("@username", string.Format("%{0}%", Common.EncodeWildCard(username)));
						totalUser = Convert.ToInt32(cmd.ExecuteScalar());
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
			return totalUser;
		}

		public List<TblUserDto> GetAllUser(string username, int limitRecord, int offset)
		{
			List<TblUserDto> tblUserList = new List<TblUserDto>();
			StringBuilder sql = new StringBuilder();
			ILabeledDataDao labeledDataDao = new LabeledDataDaoImpl();
			using (MySqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT * FROM tbl_user WHERE rule!=@rule AND login_name LIKE @username");
						sql.AppendLine(" ORDER BY LOWER(login_name) ASC");
						sql.AppendLine(" LIMIT @limit OFFSET @offset");
						MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
						cmd.Parameters.AddWithValue("@rule", 0);
						cmd.Parameters.AddWithValue("@username", string.Format("%{0}%", Common.EncodeWildCard(username)));
						cmd.Parameters.AddWithValue("@limit", limitRecord);
						cmd.Parameters.AddWithValue("@offset", offset);
						var reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							TblUserDto tblUserDto = GetTblUserDto(reader);
							tblUserDto.DataCount = labeledDataDao.GetDataCount(tblUserDto.UserId);
							tblUserList.Add(tblUserDto);
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
			return tblUserList;
		}

		public TblUserDto GetUser(int userId)
		{
			TblUserDto tblUser = new TblUserDto();
			StringBuilder sql = new StringBuilder();
			using (MySqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT * FROM tbl_user WHERE user_id=@userId LIMIT 1");
						MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
						cmd.Parameters.AddWithValue("@userId", userId);
						var reader = cmd.ExecuteReader();
						if (reader.Read())
						{
							tblUser = GetTblUserDto(reader);
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
			return tblUser;
		}

		public void UpdateUser(TblUserDto tblUserDto)
		{
			StringBuilder sql = new StringBuilder();
			using MySqlConnection conn = labeledDataContext.GetConnection();
			try
			{
				conn.Open();
				if (conn != null)
				{
					sql.AppendLine("UPDATE tbl_user SET login_name=@loginName, full_name=@fullName, password=@password");
					sql.Append(" WHERE user_id=@userId");
					MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
					cmd.Parameters.AddWithValue("@loginName", tblUserDto.LoginName);
					cmd.Parameters.AddWithValue("@fullName", tblUserDto.FullName);
					cmd.Parameters.AddWithValue("@password", Common.SignUp(tblUserDto.Password));
					cmd.Parameters.AddWithValue("@userId", tblUserDto.UserId);
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

		public void DeleteUser(int userId)
		{
			StringBuilder sql = new StringBuilder();
			using MySqlConnection conn = labeledDataContext.GetConnection();
			try
			{
				conn.Open();
				if (conn != null)
				{
					sql.AppendLine("DELETE FROM tbl_user WHERE user_id=@userId");
					MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
					cmd.Parameters.AddWithValue("@userId", userId);
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

		private TblUserDto GetTblUserDto(MySqlDataReader reader)
		{
			TblUserDto tblUserDto = new TblUserDto
			{
				UserId = Common.ConvertStringToInt(reader["user_id"].ToString(), 0),
				LoginName = reader["login_name"].ToString(),
				Password = reader["password"].ToString(),
				FullName = reader["full_name"].ToString(),
				Rule = Common.ConvertStringToInt(reader["rule"].ToString(), -1)
			};
			return tblUserDto;
		}
	}
}
using LabeledData.Models;
using LabeledData.Utility;
using log4net;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LabeledData.Dao.Impl
{
	public class LabeledDataDaoImpl : ILabeledDataDao
	{
		private LabeledDataContext labeledDataContext;
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public LabeledDataDaoImpl()
		{
			labeledDataContext = new LabeledDataContext();
		}

		public void DeleteData(LabeledDataDto labeledDataDto)
		{
			StringBuilder sql = new StringBuilder();
			using MySqlConnection conn = labeledDataContext.GetConnection();
			try
			{
				conn.Open();
				if (conn != null)
				{
					sql.AppendLine("DELETE FROM labeled_data WHERE id=@id");
					MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
					cmd.Parameters.AddWithValue("@id", labeledDataDto.Id);
					cmd.ExecuteNonQuery();
					string audioPath = labeledDataDto.AudioName;
					string imagePath = labeledDataDto.ImageName;
					if (!string.IsNullOrEmpty(audioPath))
					{
						Common.DeleteFile(audioPath);
					}
					if (!string.IsNullOrEmpty(imagePath))
					{
						Common.DeleteFile(imagePath);
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

		public List<LabeledDataDto> GetAllData(int userId, string topic, int limitRecord, int offset)
		{
			List<LabeledDataDto> labeledDataList = new List<LabeledDataDto>();
			StringBuilder sql = new StringBuilder();
			using (MySqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT * FROM labeled_data");
						sql.AppendLine(" WHERE user_id=@userId");
						sql.AppendLine(" LIMIT @limit OFFSET @offset");
						MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
						cmd.Parameters.AddWithValue("@userId", userId);
						cmd.Parameters.AddWithValue("@limit", limitRecord);
						cmd.Parameters.AddWithValue("@offset", offset);
						var reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							LabeledDataDto labeledDataDto = GetLabeledDataDto(reader);
							string topicDB = string.Empty;
							string englishTestDB = string.Empty;
							string testFormatDB = string.Empty;
							GetNameType(labeledDataDto.TopicId, labeledDataDto.EnglishTestId, labeledDataDto.TestFormatId, ref topicDB, ref englishTestDB, ref testFormatDB);
							labeledDataDto.Topic = topicDB;
							labeledDataDto.EnglishTest = englishTestDB;
							labeledDataDto.TestFormat = testFormatDB;
							labeledDataList.Add(labeledDataDto);
						}
						if (!string.IsNullOrEmpty(topic))
						{
							labeledDataList = labeledDataList.Where(x => x.Topic.Contains(topic)).ToList();
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
			return labeledDataList;
		}

		public int GetTotalData(int userId, string topic)
		{
			int totalData = 0;
			StringBuilder sql = new StringBuilder();
			using (MySqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT COUNT(*) FROM labeled_data AS l");
						sql.AppendLine(" INNER JOIN mst_category AS m ON l.topic_id = m.id");
						sql.AppendLine(" WHERE user_id=@userId AND m.name LIKE @topic");
						MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
						cmd.Parameters.AddWithValue("@userId", userId);
						cmd.Parameters.AddWithValue("@topic", string.Format("%{0}%", Common.EncodeWildCard(topic)));
						totalData = Convert.ToInt32(cmd.ExecuteScalar());
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
			return totalData;
		}

		public void InsertData(LabeledDataDto labeledDataDto)
		{
			StringBuilder sql = new StringBuilder();
			using MySqlConnection conn = labeledDataContext.GetConnection();
			try
			{
				conn.Open();
				if (conn != null)
				{
					sql.AppendLine("INSERT INTO labeled_data (user_id, topic_id, content, score, file_audio, file_image, question, english_test_id, test_format_id)");
					sql.AppendLine("VALUES (@userId, @topicId, @content, @score, @fileAudio, @fileImage, @question, @englishTestId, @testFormatId)");
					MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
					cmd.Parameters.AddWithValue("@userId", labeledDataDto.UserId);
					cmd.Parameters.AddWithValue("@topicId", labeledDataDto.TopicId);
					cmd.Parameters.AddWithValue("@content", labeledDataDto.Content);
					cmd.Parameters.AddWithValue("@score", labeledDataDto.Score);
					if (labeledDataDto.Audio != null)
					{
						labeledDataDto.AudioName = Common.CreatFileAudio(labeledDataDto.UserId, "Audio", labeledDataDto.Audio);
					}
					if (labeledDataDto.Image != null)
					{
						labeledDataDto.ImageName = Common.CreatFileImage(labeledDataDto.UserId, "Image", labeledDataDto.Image);
					}
					cmd.Parameters.AddWithValue("@fileAudio", labeledDataDto.AudioName);
					cmd.Parameters.AddWithValue("@fileImage", labeledDataDto.ImageName);
					cmd.Parameters.AddWithValue("@question", labeledDataDto.Question);
					cmd.Parameters.AddWithValue("@englishTestId", labeledDataDto.EnglishTestId);
					cmd.Parameters.AddWithValue("@testFormatId", labeledDataDto.TestFormatId);
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

		public LabeledDataDto GetLabeledData(int id)
		{
			LabeledDataDto labeledDataDto = new LabeledDataDto();
			StringBuilder sql = new StringBuilder();
			using (MySqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT * FROM labeled_data WHERE id=@id LIMIT 1");
						MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
						cmd.Parameters.AddWithValue("@id", id);
						var reader = cmd.ExecuteReader();
						if (reader.Read())
						{
							labeledDataDto = GetLabeledDataDto(reader);
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
			return labeledDataDto;
		}

		public void UpdateData(LabeledDataDto labeledDataDto)
		{
			StringBuilder sql = new StringBuilder();
			using MySqlConnection conn = labeledDataContext.GetConnection();
			try
			{
				conn.Open();
				if (conn != null)
				{
					sql.AppendLine("UPDATE labeled_data SET topic_id=@topicId, content=@content, score=@score, question=@question, english_test_id=@englishTestId, test_format_id=@testFormatId");
					if (labeledDataDto.Audio != null)
					{
						sql.Append(", file_audio=@fileAudio");
					}
					if (labeledDataDto.Image != null)
					{
						sql.Append(", file_image=@fileImage");
					}
					sql.Append(" WHERE id=@id");
					MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
					cmd.Parameters.AddWithValue("@topicId", labeledDataDto.TopicId);
					cmd.Parameters.AddWithValue("@content", labeledDataDto.Content);
					cmd.Parameters.AddWithValue("@score", labeledDataDto.Score);
					cmd.Parameters.AddWithValue("@question", labeledDataDto.Question);
					cmd.Parameters.AddWithValue("@englishTestId", labeledDataDto.EnglishTestId);
					cmd.Parameters.AddWithValue("@testFormatId", labeledDataDto.TestFormatId);
					if (labeledDataDto.Audio != null)
					{
						Common.DeleteFile(labeledDataDto.AudioName);
						labeledDataDto.AudioName = Common.CreatFileAudio(labeledDataDto.UserId, "Audio", labeledDataDto.Audio);
						cmd.Parameters.AddWithValue("@fileAudio", labeledDataDto.AudioName);
					}
					if (labeledDataDto.Image != null)
					{
						Common.DeleteFile(labeledDataDto.ImageName);
						labeledDataDto.ImageName = Common.CreatFileImage(labeledDataDto.UserId, "Image", labeledDataDto.Image);
						cmd.Parameters.AddWithValue("@fileImage", labeledDataDto.ImageName);
					}
					cmd.Parameters.AddWithValue("@id", labeledDataDto.Id);
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

		public int GetDataCount(int userId)
		{
			int dataCount = 0;
			StringBuilder sql = new StringBuilder();
			using (MySqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT COUNT(*) FROM labeled_data WHERE user_id=@userId");
						MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
						cmd.Parameters.AddWithValue("@userId", userId);
						dataCount = Convert.ToInt32(cmd.ExecuteScalar());
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
			return dataCount;
		}

		public IEnumerable<LabeledDataAPIDto> GetListLabeledDataAPI(int userId)
		{
			List<LabeledDataAPIDto> labeledDataList = new List<LabeledDataAPIDto>();
			StringBuilder sql = new StringBuilder();
			using (MySqlConnection conn = labeledDataContext.GetConnection())
			{
				try
				{
					conn.Open();
					if (conn != null)
					{
						sql.AppendLine("SELECT * FROM labeled_data");
						sql.AppendLine(" WHERE user_id=@userId");
						sql.AppendLine(" ORDER BY id ASC");
						MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
						cmd.Parameters.AddWithValue("@userId", userId);
						var reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							LabeledDataDto labeledDataDto = GetLabeledDataDto(reader);
							string topicDB = string.Empty;
							string englishTestDB = string.Empty;
							string testFormatDB = string.Empty;
							GetNameType(labeledDataDto.TopicId, labeledDataDto.EnglishTestId, labeledDataDto.TestFormatId, ref topicDB, ref englishTestDB, ref testFormatDB);
							labeledDataDto.Topic = topicDB;
							labeledDataDto.EnglishTest = englishTestDB;
							labeledDataDto.TestFormat = testFormatDB;
							LabeledDataAPIDto labeledDataAPIDto = GetLabeledDataAPIDto(labeledDataDto);
							labeledDataList.Add(labeledDataAPIDto);
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
			return labeledDataList;
		}

		private LabeledDataDto GetLabeledDataDto(MySqlDataReader reader)
		{
			LabeledDataDto labeledDataDto = new LabeledDataDto
			{
				Id = Common.ConvertStringToInt(reader["id"].ToString(), 0),
				UserId = Common.ConvertStringToInt(reader["user_id"].ToString(), 0),
				TopicId = Common.ConvertStringToInt(reader["topic_id"].ToString(), 0),
				Content = reader["content"].ToString(),
				Score = reader["score"].ToString(),
				AudioName = reader["file_audio"].ToString(),
				ImageName = reader["file_image"].ToString(),
				Question = reader["question"].ToString(),
				EnglishTestId = Common.ConvertStringToInt(reader["english_test_id"].ToString(), 0),
				TestFormatId = Common.ConvertStringToInt(reader["test_format_id"].ToString(), 0),
			};
			return labeledDataDto;
		}

		private LabeledDataAPIDto GetLabeledDataAPIDto(LabeledDataDto labeledDataDto)
		{
			LabeledDataAPIDto labeledDataAPIDto = new LabeledDataAPIDto
			{
				Id = labeledDataDto.Id,
				EnglishTest = labeledDataDto.EnglishTest.Replace(Environment.NewLine, string.Empty),
				TestFormat = labeledDataDto.TestFormat.Replace(Environment.NewLine, string.Empty),
				Topic = labeledDataDto.Topic.Replace(Environment.NewLine, string.Empty),
				Question = labeledDataDto.Question.Replace(Environment.NewLine, string.Empty),
				Content = labeledDataDto.Content.Replace(Environment.NewLine, string.Empty),
				Score = labeledDataDto.Score.Replace(Environment.NewLine, string.Empty),
				AudioPath = labeledDataDto.AudioName.Replace("\\", "/"),
				ImagePath = labeledDataDto.ImageName.Replace("\\", "/")
			};
			return labeledDataAPIDto;
		}

		private void GetNameType(int topicId, int englishTestId, int testFormatId, ref string topic, ref string englishTest, ref string testFormat)
		{
			StringBuilder sql = new StringBuilder();
			using MySqlConnection conn = labeledDataContext.GetConnection();
			try
			{
				conn.Open();
				if (conn != null)
				{
					sql.AppendLine("SET @topic1 = '0';");
					sql.AppendLine("SET @english_test1 = '0';");
					sql.AppendLine("SET @test_format1 = '0';");
					sql.AppendLine("CALL get_labeled_data(@topic, @english_test, @test_format, @topic1, @english_test1, @test_format1);");
					sql.Append("SELECT @topic1 AS topic, @english_test1 AS english_test, @test_format1 AS test_format");
					MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
					cmd.Parameters.AddWithValue("@topic", topicId);
					cmd.Parameters.AddWithValue("@english_test", englishTestId);
					cmd.Parameters.AddWithValue("@test_format", testFormatId);
					var reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						topic = reader["topic"].ToString();
						englishTest = reader["english_test"].ToString();
						testFormat = reader["test_format"].ToString();
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
	}
}

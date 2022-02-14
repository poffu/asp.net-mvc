using log4net;
using LabeledData.Utility;
using MySqlConnector;
using System;
using System.Reflection;

namespace LabeledData.Dao
{
	public class LabeledDataContext
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private string connetionString;

		public LabeledDataContext()
		{
			connetionString = "server=localhost;user=root;password=0000;database=labeled_data;AllowUserVariables=True;";
		}

		public MySqlConnection GetConnection()
		{
			return new MySqlConnection(connetionString);
		}

		public void CloseConnection(MySqlConnection conn)
		{
			try
			{
				if (conn != null)
				{
					conn.Close();
				}
			}
			catch(Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{2}", Common.GetMethodInfor(), e.Message));
				throw;
			}
		}
	}
}

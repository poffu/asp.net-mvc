using log4net;
using LabeledData.Utility;
using System;
using System.Reflection;
using Npgsql;

namespace LabeledData.Dao
{
	public class LabeledDataContext
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private string connetionString;

		public LabeledDataContext()
		{
			connetionString = "Host=python-training.cvjyerl6whev.us-west-2.rds.amazonaws.com;Username=postgres;Password=00000000;Database=labeled_data;";
		}

		public NpgsqlConnection GetConnection()
		{
			return new NpgsqlConnection(connetionString);
		}

		public void CloseConnection(NpgsqlConnection conn)
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

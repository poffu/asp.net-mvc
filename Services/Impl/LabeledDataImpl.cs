using LabeledData.Dao;
using LabeledData.Dao.Impl;
using LabeledData.Models;
using System.Collections.Generic;

namespace LabeledData.Services.Impl
{
	public class LabeledDataImpl : ILabeledData
	{
		private ILabeledDataDao labeledDataDao;

		public LabeledDataImpl()
		{
			labeledDataDao = new LabeledDataDaoImpl();
		}

		public List<LabeledDataDto> GetAllData(int userId, string topic, int limitRecord, int offset)
		{
			return labeledDataDao.GetAllData(userId, topic, limitRecord, offset);
		}

		public void InsertData(LabeledDataDto labeledDataDto)
		{
			labeledDataDao.InsertData(labeledDataDto);
		}

		public void DeleteData(LabeledDataDto labeledDataDto)
		{
			labeledDataDao.DeleteData(labeledDataDto);
		}

		public int GetTotalData(int userId, string topic)
		{
			return labeledDataDao.GetTotalData(userId, topic);
		}

		public LabeledDataDto GetLabeledData(int id)
		{
			return labeledDataDao.GetLabeledData(id);
		}

		public void UpdateData(LabeledDataDto labeledDataDto)
		{
			labeledDataDao.UpdateData(labeledDataDto);
		}

		public IEnumerable<LabeledDataAPIDto> GetListLabeledDataAPI(int userId)
		{
			return labeledDataDao.GetListLabeledDataAPI(userId);
		}
	}
}
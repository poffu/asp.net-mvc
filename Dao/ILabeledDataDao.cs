using LabeledData.Models;
using System.Collections.Generic;

namespace LabeledData.Dao
{
	public interface ILabeledDataDao
	{
		void InsertData(LabeledDataDto labeledDataDto);
		List<LabeledDataDto> GetAllData(int userId, string topic, int limitRecord, int offset);
		void DeleteData(LabeledDataDto labeledDataDto);
		int GetTotalData(int userId, string topic);
		LabeledDataDto GetLabeledData(int id);
		void UpdateData(LabeledDataDto labeledDataDto);
		int GetDataCount(int userId);
		IEnumerable<LabeledDataAPIDto> GetListLabeledDataAPI(int userId);
	}
}

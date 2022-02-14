using LabeledData.Models;
using System.Collections.Generic;

namespace LabeledData.Services
{
	public interface ILabeledData
	{
		void InsertData(LabeledDataDto labeledDataDto);
		List<LabeledDataDto> GetAllData(int userId, string topic, int limitRecord, int offset);
		void DeleteData(LabeledDataDto labeledDataDto);
		int GetTotalData(int userId, string topic);
		LabeledDataDto GetLabeledData(int id);
		void UpdateData(LabeledDataDto labeledDataDto);
		IEnumerable<LabeledDataAPIDto> GetListLabeledDataAPI(int userId);
	}
}

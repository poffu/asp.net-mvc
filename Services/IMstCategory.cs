using LabeledData.Models;
using System.Collections.Generic;

namespace LabeledData.Services
{
	public interface IMstCategory
	{
		List<MstCategoryDto> GetAllListCategory();
		int GetTotalCategory(string name, int tagType);
		List<MstCategoryDto> GetAllCategory(string name, int tagType, int limitRecord, int offset);
		Dictionary<int, string> GetAllListType();
		bool CheckExistName(int id, string name);
		void InsertCategory(MstCategoryDto mstCategoryDto);
		void UpdateCategory(MstCategoryDto mstCategoryDto);
		MstCategoryDto GetDataCategory(int id);
		void DeleteDataCategory(int id);
	}
}

using LabeledData.Dao;
using LabeledData.Dao.Impl;
using LabeledData.Models;
using System.Collections.Generic;

namespace LabeledData.Services.Impl
{
	public class MstCategoryImpl : IMstCategory
	{
		private IMstCategoryDao mstCategory;

		public MstCategoryImpl()
		{
			mstCategory = new MstCategoryDaoImpl();
		}

		public bool CheckExistName(int id, string name)
		{
			return mstCategory.CheckExistName(id, name);
		}

		public void DeleteDataCategory(int id)
		{
			mstCategory.DeleteDataCategory(id);
		}

		public List<MstCategoryDto> GetAllCategory(string name, int tagType, int limitRecord, int offset)
		{
			return mstCategory.GetAllCategory(name, tagType, limitRecord, offset);
		}

		public List<MstCategoryDto> GetAllListCategory()
		{
			return mstCategory.GetAllListCategory();
		}

		public Dictionary<int, string> GetAllListType()
		{
			return mstCategory.GetAllListType();
		}

		public MstCategoryDto GetDataCategory(int id)
		{
			return mstCategory.GetDataCategory(id);
		}

		public int GetTotalCategory(string name, int tagType)
		{
			return mstCategory.GetTotalCategory(name, tagType);
		}

		public void InsertCategory(MstCategoryDto mstCategoryDto)
		{
			mstCategory.InsertCategory(mstCategoryDto);
		}

		public void UpdateCategory(MstCategoryDto mstCategoryDto)
		{
			mstCategory.UpdateCategory(mstCategoryDto);
		}
	}
}

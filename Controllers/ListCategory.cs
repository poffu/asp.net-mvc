using LabeledData.Controllers;
using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace LabeledDataManagement.Controllers
{
	public class ListCategory : BaseController
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private Dictionary<int, string> typeList;

		public ListCategory()
		{
			IMstCategory mstCategory = new MstCategoryImpl();
			typeList = mstCategory.GetAllListType();
		}

		public IActionResult Index(MstCategoryDto mstCategoryDto, string nameSearch, int tagType = -1, int page = 1)
		{
			List<MstCategoryDto> labeledDataList = new List<MstCategoryDto>();
			try
			{
				TblUserDto tblUserSession = HttpContext.Session.GetObjectFromJson<TblUserDto>("Login");
				if (tblUserSession == null)
				{
					return RedirectToAction("Index", "Login", null);
				}
				else
				{
					if (tblUserSession.Rule != 0)
					{
						return RedirectToAction("Index", "ListData", null);
					}
				}
				string mode = HttpContext.Session.GetString("Mode");
				if (string.IsNullOrEmpty(mode))
				{
					ModelState.Remove("Name");
					ModelState.Remove("TagType");
				}
				else
				{
					HttpContext.Session.Remove("Mode");
				}
				IMstCategory mstCategory = new MstCategoryImpl();
				if (string.IsNullOrEmpty(nameSearch))
				{
					nameSearch = string.Empty;
				}
				int totalCategory = mstCategory.GetTotalCategory(nameSearch, tagType);
				if (totalCategory > 0)
				{
					int limitRecord = 10;
					int limitPaging = 3;
					int totalPage = Common.TotalPage(totalCategory, limitRecord);
					if (page <= 0)
					{
						page = 1;
					}
					else if (page > totalPage)
					{
						page = totalPage;
					}
					int offset = Common.GetOffset(page, limitRecord);
					labeledDataList = mstCategory.GetAllCategory(nameSearch, tagType, limitRecord, offset);
					List<int> listPaging = Common.GetListPaging(page, totalPage);
					ViewBag.totalPage = totalPage;
					ViewBag.page = page;
					ViewBag.listPaging = listPaging;
					ViewBag.limitPaging = limitPaging;
					ViewBag.offset = offset;
				}
				ViewBag.nameSearch = nameSearch;
				ViewBag.tagType = tagType;
				ViewBag.typeList = typeList;
				ViewBag.typeId = mstCategoryDto.TagType;
				var tuple = new Tuple<List<MstCategoryDto>, MstCategoryDto>(labeledDataList, mstCategoryDto);
				return View(tuple);
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
				return RedirectToAction("Index", "SystemError", null);
			}
		}

		public ActionResult Delete(int id)
		{
			try
			{
				IMstCategory mstCategory = new MstCategoryImpl();
				MstCategoryDto mstCategoryDto = mstCategory.GetDataCategory(id);
				if (mstCategoryDto.Id != 0)
				{
					mstCategory.DeleteDataCategory(id);
					SetAlert("Deleted", "/ListCategory/Index");
				}
				else
				{
					SetAlert("Data isn't exist", "/ListCategory/Index");
				}
				return RedirectToAction("Index", "ListCategory", null);
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
				return RedirectToAction("Index", "SystemError", null);
			}
		}
	}
}

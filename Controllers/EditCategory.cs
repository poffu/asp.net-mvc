using LabeledData.Controllers;
using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;

namespace LabeledDataManagement.Controllers
{
	public class EditCategory : BaseController
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public ActionResult Index(int id)
		{
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
				IMstCategory mstCategory = new MstCategoryImpl();
				MstCategoryDto mstCategoryDto = mstCategory.GetDataCategory(id);
				if (mstCategoryDto.Id == 0)
				{
					SetAlert("Data isn't exist", "/ListCategory/Index");
				}
				return RedirectToAction("Index", "ListCategory", mstCategoryDto);
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
				return RedirectToAction("Index", "SystemError", null);
			}
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Index(MstCategoryDto mstCategoryDto)
		{
			try
			{
				IMstCategory mstCategory = new MstCategoryImpl();
				if (ModelState.IsValid)
				{
					mstCategory.UpdateCategory(mstCategoryDto);
					SetAlert("Success", "/ListCategory/Index");
				}
				else
				{
					HttpContext.Session.SetString("Mode", "Edit");
				}
				return RedirectToAction("Index", "ListCategory", mstCategoryDto);
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
				return RedirectToAction("Index", "SystemError", null);
			}
		}
	}
}

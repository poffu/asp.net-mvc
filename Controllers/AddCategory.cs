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
	public class AddCategory : BaseController
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Index(MstCategoryDto mstCategoryDto)
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
				if (ModelState.IsValid)
				{
					IMstCategory mstCategory = new MstCategoryImpl();
					mstCategory.InsertCategory(mstCategoryDto);
					SetAlert("Success", "/ListCategory/Index");
				}
				else
				{
					HttpContext.Session.SetString("Mode", "Add");
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

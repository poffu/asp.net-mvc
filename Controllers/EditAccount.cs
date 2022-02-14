using LabeledData.Controllers;
using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;

namespace LabeledDataManagement.Controllers
{
	public class EditAccount : BaseController
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public ActionResult Index(int userId)
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
				ITblUser tblUser = new TblUserImpl();
				TblUserDto tblUserDto = tblUser.GetUser(userId);
				if (tblUserDto.UserId == 0)
				{
					SetAlert("User isn't exist", "/ListUser/Index");
				}
				return View("~/Views/CreateAccount/Index.cshtml", tblUserDto);
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
				return RedirectToAction("Index", "SystemError", null);
			}
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Index(TblUserDto tblUserDto)
		{
			try
			{
				ModelState.Remove("NewPassword");
				if (ModelState.IsValid)
				{
					ITblUser tblUser = new TblUserImpl();
					if (tblUser.CheckExistLoginName(tblUserDto.LoginName, tblUserDto.UserId))
					{
						ModelState.AddModelError("Error", "Username is exist");
					}
					else
					{
						tblUser.UpdateUser(tblUserDto);
						SetAlert("Success", "/ListUser/Index");
					}
				}
				return View("~/Views/CreateAccount/Index.cshtml", tblUserDto);
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
				return RedirectToAction("Index", "SystemError", null);
			}
		}
	}
}

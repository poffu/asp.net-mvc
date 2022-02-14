using log4net;
using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;

namespace LabeledData.Controllers
{
	public class CreateAccount : BaseController
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		// GET: CreateAccount
		public ActionResult Index()
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
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
				return RedirectToAction("Index", "SystemError", null);
			}
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Index(TblUserDto tblUserDto)
		{
			try
			{
				ModelState.Remove("UserId");
				ModelState.Remove("NewPassword");
				if (ModelState.IsValid)
				{
					ITblUser tblUser = new TblUserImpl();
					if (tblUser.CheckExistLoginName(tblUserDto.LoginName, tblUserDto.UserId))
					{
						ModelState.AddModelError("Error", "Username is exis");
					}
					else
					{
						tblUser.InsertUser(tblUserDto);
						SetAlert("Success", "/ListUser/Index");
					}
				}
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
				return RedirectToAction("Index", "SystemError", null);
			}
			return View();
		}
	}
}
using log4net;
using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Reflection;

namespace LabeledData.Controllers
{
	public class ChangePassword : BaseController
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		// GET: ChangePassword
		public ActionResult Index()
		{
			try
			{
				TblUserDto tblUserSession = HttpContext.Session.GetObjectFromJson<TblUserDto>("Login");
				if (tblUserSession == null)
				{
					return RedirectToAction("Index", "Login", null);
				}
				ViewBag.ruleUser = tblUserSession.Rule;
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
				TblUserDto tblUserSession = JsonConvert.DeserializeObject<TblUserDto>(HttpContext.Session.GetString("Login"));
				ViewBag.ruleUser = tblUserSession.Rule;
				ModelState.Remove("LoginName");
				ModelState.Remove("FullName");
				if (ModelState.IsValid)
				{
					ITblUser tblUser = new TblUserImpl();
					string password = tblUserDto.Password;
					if (Common.ComparePassword(password, tblUserSession.Password))
					{
						TblUserDto tblUserModel = tblUser.ChangePassword(tblUserSession, tblUserDto.NewPassword);
						if (tblUserModel.UserId != 0)
						{
							HttpContext.Session.SetString("Login", JsonConvert.SerializeObject(tblUserModel));
							if (tblUserModel.Rule == 0)
							{
								SetAlert("Success", "/ListUser/Index");
							}
							else
							{
								SetAlert("Success", "/ListData/Index");
							}
						}
						else
						{
							if (tblUserSession.Rule == 0)
							{
								SetAlert("Fail", "/ListUser/Index");
							}
							else
							{
								SetAlert("Fail", "/ListData/Index");
							}
						}
					}
					else
					{
						ModelState.AddModelError("Error", "Password isn't correct.");
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

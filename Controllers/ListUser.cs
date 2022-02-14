using LabeledData.Controllers;
using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace LabeledDataManagement.Controllers
{
	public class ListUser : BaseController
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		// GET: ListUser
		public ActionResult Index(string username, int page = 1)
		{
			List<TblUserDto> labeledDataList = new List<TblUserDto>();
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
				ITblUser labeledData = new TblUserImpl();
				if (string.IsNullOrEmpty(username))
				{
					username = string.Empty;
				}
				int totalUser = labeledData.GetTotalUser(username);
				if (totalUser > 0)
				{
					int limitRecord = 10;
					int limitPaging = 3;
					int totalPage = Common.TotalPage(totalUser, limitRecord);
					if (page <= 0)
					{
						page = 1;
					}
					else if (page > totalPage)
					{
						page = totalPage;
					}
					int offset = Common.GetOffset(page, limitRecord);
					labeledDataList = labeledData.GetAllUser(username, limitRecord, offset);
					List<int> listPaging = Common.GetListPaging(page, totalPage);
					ViewBag.totalPage = totalPage;
					ViewBag.page = page;
					ViewBag.listPaging = listPaging;
					ViewBag.limitPaging = limitPaging;
					ViewBag.offset = offset;
				}
				ViewBag.usernameSearch = username;
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
				return RedirectToAction("Index", "SystemError", null);
			}
			return View(labeledDataList);
		}

		public ActionResult Delete(int id)
		{
			try
			{
				ITblUser tblUser = new TblUserImpl();
				TblUserDto tblUserDto = tblUser.GetUser(id);
				if (tblUserDto.UserId != 0)
				{
					tblUser.DeleteUser(id);
					SetAlert("Deleted", "/ListUser/Index");
				}
				else
				{
					SetAlert("User isn't exist", "/ListUser/Index");
				}
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
				return RedirectToAction("Index", "SystemError", null);
			}
			return RedirectToAction("Index", "ListData", null);
		}
	}
}

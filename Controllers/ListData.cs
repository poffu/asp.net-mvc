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

namespace LabeledData.Controllers
{
	public class ListData : BaseController
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		// GET: ListData
		public ActionResult Index(string topic, int page = 1)
		{
			List<LabeledDataDto> labeledDataList = new List<LabeledDataDto>();
			try
			{
				TblUserDto tblUserSession = HttpContext.Session.GetObjectFromJson<TblUserDto>("Login");
				if (tblUserSession == null)
				{
					return RedirectToAction("Index", "Login", null);
				}
				else
				{
					if (tblUserSession.Rule == 0)
					{
						return RedirectToAction("Index", "ListUser", null);
					}
				}
				ILabeledData labeledData = new LabeledDataImpl();
				if (string.IsNullOrEmpty(topic))
				{
					topic = string.Empty;
				}
				int totalUser = labeledData.GetTotalData(tblUserSession.UserId, topic);
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
					labeledDataList = labeledData.GetAllData(tblUserSession.UserId, topic, limitRecord, offset);
					List<int> listPaging = Common.GetListPaging(page, totalPage);
					ViewBag.totalPage = totalPage;
					ViewBag.page = page;
					ViewBag.listPaging = listPaging;
					ViewBag.limitPaging = limitPaging;
					ViewBag.offset = offset;
				}
				ViewBag.topicSearch = topic;
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
				ILabeledData labeledData = new LabeledDataImpl();
				LabeledDataDto labeledDataDto = labeledData.GetLabeledData(id);
				if (labeledDataDto.Id != 0)
				{
					labeledData.DeleteData(labeledDataDto);
					SetAlert("Deleted", "/ListData/Index");
				}
				else
				{
					SetAlert("Data isn't exist", "/ListData/Index");
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
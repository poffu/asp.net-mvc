using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace LabeledData.Controllers
{
	public class EditData : BaseController
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
					if (tblUserSession.Rule == 0)
					{
						return RedirectToAction("Index", "ListUser", null);
					}
				}
				ILabeledData labeledData = new LabeledDataImpl();
				LabeledDataDto labeledDataDto = labeledData.GetLabeledData(id);
				if (labeledDataDto.Id > 0)
				{
					ViewBag.englishTestId = labeledDataDto.EnglishTestId;
					ViewBag.testFormatId = labeledDataDto.TestFormatId;
					ViewBag.topicId = labeledDataDto.TopicId;
					ViewBag.audioName = labeledDataDto.AudioName;
					ViewBag.imageName = labeledDataDto.ImageName;
					SetData();
				}
				else
				{
					SetAlert("Data isn't exist", "/ListData/Index");
				}
				return View("~/Views/AddData/Index.cshtml", labeledDataDto);
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
				return RedirectToAction("Index", "SystemError", null);
			}
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult IndexAsync(LabeledDataDto labeledDataDto)
		{
			try
			{
				if (ModelState.IsValid)
				{
					ILabeledData labeledData = new LabeledDataImpl();
					labeledData.UpdateData(labeledDataDto);
					SetAlert("Success", "/ListData/Index");
				}
				ViewBag.englishTestId = labeledDataDto.EnglishTestId;
				ViewBag.testFormatId = labeledDataDto.TestFormatId;
				ViewBag.topicId = labeledDataDto.TopicId;
				SetData();
				return View("~/Views/AddData/Index.cshtml", labeledDataDto);
			}
			catch (Exception e)
			{
				logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
				return RedirectToAction("Index", "SystemError", null);
			}
		}
	}
}

using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;

namespace LabeledData.Controllers
{
	public class AddData : BaseController
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		// GET: AddData
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
					if(tblUserSession.Rule == 0)
					{
						return RedirectToAction("Index", "ListUser", null);
					}
				}
				SetData();
				ViewBag.userId = tblUserSession.UserId;
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
        public ActionResult Index(LabeledDataDto labeledDataDto)
        {
            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {
                    ILabeledData labeledData = new LabeledDataImpl();
                    labeledData.InsertData(labeledDataDto);
                    SetAlert("Success", "/ListData/Index");
                }
                ViewBag.englishTestId = labeledDataDto.EnglishTestId;
                ViewBag.testFormatId = labeledDataDto.TestFormatId;
                ViewBag.topicId = labeledDataDto.TopicId;
                SetData();
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

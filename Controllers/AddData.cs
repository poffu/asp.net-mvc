using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LabeledData.Controllers
{
    public class AddData : BaseController
    {
        // GET: AddData
        public ActionResult Index()
        {
            try
            {
                TblUserDto tblUserSession = FilterLogin("AddData");
                SetData();
                ViewBag.userId = tblUserSession.UserId;
            }
            catch (Exception e)
            {
                SystemError(e);
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
                    SetAlert("Success", "/ListData");
                }
                ViewBag.englishTestId = labeledDataDto.EnglishTestId;
                ViewBag.testFormatId = labeledDataDto.TestFormatId;
                ViewBag.topicId = labeledDataDto.TopicId;
                SetData();
            }
            catch (Exception e)
            {
                SystemError(e);
            }
            return View();
        }
    }
}

using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LabeledData.Controllers
{
    public class EditData : BaseController
    {
        public ActionResult Index(int id)
        {
            LabeledDataDto labeledDataDto = new LabeledDataDto();
            try
            {
                FilterLogin("EditData");
                ILabeledData labeledData = new LabeledDataImpl();
                labeledDataDto = labeledData.GetLabeledData(id);
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
                    SetAlert("Data isn't exist", "/ListData");
                }
            }
            catch (Exception e)
            {
                SystemError(e);
            }
            return View("~/Views/AddData/Index.cshtml", labeledDataDto);
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
            return View("~/Views/AddData/Index.cshtml", labeledDataDto);
        }
    }
}

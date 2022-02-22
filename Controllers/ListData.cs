using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LabeledData.Controllers
{
    public class ListData : BaseController
    {
        // GET: ListData
        public ActionResult Index(string topic, int page = 1)
        {
            List<LabeledDataDto> labeledDataList = new List<LabeledDataDto>();
            try
            {
                TblUserDto tblUserSession = FilterLogin("ListData");
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
                SystemError(e);
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
                    SetAlert("Deleted", "/ListData");
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
            return RedirectToAction("Index", "ListData", null);
        }
    }
}
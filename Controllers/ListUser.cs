using LabeledData.Controllers;
using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LabeledDataManagement.Controllers
{
    public class ListUser : BaseController
    {
        // GET: ListUser
        public ActionResult Index(string username, int page = 1)
        {
            List<TblUserDto> labeledDataList = new List<TblUserDto>();
            try
            {
                FilterLogin("ListUser");
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
                SystemError(e);
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
                    SetAlert("Deleted", "/ListUser");
                }
                else
                {
                    SetAlert("User isn't exist", "/ListUser");
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

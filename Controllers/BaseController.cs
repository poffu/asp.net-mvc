using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LabeledData.Controllers
{
    public class BaseController : Controller
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected void SetAlert(string message, string url)
        {
            TempData["AlertMessage"] = message;
            TempData["Url"] = url;
        }

        protected void SetData()
        {
            IMstCategory mstCategory = new MstCategoryImpl();
            List<MstCategoryDto> mstCategoryList = new List<MstCategoryDto>();
            mstCategoryList = mstCategory.GetAllListCategory();
            ViewBag.englishTestList = mstCategoryList.Where(x => x.TagType == 0).OrderBy(x => x.Name.ToLower()).ToList();
            ViewBag.testFormatList = mstCategoryList.Where(x => x.TagType == 1).OrderBy(x => x.Name.ToLower()).ToList();
            ViewBag.topicList = mstCategoryList.Where(x => x.TagType == 2).OrderBy(x => x.Name.ToLower()).ToList();
        }

        protected void SystemError(Exception e)
        {
            logger.Error(string.Format("{0}:: Error:{1}", Common.GetMethodInfor(), e.Message));
            Response.Redirect("SystemError");
        }

        protected TblUserDto FilterLogin(string controller)
        {
            TblUserDto tblUserSession = HttpContext.Session.GetObjectFromJson<TblUserDto>("Login");
            if (tblUserSession == null)
            {
                if (!controller.Equals("Login"))
                {
                    Response.Redirect("Login");
                }
                return new TblUserDto();
            }
            else
            {
                if (tblUserSession.Rule == 0)
                {
                    List<string> adminControllerList = new List<string>() { "ListUser", "ChangePassword", "AddCategory", "CreateAccount", "EditAccount", "EditCategory", "ListCategory" };
                    if (!adminControllerList.Any(x => x.Equals(controller)))
                    {
                        Response.Redirect("ListUser");
                    }
                }
                else
                {
                    List<string> userControllerList = new List<string>() { "AddData", "ChangePassword", "EditData", "ListData" };
                    if (!userControllerList.Any(x => x.Equals(controller)))
                    {
                        Response.Redirect("ListData");
                    }
                }
                return tblUserSession;
            }
        }
    }
}

using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace LabeledData.Controllers
{
    public class ChangePassword : BaseController
    {
        // GET: ChangePassword
        public ActionResult Index()
        {
            try
            {
                TblUserDto tblUserSession = FilterLogin("ChangePassword");
                ViewBag.ruleUser = tblUserSession.Rule;
            }
            catch (Exception e)
            {
                SystemError(e);
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
                                SetAlert("Success", "/ListUser");
                            }
                            else
                            {
                                SetAlert("Success", "/ListData");
                            }
                        }
                        else
                        {
                            if (tblUserSession.Rule == 0)
                            {
                                SetAlert("Fail", "/ListUser");
                            }
                            else
                            {
                                SetAlert("Fail", "/ListData");
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
                SystemError(e);
            }
            return View();
        }
    }
}

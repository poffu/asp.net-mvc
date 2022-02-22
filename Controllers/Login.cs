using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace LabeledData.Controllers
{
    public class Login : BaseController
    {
        // GET: Login
        public ActionResult Index()
        {
            try
            {
                FilterLogin("Login");
            }
            catch (Exception e)
            {
                SystemError(e);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(TblUserDto tblUserModel)
        {
            try
            {
                ModelState.Remove("NewPassword");
                ModelState.Remove("PasswordConfirm");
                ModelState.Remove("FullName");
                if (ModelState.IsValid)
                {
                    ITblUser tblUserService = new TblUserImpl();
                    string loginName = tblUserModel.LoginName;
                    string password = tblUserModel.Password;
                    TblUserDto tblUser = tblUserService.Login(loginName, password);
                    if (tblUser.UserId != 0)
                    {
                        HttpContext.Session.SetString("Login", JsonConvert.SerializeObject(tblUser));
                        if (tblUser.Rule == 0)
                        {
                            return RedirectToAction("Index", "ListUser", null);
                        }
                        else
                        {
                            return RedirectToAction("Index", "ListData", null);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Error", "Username or password isn't correct");
                    }
                }
            }
            catch (Exception e)
            {
                SystemError(e);
            }
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login", null);
        }
    }
}

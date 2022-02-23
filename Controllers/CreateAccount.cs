using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LabeledData.Controllers
{
    public class CreateAccount : BaseController
    {
        // GET: CreateAccount
        public ActionResult Index()
        {
            try
            {
                FilterLogin("CreateAccount");
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
                ModelState.Remove("UserId");
                ModelState.Remove("NewPassword");
                if (ModelState.IsValid)
                {
                    ITblUser tblUser = new TblUserImpl();
                    if (tblUser.CheckExistLoginName(tblUserDto.LoginName, tblUserDto.UserId))
                    {
                        ModelState.AddModelError("Error", "Username is exist");
                    }
                    else
                    {
                        tblUser.InsertUser(tblUserDto);
                        SetAlert("Success", "/ListUser");
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
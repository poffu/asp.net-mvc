using LabeledData.Controllers;
using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LabeledDataManagement.Controllers
{
    public class EditAccount : BaseController
    {
        public ActionResult Index(int userId)
        {
            TblUserDto tblUserDto = new TblUserDto();
            try
            {
                FilterLogin("EditAccount");
                ITblUser tblUser = new TblUserImpl();
                tblUserDto = tblUser.GetUser(userId);
                if (tblUserDto.UserId == 0)
                {
                    SetAlert("User isn't exist", "/ListUser");
                }
            }
            catch (Exception e)
            {
                SystemError(e);
            }
            return View("~/Views/CreateAccount/Index.cshtml", tblUserDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(TblUserDto tblUserDto)
        {
            try
            {
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
                        tblUser.UpdateUser(tblUserDto);
                        SetAlert("Success", "/ListUser");
                    }
                }
            }
            catch (Exception e)
            {
                SystemError(e);
            }
            return View("~/Views/CreateAccount/Index.cshtml", tblUserDto);
        }
    }
}

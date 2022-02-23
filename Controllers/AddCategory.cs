using LabeledData.Controllers;
using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LabeledDataManagement.Controllers
{
    public class AddCategory : BaseController
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(MstCategoryDto mstCategoryDto)
        {
            try
            {
                FilterLogin("AddCategory");
                if (ModelState.IsValid)
                {
                    IMstCategory mstCategory = new MstCategoryImpl();
                    mstCategory.InsertCategory(mstCategoryDto);
                    SetAlert("Success", "/ListCategory");
                }
                else
                {
                    HttpContext.Session.SetString("Mode", "Add");
                }
            }
            catch (Exception e)
            {
                SystemError(e);
            }
            return RedirectToAction("Index", "ListCategory", mstCategoryDto);
        }
    }
}

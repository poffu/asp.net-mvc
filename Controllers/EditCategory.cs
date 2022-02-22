using LabeledData.Controllers;
using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LabeledDataManagement.Controllers
{
    public class EditCategory : BaseController
    {
        public ActionResult Index(int id)
        {
            MstCategoryDto mstCategoryDto = new MstCategoryDto();
            try
            {
                FilterLogin("EditCategory");
                IMstCategory mstCategory = new MstCategoryImpl();
                mstCategoryDto = mstCategory.GetDataCategory(id);
                if (mstCategoryDto.Id == 0)
                {
                    SetAlert("Data isn't exist", "/ListCategory");
                }
            }
            catch (Exception e)
            {
                SystemError(e);
            }
            return RedirectToAction("Index", "ListCategory", mstCategoryDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(MstCategoryDto mstCategoryDto)
        {
            try
            {
                IMstCategory mstCategory = new MstCategoryImpl();
                if (ModelState.IsValid)
                {
                    mstCategory.UpdateCategory(mstCategoryDto);
                    SetAlert("Success", "/ListCategory");
                }
                else
                {
                    HttpContext.Session.SetString("Mode", "Edit");
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

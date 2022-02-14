using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabeledData.Controllers
{
	public class BaseController : Controller
	{
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
	}
}

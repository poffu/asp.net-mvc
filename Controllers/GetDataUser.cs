using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using LabeledData.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LabeledDataManagement.Controllers
{
	[Route("api/GetData")]
	[ApiController]
	[Produces("application/json")]
	public class GetDataUser : ControllerBase
	{
		public IActionResult Index(int userId)
		{
			TblUserDto tblUserSession = HttpContext.Session.GetObjectFromJson<TblUserDto>("Login");
			IEnumerable<LabeledDataAPIDto> labeledDataList = new List<LabeledDataAPIDto>();
			if (tblUserSession != null && tblUserSession.Rule == 0)
			{
				ILabeledData labeledData = new LabeledDataImpl();
				labeledDataList = labeledData.GetListLabeledDataAPI(userId);
				return Ok(labeledDataList);
			}
			else
			{
				return NotFound();
			}
		}
	}
}

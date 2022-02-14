using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LabeledData.Validate
{
	public class ValidateImage : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value != null)
			{
				List<IFormFile> fileList = (List<IFormFile>)value;
				foreach (var file in fileList)
				{
					string fileName = file.FileName;
					if (!fileName.EndsWith(".png") && !fileName.EndsWith(".jpg"))
					{
						return new ValidationResult("File format must be \".png\", \".jpg\"");
					}
				}
			}
			return ValidationResult.Success;
		}
	}
}

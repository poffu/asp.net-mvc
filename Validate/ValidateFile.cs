using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace LabeledData.Validate
{
	public class ValidateFile : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value != null)
			{
				IFormFile file = (IFormFile)value;
				string fileName = file.FileName;
				if (!fileName.EndsWith(".mp3"))
				{
					return new ValidationResult("File format must be \".mp3\"");
				}
			}
			return ValidationResult.Success;
		}
	}
}

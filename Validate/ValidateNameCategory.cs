using LabeledData.Models;
using LabeledData.Services;
using LabeledData.Services.Impl;
using System.ComponentModel.DataAnnotations;

namespace LabeledDataManagement.Validate
{
	public class ValidateNameCategory : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var model = (MstCategoryDto)validationContext.ObjectInstance;
			string name = model.Name;
			if (string.IsNullOrEmpty(name))
			{
				return new ValidationResult("Name is required");
			}
			else
			{
				IMstCategory mstCategory = new MstCategoryImpl();
				if (mstCategory.CheckExistName(model.Id, name))
				{
					return new ValidationResult("Name is exist");
				}
			}
			return ValidationResult.Success;
		}
	}
}

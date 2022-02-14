using LabeledData.Utility;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LabeledData.Validate
{
	public class ValidateScore : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value != null)
			{
				string total = value.ToString();
				if (!Regex.IsMatch(total, "^\\d*\\.?\\d+$"))
				{
					return new ValidationResult("Score must be number and \".\"");
				}
				else
				{
					float point = Common.ConvertStringToFloat(total, -1);
					if (0 >= point || point > 9)
					{
						return new ValidationResult("0 <= Score <= 9");
					}
					return ValidationResult.Success;
				}
			}
			return ValidationResult.Success;
		}
	}
}

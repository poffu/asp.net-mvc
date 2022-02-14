using LabeledData.Models;
using System.ComponentModel.DataAnnotations;

namespace LabeledData.Validate
{
	public class ValidatePassword : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var model = (TblUserDto)validationContext.ObjectInstance;
			string newPassword = model.NewPassword;
			string password = model.Password;
			if (!string.IsNullOrEmpty(newPassword))
			{
				string passwordConfirm = model.PasswordConfirm;
				if (string.IsNullOrEmpty(passwordConfirm))
				{
					return new ValidationResult("The password confirmation is required");
				}
				else
				{
					if (!newPassword.Equals(passwordConfirm))
					{
						return new ValidationResult("The password confirmation doesn't match");
					}
				}
			}
			else if (!string.IsNullOrEmpty(password))
			{
				string passwordConfirm = model.PasswordConfirm;
				if (string.IsNullOrEmpty(passwordConfirm))
				{
					return new ValidationResult("The password confirmation is required");
				}
				else
				{
					if (!password.Equals(passwordConfirm))
					{
						return new ValidationResult("The password confirmation doesn't match");
					}
				}
			}
			return ValidationResult.Success;
		}
	}
}

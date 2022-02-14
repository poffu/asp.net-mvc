using LabeledData.Validate;
using System;
using System.ComponentModel.DataAnnotations;

namespace LabeledData.Models
{
	[Serializable]
	public class TblUserDto
	{
		public int UserId { get; set; }
		[Required(ErrorMessage = "Username is required")]
		public string LoginName { get; set; }
		[Required(ErrorMessage = "Name is required")]
		public string FullName { get; set; }
		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }
		public int Rule { get; set; }
		[Required(ErrorMessage = "New password is required")]
		public string NewPassword { get; set; }
		[ValidatePassword]
		public string PasswordConfirm { get; set; }
		public int DataCount { get; set; }

		public TblUserDto()
		{
			UserId = 0;
			LoginName = string.Empty;
			FullName = string.Empty;
			Password = string.Empty;
			Rule = 0;
			NewPassword = string.Empty;
			PasswordConfirm = string.Empty;
			DataCount = 0;
		}
	}
}

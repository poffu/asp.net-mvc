using LabeledDataManagement.Validate;
using System.ComponentModel.DataAnnotations;

namespace LabeledData.Models
{
	public class MstCategoryDto
	{
		public int Id { get; set; }
		[ValidateNameCategory]
		public string Name { get; set; }
		[Range(0, int.MaxValue, ErrorMessage = "Type is required")]
		public int TagType { get; set; }
		public string Type { get; set; }

		public MstCategoryDto()
		{
			Id = 0;
			Name = string.Empty;
			TagType = -1;
			Type = string.Empty;
		}
	}
}
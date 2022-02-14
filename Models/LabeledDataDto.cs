using LabeledData.Validate;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LabeledData.Models
{
	public class LabeledDataDto
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Topic { get; set; }
		public string Content { get; set; }
		[ValidateScore]
		public string Score { get; set; }
		[ValidateFile]
		public IFormFile Audio { get; set; }
		public string AudioName { get; set; }
		[ValidateImage]
		public List<IFormFile> Image { get; set; }
		public string ImageName { get; set; }
		[Range(1, int.MaxValue, ErrorMessage = "Topic is required")]
		public int TopicId { get; set; }
		public string Question { get; set; }
		public string EnglishTest { get; set; }
		public string TestFormat { get; set; }
		[Range(1, int.MaxValue, ErrorMessage = "English test is required")]
		public int EnglishTestId { get; set; }
		[Range(1, int.MaxValue, ErrorMessage = "Test format is required")]
		public int TestFormatId { get; set; }

		public LabeledDataDto()
		{
			Id = 0;
			UserId = 0;
			Topic = string.Empty;
			Content = string.Empty;
			Score = string.Empty;
			AudioName = string.Empty;
			ImageName = string.Empty;
			TopicId = 0;
			Question = string.Empty;
			EnglishTest = string.Empty;
			TestFormat = string.Empty;
			EnglishTestId = 0;
			TestFormatId = 0;
		}
	}
}

namespace LabeledData.Models
{
	public class LabeledDataAPIDto
	{
		public int Id { get; set; }
		public string Topic { get; set; }
		public string Content { get; set; }
		public string Score { get; set; }
		public string AudioPath { get; set; }
		public string ImagePath { get; set; }
		public string Question { get; set; }
		public string EnglishTest { get; set; }
		public string TestFormat { get; set; }

		public LabeledDataAPIDto()
		{
			Id = 0;
			Topic = string.Empty;
			Content = string.Empty;
			Score = string.Empty;
			AudioPath = string.Empty;
			ImagePath = string.Empty;
			Question = string.Empty;
			EnglishTest = string.Empty;
			TestFormat = string.Empty;
		}
	}
}

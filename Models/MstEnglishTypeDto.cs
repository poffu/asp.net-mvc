namespace LabeledDataManagement.Models
{
	public class MstEnglishTypeDto
	{
		public int Id { get; set; }
		public int TagType { get; set; }
		public string Name { get; set; }

		public MstEnglishTypeDto()
		{
			Id = 0;
			TagType = -1;
			Name = string.Empty;
		}
	}
}

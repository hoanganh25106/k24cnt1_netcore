using System.ComponentModel;

namespace vhaLesson08Models.Models
{
	public class vhaMember
	{
		public string vhaMemberId { get; set; }
		public string vhaUserName { get; set; }
		public string vhaPassword { get; set; }
		[DisplayName("Họ và tên")]
		public string vhaFullName { get; set; }
		public string vhaEmail { get; set; }
	}

}
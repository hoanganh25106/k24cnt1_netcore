using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace vhaLesson09Annotation.Models.DataViewModels
{
	/// <summary>
	/// Data Annotation - Validation
	/// </summary>
	public class vhaMemberRegister
	{
		public int vhaMemberId { get; set; }

		[DisplayName("Tên đăng nhập")]
		[Required(ErrorMessage ="Tên đăng nhập không để trống")]
		[StringLength(20,MinimumLength =3,ErrorMessage ="Tên đăng nhập có độ dài khoảng 3-20 ký tự !")]
		public string vhaUserName { get; set; }

		[DisplayName("Mật khẩu")]
		[Required(ErrorMessage = "Mật khẩu không để trống")]
		[DataType(DataType.Password)]
		public string vhaPassword { get; set; }
		public string vhaEmail { get; set; }
		public string vhaPhoneNumber { get; set; }
		public string vhaFullName { get; set; }
		public DateTime vhaBirthday { get; set; }
	}
}

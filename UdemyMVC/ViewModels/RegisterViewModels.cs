using System.ComponentModel.DataAnnotations;

namespace UdemyMVC.ViewModels
{
	public class RegisterViewModels
	{
		[Required]
		[DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email!")]
		public string Email { get; set; }
		[Required]
		[MaxLength(50)]
		[RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
		public string FullName { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[DataType(DataType.Password)]
		[Compare("Password")]
		public string ConfirmPassword { get; set; }
		public string Role { get; set; }
		public bool RememberMe { get; set; }	 
	}
}

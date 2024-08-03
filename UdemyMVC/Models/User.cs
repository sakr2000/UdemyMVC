using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace UdemyMVC.Models
{
	public class User
	{
		[Key]
        public int ID { get; set; }
		[Required]
		[DataType(DataType.EmailAddress ,ErrorMessage ="Invalid Email!")]
        public string Email { get; set; }
		[Required]
		[MaxLength(50)]
		[RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
		public string FullName { get; set; }
		[Required]
		[DataType(DataType.Password)]
        public string Password { get; set; }
		/*----------------------------------------------------------------------------------*/
		[ForeignKey("Role")]
		public int RoleID { get; set; }

		[ForeignKey("RoleID")]
		public virtual Role Role { get; set; } 
		/*------------------------------------------------------------------------------------*/  
		public virtual ICollection<Enrollment>? Enrolement { get; set; } 

		/*------------------------------------------------------------------------------------*/
		public virtual  ICollection<Course>? Course { get; set; }  // For instructors  not useres! 
		//Just performance
		
		/*-------------------------------------------------------------------------------------*/




	}
}

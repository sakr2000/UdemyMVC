using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyMVC.Models
{
	public class User
	{
		[Key]
        public string ID { get; set; }
		[Required]
		[DataType(DataType.EmailAddress ,ErrorMessage ="Invalid Email!")]
        public string Email { get; set; }
		[Required]
		[MaxLength(50)]
		[RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
		public string FullName { get; set; }
		  
		public string? Image { get; set; }
        public string Address { get; set; }
        public string RoleName { get; set; }
        /*----------------------------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------*/
        public virtual ICollection<Enrollment>? Enrolement { get; set; } 

		/*------------------------------------------------------------------------------------*/
		public virtual  ICollection<Course>? Course { get; set; }  // For instructors  not useres! 
																   //Just performance

		/*-------------------------------------------------------------------------------------*/
		
		public virtual ICollection<CourseRate>? CourseRates { get; set; }
        /*-------------------------------------------------------------------------------------*/



    }
}

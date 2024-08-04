using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyMVC.Models
{
	public class Instructor
	{
		[Key]
        public int ID { get; set; } 

		/*-----------------------------------------------------------------------------------*/
		[ForeignKey("User")]

		[Required]
		public string UserID { get; set;  } 

		[ForeignKey("UserID")]
         public virtual User User { get; set;  }
		/*-----------------------------------------------------------------------------------*/
		[InverseProperty("Instructor")]
		public virtual ICollection<Course>? Courses { get; set; } // navigation
		
		/*-----------------------------------------------------------------------------------*/


	}
}

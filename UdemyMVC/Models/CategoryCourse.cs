using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyMVC.Models
{
	public class CategoryCourse //Okay!
	{ 
		
        public int CourseID { get; set; }
		public int CategoryID { get; set; }
		[ForeignKey("CourseID")]
		public virtual Course Course { get; set; }
		[ForeignKey("CategoryID")]

		public virtual Category Category { get; set; }	

	}
}

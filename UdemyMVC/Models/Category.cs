using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyMVC.Models
{
	public class Category
	{
		[Key]
        public int ID { get; set; } 
		[Required]
		[StringLength(50)]
        public string CategoryName { get; set; }
		/*-----------------------------------------------------------------------------------*/
		//Deleted
		//[InverseProperty("Category")]
		//public virtual ICollection<Course>? Courses { get; set; }
		/*-----------------------------------------------------------------------------------*/



	}
}

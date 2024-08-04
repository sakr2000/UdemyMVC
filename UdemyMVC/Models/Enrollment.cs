using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyMVC.Models
{
	public class Enrollment
	{ 

        public int CourseID { get; set; }
        public string UserID { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EnrollmentDate { get; set; }= DateTime.Now; 


        [ForeignKey("UserID")]
        public virtual  User User { get; set; }
        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }   
        
    }
}

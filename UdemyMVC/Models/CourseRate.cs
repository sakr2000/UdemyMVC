using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyMVC.Models
{
    public class CourseRate
    {
        
        [ForeignKey("User")]
        public string UserID { get; set; }
     
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public int Rate { get; set; }
        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace UdemyMVC.Models
{
    public class ApplicationModel:IdentityUser
    {
        public string Address { get; set; }
        public string Image { get; set; }
        public string? Field { get; set; } = " ";
        /*******************RelationShio*************************/
        /*------------------------------------------------------------------------------------*/
        
        public virtual ICollection<Enrollment>? Enrolement { get; set; }

        /*------------------------------------------------------------------------------------*/
       [InverseProperty("Instructor")]
        public virtual ICollection<Course>? Course { get; set; }  // For instructors  not useres! 
                                                                  //Just performance

        /*-------------------------------------------------------------------------------------*/
        public virtual ICollection<CourseRate>? CourseRates { get; set; }
        /*-------------------------------------------------------------------------------------*/

    }
}

using System.ComponentModel.DataAnnotations;
using UdemyMVC.AttributeValidation;

namespace UdemyMVC.ViewModels
{
    public class CourseViewModel
    {
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string CourseName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(minimum: 400, maximum: 4000)]
        public int Price { get; set; }
        public string? CourseImage { get; set; }
        public int Hours { get; set; }
        public string? InstructorID { get; set; }


    }
}

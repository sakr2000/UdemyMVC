using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UdemyMVC.AttributeValidation;

namespace UdemyMVC.Models
{
	public class Course
	{
		[Required]
		[Key]
		public int ID { get; set; }
		[Required]
		[MaxLength(200)]
        public string  Title { get; set; }
        [Required]
		[MaxLength(100)]
        public string CourseName { get; set; }
		[Required]
        public string Description { get; set; }
		[Required]
		[Range(minimum:400 , maximum:4000)]
		public int Price { get; set; }
		[Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Profile Picture")]
        [MaxFileSize(5 * 1024 * 1024)] // 5 MB
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]

        public string CourseImage { get; set; }
		public int Hours { get; set; } = 60;
        [InverseProperty("Course")]
		public virtual  ICollection<Chapter>? Chapters { get; set; } // Navigation property


		/*-----------------------------------------------------------------*/
		[ForeignKey("Instructor")]
        public string InstructorID { get; set; }
		[ForeignKey("InstructorID")]
		public virtual ApplicationModel Instructor { get; set; }
		/*-----------------------------------------------------------------------------------*/
		//Multiple Category Category!
		public virtual ICollection<CategoryCourse>? CategoryCourses { get; set; }
		/*-----------------------------------------------------------------------------------*/
		public virtual ICollection<Enrollment>? Enrollment { get; set; }
		/*-----------------------------------------------------------------------------------*/
		/*-------------------------------------------------------------------------------------*/
        public virtual ICollection<CourseRate>? CourseRates { get; set; }
        /*-------------------------------------------------------------------------------------*/


    }
}

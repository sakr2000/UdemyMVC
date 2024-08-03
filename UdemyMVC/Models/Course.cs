﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyMVC.Models
{
	public class Course
	{
		[Required]
		[Key]
		public int ID { get; set; }
		[Required]
		[MaxLength(100)]
        public string CourseName { get; set; }
		[Required]
        public string Description { get; set; }
		[Required]
		[Range(minimum:400 , maximum:4000)]
		public int Price { get; set; }
		public ICollection<Chapter> Chapters { get; set; } // Navigation property


		/*-----------------------------------------------------------------*/
		[ForeignKey("Instructor")]
        public int InstructorID { get; set; }
		[ForeignKey("InstructorID")]
		public virtual Instructor Instructor { get; set; }
		/*-----------------------------------------------------------------------------------*/
		//Multiple Category Category!
		public virtual ICollection<CategoryCourse> CategoryCourses { get; set; }
		/*-----------------------------------------------------------------------------------*/
		public virtual ICollection<Enrollment>? Enrollment { get; set; }
		/*-----------------------------------------------------------------------------------*/



	}
}

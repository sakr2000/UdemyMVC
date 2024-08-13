using UdemyMVC.Models;
using UdemyMVC.ViewModels;

namespace UdemyMVC.ServiceLayer
{
    public static class CourseViewToCourse
    {
        public static Course Convert(CourseViewModel vm,string id) {
            Course course = new Course
            {
                Description = vm.Description,
                CourseName = vm.CourseName,
                InstructorID = id,
                Price = vm.Price,
                Title = vm.Title,
                CourseImage = vm.CourseImage,
                Hours= vm.Hours


            };    
        
        return course;  
        }

    }
}

using Microsoft.EntityFrameworkCore;
using UdemyMVC.Models;

namespace UdemyMVC.Repositories
{
    public class CategoryCourseRepository : Repository<CategoryCourse>, ICategoryCourseRepository
    {
        public CategoryCourseRepository(DbContext context) : base(context) { }
    }
}

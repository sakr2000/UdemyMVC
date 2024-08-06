using Microsoft.EntityFrameworkCore;
using UdemyMVC.Models;

namespace UdemyMVC.Repositories
{
    public class CourseRateRepository : Repository<CourseRate>, ICourseRateRepository
    {
        public CourseRateRepository(DbContext context) : base(context) { }
    }
}

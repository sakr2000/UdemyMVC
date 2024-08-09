using Microsoft.EntityFrameworkCore;
using UdemyMVC.Models;

namespace UdemyMVC.Repositories
{
    public class CourseRateRepository : Repository<CourseRate>, ICourseRateRepository
    {
        public CourseRateRepository(UdemyDataBase context) : base(context) { }
    }
}

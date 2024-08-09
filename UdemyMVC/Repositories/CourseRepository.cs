using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using UdemyMVC.Models;

namespace UdemyMVC.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public void Add(Course entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course>? GetAll()
        {
            throw new NotImplementedException();
        }

        public Course? GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Course>> GetCoursesByInstructorIdAsync(int instructorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}

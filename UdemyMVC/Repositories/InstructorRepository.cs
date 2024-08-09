using Microsoft.EntityFrameworkCore;
using UdemyMVC.Models;

namespace UdemyMVC.Repositories
{
    public class InstructorRepository : Repository<Instructor>, IInstructorRepository
    {
        public InstructorRepository(UdemyDataBase context) : base(context) { }
    }
}

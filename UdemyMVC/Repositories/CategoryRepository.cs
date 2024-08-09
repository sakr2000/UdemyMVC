using Microsoft.EntityFrameworkCore;
using UdemyMVC.Models;

namespace UdemyMVC.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(UdemyDataBase context) : base(context) { }
    }
}

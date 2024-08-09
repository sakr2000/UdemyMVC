using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using UdemyMVC.Models;

namespace UdemyMVC.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(UdemyDataBase context) : base(context) { }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}

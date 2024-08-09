using Microsoft.EntityFrameworkCore;
using UdemyMVC.Models;

namespace UdemyMVC.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UdemyDataBase context;

        public UserRepository(UdemyDataBase context )
        {
            this.context = context;
        }
        public void Add(User entity)
        {
           context.Users.Add( entity );
            context.SaveChanges();
        }

        public void Delete(object id)
        {
            string? identifire = id as string; 
           User? user = context.Users.FirstOrDefault(s=>s.ID == identifire);
            if (user != null) {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public IEnumerable<User>? GetAll()
        {
            return context.Users; 
        }

        public User? GetByEmail(string email)
        {
          User? user = context.Users.FirstOrDefault(s=>s.Email == email);
            return user; 
        }

        public User? GetById(object id)
        { 
            string? identifire = id as string;
            return context.Users.FirstOrDefault(s => s.ID == identifire);
        }

        public void Update(User entity)
        { 
            User? user = context.Users.FirstOrDefault(s=>s.ID == entity.ID);
            if (user != null)
            {
                context.Users.Update(entity);
                context.SaveChanges();
            }
        }
    }
}

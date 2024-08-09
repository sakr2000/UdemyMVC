﻿using System.Threading.Tasks;
using UdemyMVC.Models;

namespace UdemyMVC.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User? GetByEmail(string email);
    }
}
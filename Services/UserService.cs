using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using car_rent_system.Contracts;
using car_rent_system.Models;

namespace car_rent_system.Services
{
    public class UserService : IUserService
    {
        public Task<User> GetAllUsers(User user)
        {
            return null;
        }
    }
}
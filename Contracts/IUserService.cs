using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using car_rent_system.Models;

namespace car_rent_system.Contracts
{
    public interface IUserService
    {
        Task<User> GetAllUsers(User user);
    }
}
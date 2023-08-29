using car_rent_system.Contracts;
using car_rent_system.Data;
using car_rent_system.Models;
using Microsoft.EntityFrameworkCore;

namespace car_rent_system.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        public UserService (DataContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAllUsers(User user)
        {
            return await _context.Users.ToListAsync();
        }
        public async Task<User> GetUser(int User_Id)
        {
            return await _context.Users.FindAsync(User_Id);
        }
    }
}
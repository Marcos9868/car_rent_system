using car_rent_system.Contracts;
using car_rent_system.Data;
using car_rent_system.Models;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }
        
        [HttpGet]
        [Route("/users/{Id}")]
        public async Task<User> GetUser(int User_Id)
        {
            return await _context.Users.FindAsync(User_Id);
        }

        [HttpPost]
        [Route("/users")]
        public async Task<User> CreateUser([FromBody] User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;           
        }

        [HttpPut]
        [Route("/users/{Id}")]
        public async Task UpdateUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        [HttpDelete]
        [Route("/users/{Id}")]
        public async Task RemoveUser(int Id)
        {
            var userToDelete = await _context.Users.FindAsync(Id);
            if (userToDelete != null)
            {
                _context.Users.Remove(userToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
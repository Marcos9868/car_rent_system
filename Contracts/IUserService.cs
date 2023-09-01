using car_rent_system.Models;

namespace car_rent_system.Contracts
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUser(int User_Id);
        Task<User> CreateUser(User user);
        Task UpdateUser(User user);
        Task RemoveUser(int Id);
    }
}
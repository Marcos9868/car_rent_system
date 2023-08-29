using car_rent_system.Models;

namespace car_rent_system.Contracts
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers(User user);
        Task<User> GetUser(int User_Id);
    }
}
using BuyMyHouse.Models;

namespace BuyMyHouse.Service.Interfaces
{
    public interface IUserService
    {
        Task<User> GetOneUser(int id);
        Task<User> AddUser(User user);
        Task<User> UpdateUser(int id, User data);
        Task<string> DeleteUser(int id);
    }
}

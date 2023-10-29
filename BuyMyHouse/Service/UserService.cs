using BuyMyHouse.Models;
using BuyMyHouse.Service.Interfaces;

namespace BuyMyHouse.Service
{
    public class UserService : IUserService
    {
        public Task<User> AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetOneUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(int id, User data)
        {
            throw new NotImplementedException();
        }
    }
}

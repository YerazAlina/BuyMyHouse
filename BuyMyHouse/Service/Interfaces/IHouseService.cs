using BuyMyHouse.Models;

namespace BuyMyHouse.Service.Interfaces
{
    public interface IHouseService
    {
        Task<House> GetOneHouse(int id);
        Task<House> AddHouse(House house);
        Task<House> UpdateHouse(int id, House data);
        Task<string> DeleteHouse(int id);
    }
}

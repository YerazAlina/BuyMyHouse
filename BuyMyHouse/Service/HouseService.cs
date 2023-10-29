using BuyMyHouse.Models;
using BuyMyHouse.Service.Interfaces;
using DAL.Repository.Interfaces;

namespace BuyMyHouse.Service
{
    public class HouseService : IHouseService
    {
        private readonly IHouseRepository _houseRepository;

        public HouseService(IHouseRepository houseRepository)
        {
                _houseRepository = houseRepository;
        }

        public Task<House> AddHouse(House house)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteHouse(int id)
        {
            throw new NotImplementedException();
        }

        public Task<House> GetOneHouse(int id)
        {
            throw new NotImplementedException();
        }

        public Task<House> UpdateHouse(int id, House data)
        {
            throw new NotImplementedException();
        }
    }
}

using BuyMyHouse.Models;

namespace BuyMyHouse.Service.Interfaces
{
    public interface IMortgageService
    {
        Task<Mortgage> GetMortgages(int id);
        Task<Mortgage> AddMortgage(Mortgage user);
        Task<Mortgage> UpdateMortgage(int id, Mortgage data);
        Task<string> DeleteMortgage(int id);
        Task<List<Mortgage>> GetMortgages();
    }
}

using BuyMyHouse.Models;
using DAL.Repository.Interfaces;

namespace BuyMyHouse.Service
{
    public class MortgageService : IMortgageRepository
    {
        private readonly IMortgageRepository _mortgageRepository;

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mortgage> GetAll()
        {
            IEnumerable<Mortgage> mortgages = _mortgageRepository.GetAll();
            return mortgages.ToList();
        }

        public Mortgage GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Mortgage obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Mortgage obj)
        {
            throw new NotImplementedException();
        }
    }
}

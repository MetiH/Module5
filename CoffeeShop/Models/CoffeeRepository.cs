using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class CoffeeRepository: ICoffeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public CoffeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Coffee> GetAllCoffees()
        {
            return _appDbContext.coffees;
        }

        public IEnumerable<Coffee> GetAllPies()
        {
            return _appDbContext.coffees;
        }

        public Coffee GetCoffeeById(int coffeeId)
        {
            throw new NotImplementedException();
        }

        public Coffee GetPieById(int coffeeId)
        {
            return _appDbContext.coffees.FirstOrDefault(p => p.Id == coffeeId);
        }
    }
}

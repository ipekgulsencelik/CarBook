using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CarBook.DataAccessLayer.EntityFramework
{
    public class EFPriceDAL : GenericRepository<Price>, IPriceDAL
    {
        public List<Price> GetPricesWithCars()
        {
            var context = new CarBookContext();
            var values = context.Prices.Include(x => x.Car).ThenInclude(y => y.Brand).ToList();
            return values;
        }
    }
}
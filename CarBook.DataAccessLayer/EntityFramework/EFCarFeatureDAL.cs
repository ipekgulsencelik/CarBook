using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CarBook.DataAccessLayer.EntityFramework
{
    public class EFCarFeatureDAL : GenericRepository<CarFeature>, ICarFeatureDAL
    {
        public List<CarFeature> GetFeaturesByCarID(int id)
        {
            var context = new CarBookContext();
            var values = context.CarFeatures.Include(x => x.Car).Where(x => x.CarID == id).ToList();
            return values;
        }
    }
}
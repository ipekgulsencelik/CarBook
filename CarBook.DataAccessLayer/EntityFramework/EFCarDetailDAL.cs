using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CarBook.DataAccessLayer.EntityFramework
{
    public class EFCarDetailDAL : GenericRepository<CarDetail>, ICarDetailDAL
    {
        public CarDetail GetCarDetailByCarID(int id)
        {
            var context = new CarBookContext();
            var values = context.CarDetails.Where(x => x.CarID == id).FirstOrDefault();
            return values;
        }

        public CarDetail GetCarDetailWithAuthor(int id)
        {
            var context = new CarBookContext();
            var values = context.CarDetails.Include(x => x.AppUser).Where(y => y.CarID == id).FirstOrDefault();
            return values;
        }
    }
}
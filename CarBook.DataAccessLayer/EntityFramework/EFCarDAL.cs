using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.Repositories;
using CarBook.DTOLayer.DTOs.CategoryDTOs;
using CarBook.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CarBook.DataAccessLayer.EntityFramework
{
    public class EFCarDAL : GenericRepository<Car>, ICarDAL
    {
        public List<Car> GetAllCarsWithBrands()
        {
            var context = new CarBookContext();
            var values = context.Cars.Include(x => x.Category).Include(x => x.Brand).Include(x => x.Status).ToList();
            return values;
        }

        public List<CategoryDTO> GetCategoryCount()
        {
            var context = new CarBookContext();
            var categories = context.Categories.Select(x => new CategoryDTO
            {
                CategoryName = x.CategoryName,
                CarCount = context.Cars.Count(y => y.CategoryID == x.CategoryID)
            }).ToList();
            return categories;
        }

        public List<Car> GetLast3Cars()
        {
            var context = new CarBookContext();
            var values = context.Cars.Include(x => x.Category).Include(x => x.Brand).Include(x => x.Status).OrderByDescending(x => x.CarID).TakeLast(3).ToList();
            return values;
        }

        public List<Car> GetLast5Cars()
		{
			var context = new CarBookContext();
			var values = context.Cars.Include(x => x.Category).Include(x => x.Brand).Include(x => x.Status).OrderByDescending(x => x.CarID).TakeLast(5).ToList();
			return values;
		}
	}
}
using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.DTOLayer.DTOs.CategoryDTOs;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
	public class CarManager : ICarService
    {
        private readonly ICarDAL _carDAL;

        public CarManager(ICarDAL carDAL)
        {
            _carDAL = carDAL;
        }

        public void TDelete(Car entity)
        {
            _carDAL.Delete(entity);
        }

        public List<Car> TGetAllCarsWithBrands()
        {
            return _carDAL.GetAllCarsWithBrands();
        }

        public Car TGetByID(int id)
        {
            if (id != null)
            {
                return _carDAL.GetByID(id);
            }
            return _carDAL.GetByID(0); // Araba Bulunamadı
        }

        public List<CategoryDTO> TGetCategoryCount()
        {
            return _carDAL.GetCategoryCount();
        }

        public List<Car> TGetLast3Cars()
        {
            return _carDAL.GetLast3Cars();
        }

        public List<Car> TGetLast5Cars()
		{
			return _carDAL.GetLast5Cars();
		}

		public List<Car> TGetListAll()
        {
            // Bıu işlemi yapmaya yetkiliyse
            return _carDAL.GetListAll();
        }

        public void TInsert(Car entity)
        {
            if (entity.Year >= 2010 && entity.Prices.Count > 0 && entity.Km <= 500000)
            {
                _carDAL.Insert(entity);
            }
            // hata mesajı --> Fluent Validation
        }

        public void TUpdate(Car entity)
        {
            _carDAL.Update(entity);
        }
    }
}
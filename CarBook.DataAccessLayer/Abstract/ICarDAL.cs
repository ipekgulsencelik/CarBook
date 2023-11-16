using CarBook.DTOLayer.DTOs.CategoryDTOs;
using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.Abstract
{
    public interface ICarDAL : IGenericDAL<Car>
    {
        List<Car> GetAllCarsWithBrands();
        List<CategoryDTO> GetCategoryCount();
        List<Car> GetLast5Cars();
    }
}
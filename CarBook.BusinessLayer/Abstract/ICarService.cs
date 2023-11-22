using CarBook.DTOLayer.DTOs.CategoryDTOs;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        List<Car> TGetAllCarsWithBrands();
        List<CategoryDTO> TGetCategoryCount();
        List<Car> TGetLast5Cars();
        List<Car> TGetLast3Cars();
	}
}
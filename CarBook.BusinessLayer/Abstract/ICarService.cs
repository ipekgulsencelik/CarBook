using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        List<Car> TGetAllCarsWithBrands();
    }
}
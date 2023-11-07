using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Abstract
{
    public interface ICarDetailService : IGenericService<CarDetail>
    {
        CarDetail TGetCarDetailByCarID(int id);
    }
}
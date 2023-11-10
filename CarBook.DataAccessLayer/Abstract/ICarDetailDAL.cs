using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.Abstract
{
    public interface ICarDetailDAL : IGenericDAL<CarDetail>
    {
        CarDetail GetCarDetailByCarID(int id);
        CarDetail GetCarDetailWithAuthor(int id);
    }
}
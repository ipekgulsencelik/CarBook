using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class CarDetailManager : ICarDetailService
    {
        private readonly ICarDetailDAL _carDetailDAL;

        public CarDetailManager(ICarDetailDAL carDetailDAL)
        {
            _carDetailDAL = carDetailDAL;
        }

        public void TDelete(CarDetail entity)
        {
            _carDetailDAL.Delete(entity);
        }

        public CarDetail TGetByID(int id)
        {
            if (id != null)
            {
                return _carDetailDAL.GetByID(id);
            }
            return _carDetailDAL.GetByID(0);
        }

        public CarDetail TGetCarDetailByCarID(int id)
        {
            return _carDetailDAL.GetCarDetailByCarID(id);
        }

        public CarDetail TGetCarDetailWithAuthor(int id)
        {
            return _carDetailDAL.GetCarDetailWithAuthor(id);
        }

        public List<CarDetail> TGetListAll()
        {
            return _carDetailDAL.GetListAll();
        }

        public void TInsert(CarDetail entity)
        {
            _carDetailDAL.Insert(entity);
        }

        public void TUpdate(CarDetail entity)
        {
            _carDetailDAL.Update(entity);
        }
    }
}
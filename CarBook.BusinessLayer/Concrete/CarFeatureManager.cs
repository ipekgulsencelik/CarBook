using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class CarFeatureManager : ICarFeatureService
    {
        private readonly ICarFeatureDAL _carFeatureDAL;

        public CarFeatureManager(ICarFeatureDAL carFeatureDAL)
        {
            _carFeatureDAL = carFeatureDAL;
        }

        public void TDelete(CarFeature entity)
        {
            _carFeatureDAL.Delete(entity);
        }

        public CarFeature TGetByID(int id)
        {
            return _carFeatureDAL.GetByID(id);
        }

        public List<CarFeature> TGetFeaturesByCarID(int id)
        {
            return _carFeatureDAL.GetFeaturesByCarID(id);
        }

        public List<CarFeature> TGetListAll()
        {
            return _carFeatureDAL.GetListAll();
        }

        public void TInsert(CarFeature entity)
        {
            _carFeatureDAL.Insert(entity);
        }

        public void TUpdate(CarFeature entity)
        {
            _carFeatureDAL.Update(entity);
        }
    }
}
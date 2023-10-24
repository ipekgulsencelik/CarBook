using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class LocationManager : ILocationService
    {
        private readonly ILocationDAL _locationDAL;

        public LocationManager(ILocationDAL locationDAL)
        {
            _locationDAL = locationDAL;
        }

        public void TDelete(Location entity)
        {
            _locationDAL.Delete(entity);
        }

        public Location TGetByID(int id)
        {
            return _locationDAL.GetByID(id);
        }

        public List<Location> TGetListAll()
        {
            return _locationDAL.GetListAll();
        }

        public void TInsert(Location entity)
        {
            _locationDAL.Insert(entity);
        }

        public void TUpdate(Location entity)
        {
            _locationDAL.Update(entity);
        }
    }
}
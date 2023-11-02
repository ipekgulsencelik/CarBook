using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDAL _serviceDAL;

        public ServiceManager(IServiceDAL serviceDAL)
        {
            _serviceDAL = serviceDAL;
        }

        public void TDelete(Service entity)
        {
            _serviceDAL.Delete(entity);
        }

        public Service TGetByID(int id)
        {
            return _serviceDAL.GetByID(id);
        }

        public List<Service> TGetListAll()
        {
            return _serviceDAL.GetListAll();
        }

        public void TInsert(Service entity)
        {
            _serviceDAL.Insert(entity);
        }

        public void TUpdate(Service entity)
        {
            _serviceDAL.Update(entity);
        }
    }
}
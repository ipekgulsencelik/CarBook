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

        public void TUpdateStatus(Service service)
        {
            _serviceDAL.UpdateStatus(service);
        }

        public void TDelete(Service entity)
        {
            _serviceDAL.Delete(entity);
        }

        public Service TGetByID(int id)
        {
            return _serviceDAL.GetByID(id);
        }

        public List<Service> TGetLast3MainServices()
        {
            return _serviceDAL.GetLast3MainServices();
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

        public void TUpdateIsHome(Service service)
        {
            _serviceDAL.UpdateIsHome(service);
        }

        public List<Service> TGetActiveServices()
        {
            return _serviceDAL.GetActiveServices();
        }
    }
}
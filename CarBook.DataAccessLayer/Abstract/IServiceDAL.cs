using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.Abstract
{
    public interface IServiceDAL : IGenericDAL<Service>
    {
        List<Service> GetActiveServices();
        void UpdateIsHome(Service service);
        void UpdateStatus(Service service);
        List<Service> GetLast3MainServices();
    }
}
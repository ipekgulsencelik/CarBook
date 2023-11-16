using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Abstract
{
    public interface IServiceService : IGenericService<Service>
    {
        List<Service> TGetActiveServices();
        void TUpdateIsHome(Service service);
        void TUpdateStatus(Service service);
        List<Service> TGetLast3MainServices();
    }
}
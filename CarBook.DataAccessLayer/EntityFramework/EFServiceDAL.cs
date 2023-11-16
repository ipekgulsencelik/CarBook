using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.EntityFramework
{
    public class EFServiceDAL : GenericRepository<Service>, IServiceDAL
    {
        public void UpdateStatus(Service service)
        {
            var context = new CarBookContext();
            if (service.Status == true)
            {
                service.Status = false;
            }                
            else
            {
                service.Status = true;
            }
            context.Update(service);
            context.SaveChanges();
        }

        public List<Service> GetLast3MainServices()
        {
            var context = new CarBookContext();
            var values = context.Services.Where(x => x.Status == true && x.IsHome == true).OrderByDescending(x => x.ServiceID).Take(3).ToList();
            return values;
        }

        public void UpdateIsHome(Service service)
        {
            var context = new CarBookContext();
            if (service.IsHome == true)
            {
                service.IsHome = false;
            }
            else
            {
                service.IsHome = true;
            }
            context.Update(service);
            context.SaveChanges();
        }

        public List<Service> GetActiveServices()
        {
            var context = new CarBookContext();
            var values = context.Services.Where(x => x.Status == true).ToList();
            return values;
        }
    }
}
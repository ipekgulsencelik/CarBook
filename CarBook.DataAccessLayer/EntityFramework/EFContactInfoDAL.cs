using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.EntityFramework
{
    public class EFContactInfoDAL : GenericRepository<ContactInfo>, IContactInfoDAL
    {
        public ContactInfo GetActiveContactInfo()
        {
            var context = new CarBookContext();
            var value = context.ContactInfos.Where(x => x.Status == true).FirstOrDefault();
            return value;
        }
    }
}
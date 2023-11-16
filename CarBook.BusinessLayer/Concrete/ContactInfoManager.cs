using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class ContactInfoManager : IContactInfoService
    {
        private readonly IContactInfoDAL _contactInfoDAL;

        public ContactInfoManager(IContactInfoDAL contactInfoDAL)
        {
            _contactInfoDAL = contactInfoDAL;
        }

        public void TDelete(ContactInfo entity)
        {
            _contactInfoDAL.Delete(entity);
        }

        public ContactInfo TGetActiveContactInfo()
        {
            return _contactInfoDAL.GetActiveContactInfo();
        }

        public ContactInfo TGetByID(int id)
        {
            return _contactInfoDAL.GetByID(id);
        }

        public List<ContactInfo> TGetListAll()
        {
            return _contactInfoDAL.GetListAll();
        }

        public void TInsert(ContactInfo entity)
        {
            _contactInfoDAL.Insert(entity);
        }

        public void TUpdate(ContactInfo entity)
        {
            _contactInfoDAL.Update(entity);
        }
    }
}
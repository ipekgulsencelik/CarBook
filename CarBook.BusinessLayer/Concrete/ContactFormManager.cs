using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class ContactFormManager : IContactFormService
    {
        private readonly IContactFormDAL _contactFormDAL;

        public ContactFormManager(IContactFormDAL contactFormDAL)
        {
            _contactFormDAL = contactFormDAL;
        }

        public void TDelete(ContactForm entity)
        {
            throw new NotImplementedException();
        }

        public ContactForm TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactForm> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TInsert(ContactForm entity)
        {
            _contactFormDAL.Insert(entity);
        }

        public void TUpdate(ContactForm entity)
        {
            throw new NotImplementedException();
        }
    }
}
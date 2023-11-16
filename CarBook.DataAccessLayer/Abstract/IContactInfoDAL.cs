using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.Abstract
{
    public interface IContactInfoDAL : IGenericDAL<ContactInfo>
    {
        ContactInfo GetActiveContactInfo();
    }
}
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Abstract
{
    public interface IContactInfoService : IGenericService<ContactInfo>
    {
        ContactInfo TGetActiveContactInfo();
    }
}
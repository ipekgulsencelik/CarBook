using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Abstract
{
    public interface IAboutService : IGenericService<About>
    {
        About TGetAbout();
        void TUpdateStatus(About about);
    }
}
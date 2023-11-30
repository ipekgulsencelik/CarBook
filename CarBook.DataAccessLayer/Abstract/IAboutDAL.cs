using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.Abstract
{
    public interface IAboutDAL : IGenericDAL<About>
    {
        About GetAbout();
        void UpdateStatus(About about);
    }
}
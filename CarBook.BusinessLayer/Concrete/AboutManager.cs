using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void TDelete(About entity)
        {
            _aboutDAL.Delete(entity);
        }

        public About TGetAbout()
        {
            return _aboutDAL.GetAbout();
        }

        public About TGetByID(int id)
        {
            return _aboutDAL.GetByID(id);
        }

        public List<About> TGetListAll()
        {
            return _aboutDAL.GetListAll();
        }

        public void TInsert(About entity)
        {
            _aboutDAL.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutDAL.Update(entity);
        }
    }
}
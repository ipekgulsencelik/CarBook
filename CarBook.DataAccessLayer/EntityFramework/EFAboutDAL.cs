using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.EntityFramework
{
    public class EFAboutDAL : GenericRepository<About>, IAboutDAL
    {
        public About GetAbout()
        {
            var context = new CarBookContext();
            var value = context.Abouts.Where(x => x.Status == true).OrderByDescending(x => x.AboutID).Take(1).FirstOrDefault();
            return value;
        }
    }
}
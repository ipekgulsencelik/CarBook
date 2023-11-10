using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.EntityFramework
{
    public class EFCommentDAL : GenericRepository<Comment>, ICommentDAL
    {
        public List<Comment> GetCommentsByCar(int id)
        {
            var context = new CarBookContext();
            var values = context.Comments.Where(x => x.CarID == id).ToList();
            return values;
        }
    }
}
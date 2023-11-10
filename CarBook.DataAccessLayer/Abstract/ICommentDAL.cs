using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.Abstract
{
    public interface ICommentDAL : IGenericDAL<Comment>
    {
        List<Comment> GetCommentsByCar(int id);
    }
}
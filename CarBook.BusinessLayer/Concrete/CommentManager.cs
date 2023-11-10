using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDAL _commentDAL;

        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public void TDelete(Comment entity)
        {
            _commentDAL.Delete(entity);
        }

        public Comment TGetByID(int id)
        {
            return _commentDAL.GetByID(id);
        }

        public List<Comment> TGetCommentsByCar(int id)
        {
            return _commentDAL.GetCommentsByCar(id);
        }

        public List<Comment> TGetListAll()
        {
            return _commentDAL.GetListAll();
        }

        public void TInsert(Comment entity)
        {
            _commentDAL.Insert(entity);
        }

        public void TUpdate(Comment entity)
        {
            _commentDAL.Update(entity);
        }
    }
}
using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.Abstract
{
    public interface IHistoryDAL : IGenericDAL<History>
    {
        History GetHistory();
        void UpdateStatus(History history);
    }
}
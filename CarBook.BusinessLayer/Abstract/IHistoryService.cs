using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Abstract
{
    public interface IHistoryService : IGenericService<History>
    {
        History TGetHistory();
        void TUpdateStatus(History history);
    }
}
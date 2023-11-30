using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class HistoryManager : IHistoryService
    {
        private readonly IHistoryDAL _historyDAL;

        public HistoryManager(IHistoryDAL historyDAL)
        {
            _historyDAL = historyDAL;
        }

        public void TDelete(History entity)
        {
            _historyDAL.Delete(entity);
        }

        public History TGetByID(int id)
        {
            return _historyDAL.GetByID(id);
        }

        public History TGetHistory()
        {
            return _historyDAL.GetHistory();
        }

        public List<History> TGetListAll()
        {
            return _historyDAL.GetListAll();
        }

        public void TInsert(History entity)
        {
            _historyDAL.Insert(entity);
        }

        public void TUpdate(History entity)
        {
            _historyDAL.Update(entity);
        }

        public void TUpdateStatus(History history)
        {
            _historyDAL.UpdateStatus(history);
        }
    }
}
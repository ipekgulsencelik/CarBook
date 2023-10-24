using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class StatusManager : IStatusService
    {
        private readonly IStatusDAL _statusDAL;

        public StatusManager(IStatusDAL statusDAL)
        {
            _statusDAL = statusDAL;
        }

        public void TDelete(Status entity)
        {
            _statusDAL.Delete(entity);
        }

        public Status TGetByID(int id)
        {
            return _statusDAL.GetByID(id);
        }

        public List<Status> TGetListAll()
        {
            return _statusDAL.GetListAll();
        }

        public void TInsert(Status entity)
        {
            _statusDAL.Insert(entity);
        }

        public void TUpdate(Status entity)
        {
            _statusDAL.Update(entity);
        }
    }
}
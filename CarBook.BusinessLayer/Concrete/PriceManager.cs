using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    internal class PriceManager : IPriceService
    {
        private readonly IPriceDAL _priceDAL;

        public PriceManager(IPriceDAL priceDAL)
        {
            _priceDAL = priceDAL;
        }

        public void TDelete(Price entity)
        {
            _priceDAL.Delete(entity);
        }

        public Price TGetByID(int id)
        {
            return _priceDAL.GetByID(id);
        }

        public List<Price> TGetListAll()
        {
            return _priceDAL.GetListAll();
        }

        public void TInsert(Price entity)
        {
            _priceDAL.Insert(entity);
        }

        public void TUpdate(Price entity)
        {
            _priceDAL.Update(entity);
        }
    }
}
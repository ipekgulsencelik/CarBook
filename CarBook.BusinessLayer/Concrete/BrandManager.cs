using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDAL _brandDAL;

        public BrandManager(IBrandDAL brandDAL)
        {
            _brandDAL = brandDAL;
        }

        public void TDelete(Brand entity)
        {
            _brandDAL.Delete(entity);
        }

        public Brand TGetByID(int id)
        {
            return _brandDAL.GetByID(id);
        }

        public List<Brand> TGetListAll()
        {
            return _brandDAL.GetListAll();
        }

        public void TInsert(Brand entity)
        {
            _brandDAL.Insert(entity);
        }

        public void TUpdate(Brand entity)
        {
            _brandDAL.Update(entity);
        }
    }
}
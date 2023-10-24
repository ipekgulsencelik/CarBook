using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            this.categoryDAL = categoryDAL;
        }

        public void TDelete(Category entity)
        {
            this.categoryDAL.Delete(entity);
        }
        
        public Category TGetByID(int id)
        {
            return this.categoryDAL.GetByID(id);
        }

        public List<Category> TGetListAll()
        {
            return this.categoryDAL.GetListAll();
        }

        public void TInsert(Category entity)
        {
            this.categoryDAL.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            this.categoryDAL.Update(entity);
        }
    }
}
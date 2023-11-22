using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.Abstract
{
    public interface ICarFeatureDAL : IGenericDAL<CarFeature>
    {
        List<CarFeature> GetFeaturesByCarID(int id);
    }
}
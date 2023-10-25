using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Abstract
{
    public interface IPriceService : IGenericService<Price>
    {
        public List<Price> TGetPricesWithCars();
    }
}

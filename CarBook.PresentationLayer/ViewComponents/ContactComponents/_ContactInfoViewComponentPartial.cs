using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.ContactComponents
{
    public class _ContactInfoViewComponentPartial : ViewComponent
    {
        private readonly IContactInfoDAL _contactInfoDAL;

        public _ContactInfoViewComponentPartial(IContactInfoDAL contactInfoDAL)
        {
            _contactInfoDAL = contactInfoDAL;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactInfoDAL.GetActiveContactInfo();
            return View(values);
        }
    }
}
using CarBook.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.ContactComponents
{
    public class _ContactHeadViewComponentPartial : ViewComponent
    {
        private readonly IContactInfoDAL _contactInfoDAL;

        public _ContactHeadViewComponentPartial(IContactInfoDAL contactInfoDAL)
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
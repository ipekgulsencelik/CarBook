using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.AboutComponents
{
    public class _AboutCompanyViewComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutCompanyViewComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _aboutService.TGetAbout();
            return View(value);
        }
    }
}
using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.DefaultComponents
{
    public class _DefaultServiceViewComponentPartial : ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _DefaultServiceViewComponentPartial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _serviceService.TGetLast3MainServices();
            return View(values);
        }
    }
}
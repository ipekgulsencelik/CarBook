using CarBook.BusinessLayer.Abstract;
using CarBook.BusinessLayer.ValidationRules.ServiceValidation;
using CarBook.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            ViewBag.mainTitle = "Hizmetlerimiz";
            ViewBag.subTitle = "Sizin İçin Hizmet Listemiz";
            var values = _serviceService.TGetActiveServices();
            return View(values);
        }

        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            CreateServiceValidator validationRules = new CreateServiceValidator();
            ValidationResult result = validationRules.Validate(service);

            if (result.IsValid)
            {
                _serviceService.TInsert(service);
                return RedirectToAction("ServiceList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        public IActionResult UpdateIsHome(int id)
        {
            var value = _serviceService.TGetByID(id);
            _serviceService.TUpdateIsHome(value);
            return RedirectToAction("ServiceList");
        }

        public IActionResult UpdateServiceStatus(int id)
        {
            var value = _serviceService.TGetByID(id);
            _serviceService.TUpdateStatus(value);
            return RedirectToAction("ServiceList");
        }

        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.TGetByID(id);
            _serviceService.TDelete(value);
            return RedirectToAction("ServiceList");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = _serviceService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return RedirectToAction("ServiceList");
        }
    }
}
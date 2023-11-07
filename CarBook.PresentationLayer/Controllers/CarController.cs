using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ICarDetailService _carDetailService;

        public CarController(ICarService carService, ICarDetailService carDetailService)
        {
            _carService = carService;
            _carDetailService = carDetailService;
        }

        public IActionResult Index()
        {
            var values = _carService.TGetAllCarsWithBrands();
            return View(values);
        }

        public IActionResult CarList() 
        {
            ViewBag.mainTitle = "Araç Listesi";
            ViewBag.subTitle = "Sizin İçin Araç Listemiz";
            var values = _carService.TGetAllCarsWithBrands();
            return View(values);
        }

        public IActionResult CarDetail(int id)
        {
            ViewBag.mainTitle = "Araç Detayları";
            ViewBag.subTitle = "Son Araç Detayları";
            var value = _carDetailService.TGetCarDetailByCarID(id);
            ViewBag.description = value.Description;
            return View(value);
        }
    }
}
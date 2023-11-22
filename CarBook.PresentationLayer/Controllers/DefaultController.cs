using CarBook.BusinessLayer.Abstract;
using CarBook.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Json;

namespace CarBook.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICarService _carService;

        public DefaultController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            var carList = _carService.TGetAllCarsWithBrands();

            var brandList = carList.Select(x => x.Brand.BrandName).Distinct().ToList();
            IEnumerable<SelectListItem> brands = (from x in brandList
                                                  select new SelectListItem
                                                  {
                                                      Text = x,
                                                      Value = x
                                                  }).ToList();
            ViewBag.brands = brands;

            var gasList = carList.Select(x => x.GasType).Distinct().ToList();
            IEnumerable<SelectListItem> gasTypes = (from x in gasList
                                                    select new SelectListItem
                                                    {
                                                        Text = x,
                                                        Value = x,

                                                    }).ToList();
            ViewBag.gasTypes = gasTypes;

            var transmissionList = carList.Select(x => x.Transmission).Distinct().ToList();
            IEnumerable<SelectListItem> transmissions = (from x in transmissionList
                                                         select new SelectListItem
                                                     {
                                                         Text = x,
                                                         Value = x,

                                                     }).ToList();

            ViewBag.transmissions = transmissions;

            //List<SelectListItem> seats = new List<SelectListItem>();
            //var seatData = new[]
            //{
            //     new SelectListItem{ Value="2", Text="2"},
            //     new SelectListItem{ Value="3", Text="3"},
            //     new SelectListItem{ Value="4", Text="4"},
            //     new SelectListItem{ Value="5", Text="5"},
            //     new SelectListItem{ Value="6", Text="6"},
            //};
            //seats = seatData.ToList();
            //ViewBag.seats = seats;

            //List<SelectListItem> transmissions = new List<SelectListItem>();
            //var transmissionData = new[]
            //{
            //     new SelectListItem{ Value="Manuel", Text="Manuel"},
            //     new SelectListItem{ Value="Otomatik", Text="Otomatik"},
            //};
            //transmissions = transmissionData.ToList();
            //ViewBag.transmissions = transmissions;

            return View();
        }

        [HttpGet]
        public PartialViewResult RentCar()
        {
            var carList = _carService.TGetAllCarsWithBrands();

            var brandList = carList.Select(x => x.Brand.BrandName).Distinct().ToList();
            IEnumerable<SelectListItem> brands = (from x in brandList
                                         select new SelectListItem
                                         {
                                             Text = x,
                                             Value = x
                                         }).ToList();
            ViewBag.brands = brands;

            var gasList = carList.Select(x => x.GasType).Distinct().ToList();
            IEnumerable<SelectListItem> gasTypes = (from x in gasList
                                                    select new SelectListItem
                                                    {
                                                        Text = x,
                                                        Value = x,

                                                    }).ToList();
            ViewBag.gasTypes = gasTypes;

            var transmissionList = carList.Select(x => x.Transmission).Distinct().ToList();
            IEnumerable<SelectListItem> transmissions = (from x in transmissionList
                                                         select new SelectListItem
                                                         {
                                                             Text = x,
                                                             Value = x,

                                                         }).ToList();

            ViewBag.transmissions = transmissions;

            return PartialView();
        }

        [HttpPost]
        public IActionResult RentCar(RentCarViewModel car)
        {
            ViewData["brand"] = car.Brand;
            ViewData["year"] = car.Year;
            ViewData["gasType"] = car.GasType;
            ViewData["transmission"] = car.Transmission;

            var values = _carService.TGetAllCarsWithBrands();

            if (!string.IsNullOrEmpty(car.Brand) || car.Year != null || !string.IsNullOrEmpty(car.GasType) || !string.IsNullOrEmpty(car.Transmission))
            {
                var lowerCaseBrand = car.Brand.ToLower();
                var lowerCaseGasType = car.GasType.ToLower();
                var lowerCaseTransmission = car.Transmission.ToLower();
                values = values.Where(x => x.Brand.BrandName.ToLower().Contains(lowerCaseBrand) && x.Year >= car.Year && x.Transmission.ToLower() == lowerCaseTransmission && x.GasType.ToLower() == lowerCaseGasType).ToList();

                TempData["filteredCars"] = JsonSerializer.Serialize(values);
                return RedirectToAction("Index", "RentCar");
            }

            return RedirectToAction("Index");
        }
    }
}
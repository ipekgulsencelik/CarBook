using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

            List<SelectListItem> cars = (from x in carList
                                         select new SelectListItem
                                         {
                                             Text = x.Brand.BrandName + " " + x.Model,
                                             Value = x.CarID.ToString()
                                         }).ToList();
            ViewBag.cars = cars;

            var seatList = carList.Select(x => x.Seat).Distinct().ToList();
            IEnumerable<SelectListItem> seats = (from x in seatList
                                                    select new SelectListItem
                                                    {
                                                        Text = x.ToString(),
                                                        Value = x.ToString(),

                                                    }).ToList();

            ViewBag.seats = seats;

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

            List<SelectListItem> cars = (from x in carList
                                         select new SelectListItem
                                         {
                                             Text = x.Brand.BrandName + " " + x.Model,
                                             Value = x.CarID.ToString()
                                         }).ToList();
            ViewBag.cars = cars;

            var seatList = carList.Select(x => x.Seat).Distinct().ToList();
            IEnumerable<SelectListItem> seats = (from x in seatList
                                                 select new SelectListItem
                                                 {
                                                     Text = x.ToString(),
                                                     Value = x.ToString(),

                                                 }).ToList();

            ViewBag.seats = seats;

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
    }
}
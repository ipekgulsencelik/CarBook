using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

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

        public IActionResult Index(int page=1)
        {
            
            var cars = _carService.TGetAllCarsWithBrands();
            var values = cars.ToPagedList(page, 3);
            return View(values);
        }

        public IActionResult CarList(int page=1) 
        {
            ViewBag.mainTitle = "Araç Listesi";
            ViewBag.subTitle = "Sizin İçin Araç Listemiz";
            var cars = _carService.TGetAllCarsWithBrands();
            var values = cars.ToPagedList(page, 3);
            return View(values);
        }

        public IActionResult CarDetail(int id)
        {
            ViewBag.mainTitle = "Araç Detayları";
            ViewBag.subTitle = "Son Araç Detayları";
            ViewBag.id = id;
            //var value = _carDetailService.TGetCarDetailByCarID(id);
            //ViewBag.description = value.Description;
            //return View(value);
            return View();
        }

        public PartialViewResult MakeComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }

        //[HttpPost]
        //public IActionResult MakeComment(ReviewDto reviewDto)
        //{
        //    var newReview = _mapper.Map<Review>(reviewDto);
        //    newReview.CommentDate = DateTime.Now;
        //    _reviewService.TInsert(newReview);
        //    return RedirectToAction("Index");
        //}
    }
}
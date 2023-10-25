using CarBook.BusinessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class StatusController : Controller
    {
        private readonly IStatusService _statusService;
        private readonly ICarService _carService;

        public StatusController(IStatusService statusService, ICarService carService)
        {
            _statusService = statusService;
            _carService = carService;
        }

        public IActionResult Index()
        {
            var values = _statusService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateStatus()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStatus(Status status)
        {
            _statusService.TInsert(status);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveStatus(int id)
        {
            var value = _statusService.TGetByID(id);
            _statusService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateStatus(int id)
        {
            var values = _statusService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateStatus(Status status)
        {
            _statusService.TUpdate(status);
            return RedirectToAction("Index");
        }

        public IActionResult StatusDetails(int id)
        {
            var values = _carService.TGetListAll().Where(x => x.StatusID == id).ToList();
            return View(values);
        }
    }
}
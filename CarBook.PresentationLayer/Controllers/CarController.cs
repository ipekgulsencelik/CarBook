using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

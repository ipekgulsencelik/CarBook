using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.mainTitle = "İletişim";
            ViewBag.subTitle = "Sizin İçin İletişim Kanallarımız";
            return View();
        }

        public IActionResult ContactInfoList()
        {
            return View();
        }
    }
}
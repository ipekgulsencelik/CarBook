using CarBook.BusinessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactFormService _contactFormService;

        public ContactController(IContactFormService contactFormService)
        {
            _contactFormService = contactFormService;
        }

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

        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(ContactForm message)
        {
            if (message.FirstName != null && message.LastName != null && message.Email != null && message.Message != null)
            {
                ViewBag.message = "Model is valid";
                _contactFormService.TInsert(message);
                return NoContent();
            }
            return NoContent();
        }
    }
}
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

        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        //[HttpPost]
        //public IActionResult SendMessage(Message message)
        //{

        //    if (message.Name != null && message.Subject != null && message.Email != null && message.MessageBody != null)
        //    {
        //        ViewBag.message = "Model is valid";
        //        _messageService.TInsert(message);
        //        return NoContent();
        //    }
        //    return NoContent();
        //}
    }
}
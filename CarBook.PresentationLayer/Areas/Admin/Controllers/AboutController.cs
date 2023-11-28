using CarBook.BusinessLayer.Abstract;
using CarBook.BusinessLayer.ValidationRules.AboutValidation;
using CarBook.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AboutController(IAboutService aboutService, IWebHostEnvironment webHostEnvironment)
        {
            _aboutService = aboutService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var values = _aboutService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(About about, IFormFile image)
        {
            CreateAboutValidator validationRules = new CreateAboutValidator();
            ValidationResult result = validationRules.Validate(about);

            if (result.IsValid)
            {
                string uniqueFileName = null;

                if (image != null)
                {
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        image.CopyTo(fileStream);
                    }
                    about.ImageURL = uniqueFileName;
                }
                _aboutService.TInsert(about);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
    }
}
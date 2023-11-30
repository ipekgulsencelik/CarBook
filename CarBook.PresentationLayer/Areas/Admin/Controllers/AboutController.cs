using AutoMapper;
using CarBook.BusinessLayer.Abstract;
using CarBook.BusinessLayer.ValidationRules.AboutValidation;
using CarBook.DTOLayer.DTOs.AboutDTOs;
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
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IWebHostEnvironment webHostEnvironment, IMapper mapper)
        {
            _aboutService = aboutService;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
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

        public IActionResult UpdateAboutStatus(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TUpdateStatus(value);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            //var value = _mapper.Map<AboutDTO>(about);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(AboutDTO about, IFormFile image)
        {
            var value = _aboutService.TGetByID(about.AboutID);

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
            else
            {
                about.ImageURL = value.ImageURL;
            }

            _aboutService.TUpdate(_mapper.Map<About>(about));
            return RedirectToAction("Index");
        }
    }
}
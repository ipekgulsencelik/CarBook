using CarBook.BusinessLayer.Abstract;
using CarBook.BusinessLayer.ValidationRules.AboutValidation;
using CarBook.BusinessLayer.ValidationRules.HistoryValidation;
using CarBook.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]")]
	public class HistoryController : Controller
    {
        private readonly IHistoryService _historyService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HistoryController(IHistoryService historyService, IWebHostEnvironment webHostEnvironment)
        {
            _historyService = historyService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var values = _historyService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateHistory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateHistory(History history, IFormFile image)
        {
            CreateHistoryValidator validationRules = new CreateHistoryValidator();
            ValidationResult result = validationRules.Validate(history);

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
                    history.ImageURL = uniqueFileName;
                }
                _historyService.TInsert(history);
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

        public IActionResult DeleteHistory(int id)
        {
            var value = _historyService.TGetByID(id);
            _historyService.TDelete(value);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateHistoryStatus(int id)
        {
            var value = _historyService.TGetByID(id);
            _historyService.TUpdateStatus(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateHistory(int id)
        {
            var value = _historyService.TGetByID(id);
            return View(value);
        }
    }
}
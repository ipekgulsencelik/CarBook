using CarBook.BusinessLayer.Abstract;
using CarBook.BusinessLayer.ValidationRules.TeamValidation;
using CarBook.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace CarBook.PresentationLayer.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TeamController(ITeamService teamService, IWebHostEnvironment webHostEnvironment)
        {
            _teamService = teamService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var values = _teamService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTeam(Team team, IFormFile image)
        {
            CreateTeamValidator validationRules = new CreateTeamValidator();
            ValidationResult result = validationRules.Validate(team);

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
                    team.ImageURL = uniqueFileName;
                }
                else
                { 
                    Image img = new Bitmap(1, 1);
                    Graphics drawing = Graphics.FromImage(img);

                    String text = team.FullName.Substring(0, 1);
                    Font font = new Font(FontFamily.GenericSerif, 45, FontStyle.Bold);

                    SizeF textSize = drawing.MeasureString(text, font);

                    img.Dispose();
                    drawing.Dispose();

                    img = new Bitmap(110, 110);

                    drawing = Graphics.FromImage(img);

                    Color backColor = ColorTranslator.FromHtml("#83B869");

                    drawing.Clear(backColor);

                    Color textColor = ColorTranslator.FromHtml("#FFF");

                    Brush textBrush = new SolidBrush(textColor);
 
                    drawing.DrawString(text, font, textBrush, new Rectangle(-2, 20, 200, 110));

                    drawing.Save();

                    textBrush.Dispose();
                    drawing.Dispose();

                    uniqueFileName = Guid.NewGuid().ToString() + "_" + team.FullName + ".jpg";
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    img.Save(filePath);
                    team.ImageURL = uniqueFileName;
                }

                _teamService.TInsert(team);
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
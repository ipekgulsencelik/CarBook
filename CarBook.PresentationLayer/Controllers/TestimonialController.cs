using CarBook.BusinessLayer.Abstract;
using CarBook.BusinessLayer.ValidationRules.TestimonialValidation;
using CarBook.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;

namespace CarBook.PresentationLayer.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TestimonialController(ITestimonialService testimonialService, IWebHostEnvironment webHostEnvironment)
        {
            _testimonialService = testimonialService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var values = _testimonialService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial, IFormFile image)
        {
            CreateTestimonialValidator validationRules = new CreateTestimonialValidator();
            ValidationResult result = validationRules.Validate(testimonial);

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
                    testimonial.ImageURL = uniqueFileName;
                }
                else
                {
                    //first, create a dummy bitmap just to get a graphics object  
                    Image img = new Bitmap(1, 1);
                    Graphics drawing = Graphics.FromImage(img);

                    String text = testimonial.FullName.Substring(0, 1);
                    Font font = new Font(FontFamily.GenericSerif, 45, FontStyle.Bold);

                    //measure the string to see how big the image needs to be  
                    SizeF textSize = drawing.MeasureString(text, font);

                    //free up the dummy image and old graphics object  
                    img.Dispose();
                    drawing.Dispose();

                    //create a new image of the right size  
                    img = new Bitmap(110, 110);

                    drawing = Graphics.FromImage(img);

                    Color backColor = ColorTranslator.FromHtml("#83B869");

                    //paint the background  
                    drawing.Clear(backColor);

                    Color textColor = ColorTranslator.FromHtml("#FFF");

                    //create a brush for the text  
                    Brush textBrush = new SolidBrush(textColor);

                    //drawing.DrawString(text, font, textBrush, 0, 0);  
                    drawing.DrawString(text, font, textBrush, new Rectangle(-2, 20, 200, 110));

                    drawing.Save();

                    textBrush.Dispose();
                    drawing.Dispose();

                    uniqueFileName = Guid.NewGuid().ToString() + "_" + testimonial.FullName + ".jpg";
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    img.Save(filePath);
                    //using (var fileStream = new FileStream(filePath, FileMode.Create))
                    //{
                    //    image.CopyTo(fileStream);
                    //}
                    testimonial.ImageURL = uniqueFileName;
                }

                _testimonialService.TInsert(testimonial);
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
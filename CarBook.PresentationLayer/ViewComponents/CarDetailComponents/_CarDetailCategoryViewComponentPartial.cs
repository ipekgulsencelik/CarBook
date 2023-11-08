using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailCategoryViewComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        CarBookContext _context;

        public _CarDetailCategoryViewComponentPartial(ICategoryService categoryService, CarBookContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _context.Cars.GroupBy(x => x.CategoryID).Select(c => new CategoryViewModel
            {
                CarCount = (int)c.Count(),
                CategoryName = _context.Categories.Where(x => x.CategoryID == c.Key).Select(x => x.CategoryName).FirstOrDefault(),

            }).ToList();

            List<CategoryViewModel> categoriesList = (from x in _categoryService.TGetListAll()
                                                      select new CategoryViewModel()
                                                      {
                                                          CategoryName = x.CategoryName,
                                                          CarCount = categories.Where(c => c.CategoryName == x.CategoryName).Select(n => n.CarCount).FirstOrDefault(),
                                                      }).ToList();
                                                      
            // var values = _categoryService.TGetListAll();
            return View(categoriesList);
        }
    }
}
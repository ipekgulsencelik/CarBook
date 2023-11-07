using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailCategoryViewComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _CarDetailCategoryViewComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetListAll();
            return View(values);
        }
    }
}
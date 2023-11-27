using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            var values = _brandService.TGetListAll();
            return View(values);
        }

        public IActionResult AddBrand()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddBrand(BrandDTO brandDTO)
        //{
        //    brandDTO.Status = true;
        //    _brandService.TInsert(_mapper.Map<Brand>(brandDTO));
        //    return RedirectToAction("Index", "Brand");
        //}

        public IActionResult DeleteBrand(int id)
        {
           // _brandService.TDelete(id);
            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public IActionResult UpdateBrand(int id)
        //{
        //    var brand = _brandService.TGetByID(id);
        //    var value = _mapper.Map<BrandDTO>(brand);
        //    return View(value);
        //}
        
        //[HttpPost]
        //public IActionResult UpdateBrand(BrandDTO brandDTO)
        //{
        //    brandDto.Status = true;
        //    _brandService.TUpdate(_mapper.Map<Brand>(brandDto));
        //    return RedirectToAction("Index");
        //}

        //public IActionResult GetBrandsSearchByName(string name)
        //{
        //    ViewData["CurrentFilter"] = name;

        //    var values = _brandService.TGetList();

        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        var lowerCaseName = name.ToLower();
        //        values = values.Where(x => x.BrandName.ToLower().Contains(lowerCaseName)).ToList();
        //    }
        //    return View(values);
        //}
    }

    public interface IMapper
    {
    }
}
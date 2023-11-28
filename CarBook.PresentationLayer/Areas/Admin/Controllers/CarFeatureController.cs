using AutoMapper;
using CarBook.BusinessLayer.Abstract;
using CarBook.BusinessLayer.ValidationRules.CarFeatureValidation;
using CarBook.BusinessLayer.ValidationRules.ServiceValidation;
using CarBook.DTOLayer.DTOs.CarFeatureDTOs;
using CarBook.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarBook.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class CarFeatureController : Controller
    {
        private readonly ICarFeatureService _carFeatureService;
        private readonly ICarService _carService;
        private readonly IMapper _mapper;

        public CarFeatureController(ICarFeatureService carFeatureService, ICarService carService, IMapper mapper)
        {
            _carFeatureService = carFeatureService;
           _carService = carService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var features = _carFeatureService.TGetListAll();
            var values = _mapper.Map<List<CarFeatureDTO>>(features);
            return View(values);
        }

        public IActionResult AddCarFeature()
        {
            ViewBag.cars = new List<SelectListItem>(from x in _carService.TGetAllCarsWithBrands()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Brand.BrandName + " " + x.Model,
                                                        Value = x.CarID.ToString()
                                                    }).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddCarFeature(CarFeatureDTO carFeatureDTO)
        {
            _carFeatureService.TInsert(_mapper.Map<CarFeature>(carFeatureDTO));
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCarFeature(int id)
        {
            var value = _carFeatureService.TGetByID(id);
            _carFeatureService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCarFeature(int id)
        {
            ViewBag.cars = new List<SelectListItem>(from x in _carService.TGetAllCarsWithBrands()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Brand.BrandName + " " + x.Model,
                                                        Value = x.CarID.ToString()
                                                    }).ToList();

            var feature = _carFeatureService.TGetByID(id);
            return View(feature);
        }

        [HttpPost]
        public IActionResult UpdateCarFeature(CarFeature carFeature)
        {
            _carFeatureService.TUpdate(carFeature);
            return RedirectToAction("Index");
        }
    }
}
using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.DefaultComponents
{
	public class _DefaultOfferViewComponentPartial : ViewComponent
	{
		private readonly ICarService _carService;

		public _DefaultOfferViewComponentPartial(ICarService carService)
		{
			_carService = carService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _carService.TGetLast5Cars();
			return View(values);
		}
	}
}
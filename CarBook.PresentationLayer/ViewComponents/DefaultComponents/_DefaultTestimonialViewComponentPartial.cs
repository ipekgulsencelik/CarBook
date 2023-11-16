using CarBook.BusinessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.DefaultComponents
{
	public class _DefaultTestimonialViewComponentPartial : ViewComponent
	{
		private readonly ITestimonialService _testimonialService;

		public _DefaultTestimonialViewComponentPartial(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		public IViewComponentResult Invoke()
		{
			var testimonials = _testimonialService.TGetListAll();
			return View(testimonials);
		}
	}
}
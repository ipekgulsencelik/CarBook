using CarBook.BusinessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.DefaultComponents
{
	public class _DefaultTestimonialViewComponentPartial : ViewComponent
	{
		private readonly IGenericService<Testimonial> _testimonialService;

		public _DefaultTestimonialViewComponentPartial(IGenericService<Testimonial> testimonialService)
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
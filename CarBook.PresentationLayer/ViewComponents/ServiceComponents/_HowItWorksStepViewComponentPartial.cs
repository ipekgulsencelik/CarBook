using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.ServiceComponents
{
    public class _HowItWorksStepViewComponentPartial : ViewComponent
    {
        private readonly IHowItWorksStepService _howItWorksStepService;

        public _HowItWorksStepViewComponentPartial(IHowItWorksStepService howItWorksStepService)
        {
            _howItWorksStepService = howItWorksStepService;
        }

        public IViewComponentResult Invoke() 
        {
            var values = _howItWorksStepService.TGetListAll();
            return View(values);
        }
    }
}

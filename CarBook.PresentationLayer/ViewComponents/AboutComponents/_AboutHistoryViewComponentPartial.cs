using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.AboutComponents
{
    public class _AboutHistoryViewComponentPartial : ViewComponent
    {
        private readonly IHistoryService _historyService;

        public _AboutHistoryViewComponentPartial(IHistoryService historyService)
        {
            _historyService = historyService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _historyService.TGetAbout();
            return View(value);
        }
    }
}
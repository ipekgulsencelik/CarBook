using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.ViewComponents.AboutComponents
{
    public class _AboutTeamViewComponentPartial : ViewComponent
    {
        private readonly ITeamService _teamService;

        public _AboutTeamViewComponentPartial(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _teamService.TGetActiveTeamList();
            return View(values);
        }
    }
}
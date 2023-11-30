using CarBook.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]")]
	public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TeamController(ITeamService teamService, IWebHostEnvironment webHostEnvironment)
        {
            _teamService = teamService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var values = _teamService.TGetListAll();
            return View();
        }

        public IActionResult CreateTeam()
        {
            return View();
        }

        public IActionResult UpdateTeam()
        {
            return View();
        }
    }
}

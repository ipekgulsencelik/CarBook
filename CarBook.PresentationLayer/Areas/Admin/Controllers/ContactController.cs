﻿using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]")]
	public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

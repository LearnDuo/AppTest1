using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AppTest1.Models.ViewModels;
using AppTest1.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppTest1.Controllers
{
    public class HomeController : Controller
    {
        private ITableRepository _tableRepository;

        public HomeController(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PlanLekcji()
        {
            var homeViewModel = new HomeViewModel();
            homeViewModel.Monday = _tableRepository.GetMonday();
            return View(homeViewModel);
        }
        [HttpPost]
        public IActionResult PlanLekcji([FromBody] string jeden, [FromBody] string dwa)
        {
            var homeViewModel = new HomeViewModel();
            homeViewModel.Monday = new List<string>() { new string(jeden), new string(dwa) };
            return View(homeViewModel);
        }
        [HttpGet]
        public IActionResult Galeria()
        {
            return View();
        }
    }
}

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
        public IActionResult PlanLekcji(string first, string second)
        {
            var list = new List<string>() { new string(first), new string(second) };
            return Json(list);
        }
        [HttpGet]
        public IActionResult Monday()
        {
            var monday = _tableRepository.GetMonday();
            return Json(monday);
        }
        [HttpGet]
        public IActionResult Galeria()
        {
            return View();
        }
        [HttpGet]
        public IActionResult HistoriaSzkoły()
        {
            return View();
        }
    }
}

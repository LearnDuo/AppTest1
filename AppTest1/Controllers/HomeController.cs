using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppTest1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PlanLekcji()
        {
            return View();
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

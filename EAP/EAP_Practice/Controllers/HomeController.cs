using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EAP_Practice.Models;

namespace EAP_Practice.Controllers
{
    public class HomeController : Controller
    {
        private IEmpRepository repository;

        public HomeController(IEmpRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(repository.Employees);

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using GitProjectOne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GitProjectOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        //Test changes for git suggstion
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //first changes from server side.
        public IActionResult Index()
        {
            return View();
        }
        //changes for merge tsetgit 
        public IActionResult Privacy()
        {
            return View();
        }
        //This change sfrom server new test branch
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

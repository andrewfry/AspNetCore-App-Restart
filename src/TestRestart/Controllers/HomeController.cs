using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestRestart.Controllers
{
    public class HomeController : Controller
    {
        private ITest _test;

        public HomeController(ITest test)
        {
            _test = test;
        }
        

        public IActionResult Restart()
        {
            var appManager = ApplicationManager.Load();
            appManager.Restart();

            return Content("restarted");
        }

        public IActionResult Hi()
        {
            return Content(_test.ID);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

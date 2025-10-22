using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using passing_model_data_from_controller_to_view.Models;

namespace passing_model_data_from_controller_to_view.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            employee emp = new employee();
            {
                emp.id = 100;
                emp.name="John Doe";
                emp.city="New York";
                emp.salary=7500000;
            };
            //ViewData["myemployee"] = emp;
            //ViewBag.myemployee =emp;
            TempData["myemployee"] = emp;


            return View();
        }

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

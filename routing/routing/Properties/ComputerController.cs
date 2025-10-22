using Microsoft.AspNetCore.Mvc;

namespace routing.Properties
{
    public class ComputerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

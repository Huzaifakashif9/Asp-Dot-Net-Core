using Microsoft.AspNetCore.Mvc;

namespace routing.Properties
{
    public class ElectronicsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

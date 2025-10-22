using Microsoft.AspNetCore.Mvc;

namespace routing.Properties
{
    public class TabletsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

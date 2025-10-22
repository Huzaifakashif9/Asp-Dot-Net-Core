using Microsoft.AspNetCore.Mvc;

namespace routing.Properties
{
    public class LaptopsController : Controller
    {
        public IActionResult macbook()
        {
            return View();
        }
        public IActionResult chromebook()
        {
            return View();
        }
        public IActionResult dell()
        {
            return View();
        }
        public IActionResult lenevo()
        {
            return View();
        }
        public IActionResult hp()
        {
            return View();
        }
    }
}

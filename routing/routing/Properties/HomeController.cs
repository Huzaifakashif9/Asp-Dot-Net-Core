using Microsoft.AspNetCore.Mvc;

namespace routing.Properties
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["data1"] = "huzaifa";
            ViewData["data2"] = 18;
            ViewData["data3"] = DateTime.Now.ToLongDateString();

            string[] fruits = { "apple", "mango", "pineapple", "cherry", "peach" };
            ViewData["fruitslist"] = fruits;

            ViewBag.data3 = "huzaifa";
            ViewBag.data3 = 18;
            ViewBag.data3 = DateTime.Now.ToShortDateString();
            string[] std = { "ali", "ahmed", "aliyan", "ahad", "shariq" };
            ViewBag.data4 = std;
            ViewBag.data5 = new List<string>()
            {
               "cricket","football","hockey"
            };
            TempData["data1"] = "huzaifa";
            TempData.Keep();

            return View();
        }
        public IActionResult about()
        {

            TempData.Keep();

            return View();
        }
        public IActionResult contact()
        {
            TempData.Keep();
            var listy = new List<Class> {
              new Class{
                  rollno=1,name="huzaifa",fname="kashif",number=0000
        } };
            ViewData["biography"] = listy;
            return View();
        }
    }
}

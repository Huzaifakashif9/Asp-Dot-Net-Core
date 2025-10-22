using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Repository_and_Models.Models;
using Repository_and_Models.Repository;

namespace Repository_and_Models.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository= null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository=new StudentRepository();
        }
        public List<StudentModel> getallstudents()

        {
            return _studentRepository.getallstudents();
        }
        public StudentModel getstudentbyid(int id)

        {
            return _studentRepository.getstudentbyid(id);
        }

        public IActionResult Index()
        {
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

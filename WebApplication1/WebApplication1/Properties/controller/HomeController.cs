using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace WebApplication1
{
    public class HomeController : Controller

    {
        //public string Index()
        //{
        //    return "index from controller";
        //}
        //public string about()
        //{
        //    return "about";
        //}
        //public int year()
        //{
        //    return 2025;
        //}
        [Route("Home/index")]
        [Route("~/")]
        public string Index()
        {
            return "index from controller";
        }
        [Route("Home/About")]
        public string About()
        {
            return "about from controller";
        }
        [Route("Home/details/{name}")]

        public string details(string name)
        {
            return "name";
        }

    }
}


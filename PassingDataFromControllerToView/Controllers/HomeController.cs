using Microsoft.AspNetCore.Mvc;

namespace PassingDataFromControllerToView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["data1"] = "hamza khan";
            //string[] arr = {"hamza","khan","Pathan"};
            //ViewData["data1"] = arr;

            //ViewData["data2"] = new List<string>()
            //{
            //    "Hamza", "khan", "Pathan",
            //    "Hamza", "khan", "Pathan",
            //    "Hamza", "khan", "Pathan"
            //};

            //ViewBag.data1 = "hamza khan";
            //ViewBag.data2 = new List<string>()
            //{
            //    "Hamza", "khan", "Pathan"
            //};

            //string[] arr = { "sanghar", "khattak", "kabli" };
            //ViewBag.data3 = arr;

            TempData["data1"] = "temp data";
            //temp data can be accessed across multiple views in this scenerio
            // it is accessible in about but it is accessed only once 
            // if it is accessed in index then it destroye and cannot be accessed in about then
            return View();
        }

        public IActionResult About()
        {
            return View();   
        }
    }
}

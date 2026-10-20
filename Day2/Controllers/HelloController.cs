using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Greeting()
        {
            return View();
        }
        public String Welcome(int id,String name)
        {
            return $"Xin chào {id} - {name} chúc bạn học tốt môn này hihihaha";
        }
        public IActionResult Welcome1(int numTimes,string name)
        {
            ViewBag.Id = numTimes;
            ViewData["name"] = name;
            return View();
        }
    }
}

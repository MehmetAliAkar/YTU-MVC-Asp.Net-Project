using Microsoft.AspNetCore.Mvc;
using W01.Models;

namespace W01.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            People people1 = new People()
            {
                age = 10,
                Id = 1,
                name = "Mehmet Ali AKAR"
            };
            return View(people1);
        }
    }
}

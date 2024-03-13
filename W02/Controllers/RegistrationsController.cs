using Microsoft.AspNetCore.Mvc;

namespace W02.Controllers
{
    public class RegistrationsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About(int id)
        {
            if (id == 1)
            {
                ViewBag.id = id;
                ViewBag.firstName = "Mali";
                ViewBag.lastName = "Akar";
                ViewBag.department = "Math Eng";
            }else if (id == 2)
            {
                ViewBag.id = id;
                ViewBag.firstName = "Okan";
                ViewBag.lastName = "Akar";
                ViewBag.department = "Turkish";
            }
            else
            {
                ViewBag.id = -1;
                ViewBag.firstName = "No data";
                ViewBag.lastName = "No data";
                ViewBag.department = "No data";
            }

            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(long id, string name, string lastName, string department)
        {
            return View();
        }



    }
}

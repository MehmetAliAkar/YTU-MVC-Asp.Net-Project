using Microsoft.AspNetCore.Mvc;
using W02.Models;

namespace W02.Controllers
{
    public class RegistrationsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(StudentsDbTable.OrderBy(p => p.Id).ToList());
        }
        
        public static List<Student> StudentsDbTable = new List<Student>()
        {

            new Student
            {
                Id = 1,
                FirstName = "Mali",
                LastName = "Akar",
                Department = "Math Eng",
            },

            new Student
            {
                Id = 2,
                FirstName = "Okan",
                LastName = "Akar",
                Department = "Turkish",
            },
        };

        [HttpGet]
        public IActionResult About(int id)
        {
            Student student = StudentsDbTable.FirstOrDefault(p => p.Id == id);

            return View(student);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            //save data to database
            StudentsDbTable.Add(student);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
	        Student student = StudentsDbTable.FirstOrDefault(p => p.Id == id);
			return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
			Student OldStudent = StudentsDbTable.FirstOrDefault(p => p.Id == student.Id);

			StudentsDbTable.Remove(OldStudent);

			StudentsDbTable.Add(student);

	        return RedirectToAction("Index");
        }

		[HttpGet]
        public IActionResult Delete(int id)
        {
	        Student student = StudentsDbTable.FirstOrDefault(p => p.Id == id);
	        StudentsDbTable.Remove(student);
			return RedirectToAction("Index");
		}



	}
}

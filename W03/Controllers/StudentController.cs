using Microsoft.AspNetCore.Mvc;
using W03.Models;

namespace W03.Controllers
{
	public class StudentController : Controller
	{
		public StudentController()
		{
			SchoolDB.InitialiazeDb(50);
		}

		public IActionResult Index()
		{
			var students = SchoolDB.Students.OrderBy(p=>p.Id).ToList();
			return View(students);
		}

		[HttpGet] 
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Student student)
		{
			var maxId = SchoolDB.Students.Max(p => p.Id) + 1;

			student.Id = maxId;

			if (ModelState.IsValid)
			{
				SchoolDB.Students.Add(student);
				return RedirectToAction("Index");
			}
			
			return View(student);
		}

		[HttpGet]
		public IActionResult Edit(int studentId)
		{
			var student = SchoolDB.Students.FirstOrDefault(p => p.Id == studentId);
			return View();
		}

		[HttpPost]
		public IActionResult Edit(Student student)
		{ 
			if (ModelState.IsValid)
			{
				var toBeRemove = SchoolDB.Students.FirstOrDefault(p=>p.Id == student.Id);

				SchoolDB.Students.Remove(toBeRemove);

				SchoolDB.Students.Add(student);
				return RedirectToAction("Index");
			}

			return View(student);
		}

		[HttpGet]
		public IActionResult Delete(int studentId)
		{
			var student = SchoolDB.Students.FirstOrDefault(p => p.Id == studentId);

			SchoolDB.Students.Remove(student);

			return RedirectToAction("Index");
		}
	}
}

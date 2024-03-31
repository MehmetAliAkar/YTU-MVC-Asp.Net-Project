using Microsoft.EntityFrameworkCore;
using ObsWebUI.Models.Entities;

namespace ObsWebUI.Models.EfDbContext
{
	public class YtuSchoolDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			optionsBuilder.UseSqlServer("server=.;database=YtuSchoolDb;trusted_connection=true;");
		}

		public List<Course>? Courses { get; set; }
		public List<Department>? Departments { get; set; }
		public List<Exam>? Exams { get; set; }
		public List<ExamResult>? ExamResults { get; set; }
		public List<Faculty>? Faculties { get; set; }
		public List<Instructor>? Instructors { get; set; }
		public List<InstructorCourse>? InstructorCourses { get; set; }
		public List<Student>? Students { get; set; }
		public List<StudentCourse>? StudentCourses { get; set; }
	}
}

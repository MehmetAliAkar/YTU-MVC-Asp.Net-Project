using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObsWebUI.Models.Entities
{
	public class StudentCourse
	{
		[Key]
        public int Id{ get; set; }
		[Required(ErrorMessage = "This is required!")]
		[ForeignKey("StudentId")]
		public int StudentId { get; set; }
		[Required(ErrorMessage = "This is required!")]
		[ForeignKey("CourseId")]
		public int CourseId { get; set; }
		[Required(ErrorMessage = "This is required!")]
		[Range(1999,2024)]
		public int Year { get; set; }
		[Required(ErrorMessage = "This is required!")]
		public string? Semester{ get; set; }
    }
}

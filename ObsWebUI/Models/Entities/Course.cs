using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObsWebUI.Models.Entities
{
	public class Course
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Course name is required!")]
		[ForeignKey("DepartmentId")]
		public int DepartmentId { get; set; }
		[Required(ErrorMessage = "Course name is required!")]
		public string? Name { get; set; }
		
	}
}

using System.ComponentModel.DataAnnotations;

namespace ObsWebUI.Models.Entities
{
    public class Faculty
    {
        [Key]
        public int Id{ get; set; }
        [Required(ErrorMessage ="This is required!")]
        public string? Name{ get; set; }
        [Required(ErrorMessage ="This is required!")]
        public string DeanName{ get; set; }
    }
}

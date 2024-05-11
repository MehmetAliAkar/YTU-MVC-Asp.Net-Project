﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObsWebUI.Models.Entities
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "This is required")]
        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
        [Required(ErrorMessage = "This is required")]
        public DateTime ExamDate { get; set; }

    }
}

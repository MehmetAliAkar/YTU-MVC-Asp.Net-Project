﻿using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObsWebUI.Models.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("DepartmentID")]
        [Required(ErrorMessage ="This is required!")]
        public int DepartmentId {  get; set; }
        [Required(ErrorMessage ="This is required!")]
        public string? Name { get; set; }
    }
}

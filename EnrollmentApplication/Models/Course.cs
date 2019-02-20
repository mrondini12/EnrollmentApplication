using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }

        [Required]
        [Display(Name = "Course Title")]
        [StringLength(150, ErrorMessage = "Title must be 150 Characters or less.")]
        public virtual string Title { get; set; }

        [Display(Name = "Description")]
        public virtual string Description { get; set; }

        [Required]
        [Display(Name = "Number of Credits")]
        [Range(1,4, ErrorMessage = "Credits must be between 1 and 4")]
        public virtual float Credits { get; set; }
    }
}
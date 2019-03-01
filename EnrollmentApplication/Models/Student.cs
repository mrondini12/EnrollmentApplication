using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace EnrollmentApplication.Models
{
    public class Student : IValidatableObject
    {
        [Display(Name = "Student ID")]
        public virtual int StudentId { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Last Name must be less then 50 characters.")]
        public virtual string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First Name must be less then 50 characters.")]
        public virtual string FirstName { get; set; }

        public virtual string Address1 { get; set; }

        public virtual string Address2 { get; set; }

        public virtual string City { get; set; }

        public virtual string Zipcode { get; set; }

        public virtual string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //a.Check if Address2 is the same as Address1.If so show an error “Address2 cannot be the same as Address1” on Address2 field.
            if (Address2 != null && Address2 == Address1)
            {
                yield return (new ValidationResult("Address 2 cannot be the same as Address 1"));
            }

            //b.Check if State is 2 digits long.Otherwise show an error message “Enter a 2 digit State code”. 
            if (State != null && State.Length != 2)
            {
                yield return (new ValidationResult("Enter a 2 Digit State Code"));
            }


            //c.Check if Zipcode is 5 digits long.Otherwise show an error message “Enter a 5 digit Zipcode”
            if (Zipcode != null && Zipcode.Length != 5)
            {
                yield return (new ValidationResult("Enter a 5 digit Zipcode"));
            }

            //throw new NotImplementedException();
        }
    }

}
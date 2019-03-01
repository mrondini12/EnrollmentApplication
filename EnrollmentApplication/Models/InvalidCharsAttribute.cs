using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
       readonly string invalidChars;
        

        public InvalidCharsAttribute(string invalidChars) :base("{0} contains unacceptable characters!")
        {
            this.invalidChars = invalidChars;

        }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                foreach (char c in invalidChars)
                {

                    if (Convert.ToString(value).Contains(c))
                    {
                        var errorMessage = FormatErrorMessage(validationContext.DisplayName);

                        return new ValidationResult(errorMessage);
                    }
                }
               
              
            }
            return ValidationResult.Success;
        }
    }
}
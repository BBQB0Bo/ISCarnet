using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBaseLibrary
{
    public class FutureDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime examDate = DateTime.Parse(value.ToString());
            DateTime today = DateTime.Today;
            if (today > examDate)
            {
                var result = new ValidationResult("The exam date must be in the future!");
                return result;
            }
            return null;

        }
    }
}

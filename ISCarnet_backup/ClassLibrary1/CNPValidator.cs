using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBaseLibrary
{
    public class CNPValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string cnp = value.ToString();
            if (cnp.Length != 13)
            {
                var result = new ValidationResult("CNP must have length 13!");
                return result;
            }
            if (!cnp.StartsWith("1") && !cnp.StartsWith("2") && !cnp.StartsWith("5") && !cnp.StartsWith("6"))
            {
                var result = new ValidationResult("Invalid CNP!");
                return result;
            }

            return null;

        }
    }
}

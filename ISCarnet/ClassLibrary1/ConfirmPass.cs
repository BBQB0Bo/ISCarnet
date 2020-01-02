using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DataBaseLibrary
{
    public class ConfirmPass : ValidationAttribute
    {
        private readonly string field;
        public ConfirmPass(string field)
        {
            this.field = field;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string confirmPass = value.ToString();
            if (confirmPass.Length < 6 || confirmPass.Length > 20)
            {
                var result = new ValidationResult(field + " length must be between 6 and 20");
                return result;
            }
            if (!confirmPass.Any(char.IsUpper) || !confirmPass.Any(char.IsLower) || !confirmPass.Any(char.IsDigit))
            {
                var result = new ValidationResult("The " + field + " must contain lowercase letters,uppercase letters and numbers!");
                return result;
            }

            return null;

        }
    }
}

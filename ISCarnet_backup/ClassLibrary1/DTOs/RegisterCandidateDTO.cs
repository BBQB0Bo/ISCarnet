using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBaseLibrary.DTOs
{
    public class RegisterCandidateDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [MinAge(18)]
        public DateTime BirthDate { get; set; }
        [Required]
        [CNPValidator()]
        public string CNP { get; set; }
        [Required]
        [ConfirmPass("Password")]
        public string Password { get; set; }
        [Required]
        [ConfirmPass("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}

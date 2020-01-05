using System;
using System.ComponentModel.DataAnnotations;

namespace Client.Shared.DTOs
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
        public string CNP { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
    }
}

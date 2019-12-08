using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseLibrary.DTOs
{
    public class RegisterCandidateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string CNP { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}

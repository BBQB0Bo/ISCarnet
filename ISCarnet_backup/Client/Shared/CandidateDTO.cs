using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Shared
{
    public class CandidateDTO
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string CNP { get; private set; }
    }
}

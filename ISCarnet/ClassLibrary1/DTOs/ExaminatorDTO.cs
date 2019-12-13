using DataBaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseLibrary.DTOs
{
    public class ExaminatorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float PassingPercentage { get; set; }

        public ExaminatorDTO() { }
        public ExaminatorDTO(Examinator e)
        {
            this.FirstName = e.FirstName;
            this.LastName = e.LastName;
            this.PassingPercentage = e.PassingPercentage;
        }
    }
}

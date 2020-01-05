using DataBaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBaseLibrary.DTOs
{
    public class MistakeDTO
    {
        [Required]
        public string MistakeType { get; set; }
        [Range(1, 21, ErrorMessage = "Invalid score(1-21)")]
        public int Score { get; set; }

        public MistakeDTO()
        {

        }
        public MistakeDTO(Mistake m)
        {
            this.MistakeType = m.MistakeType;
            this.Score = m.Score;
        }
    }
}

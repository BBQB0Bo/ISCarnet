using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Client.Shared
{
    public class AddExamDTO
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string examinator { get; set; }
        [Required]
        public DateTime ExamDate { get; set; }

    }
}

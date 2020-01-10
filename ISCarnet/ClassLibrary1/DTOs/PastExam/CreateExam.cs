using DataBaseLibrary.Models;
using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace DataBaseLibrary.DTOs.PastExam
{
    public class CreateExam : IRequest<ExamDTO>
    {
        [FutureDate]
        public DateTime ExamDate { get; set; }
        [Required]
        public String usernameCandidate { get; set; }
        [Required]
        public String ExaminatorName { get; set; }

        [Required]

        public String LocationName { get; set; }

        public CreateExam() { }
        public CreateExam(string ExaminatorName)
        {
            this.ExaminatorName = ExaminatorName;
        }

    }
}

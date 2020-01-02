using DataBaseLibrary.Models;
using MediatR;
using System;


namespace DataBaseLibrary.DTOs.PastExam
{
    public class CreateExam : IRequest<ExamDTO>
    {
        public DateTime ExamDate { get; set; }
        public String usernameCandidate { get; set; }

        public String ExaminatorName { get; set; }

    }
}

using MediatR;
using System;

namespace DataBaseLibrary.DTOs.PastExam
{
    public class DeleteExam : IRequest

    {
        public DateTime ExamDate { get; set; }
        public Candidate Candidate { get; set; }
    }
}

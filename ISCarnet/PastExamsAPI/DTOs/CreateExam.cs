using DataBaseLibrary;
using MediatR;
using System;


namespace PastExamsAPI.DTOs
{
    public class CreateExam : IRequest <Exam>
    {
        public DateTime ExamDate { get; set; }
        public int Score { get;  set; }
        public Candidate Candidate { get; set; }
    }
}

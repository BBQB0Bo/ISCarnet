using DataBaseLibrary;
using MediatR;
using System;


namespace DataBaseLibrary.DTOs.PastExam
{
    public class CreateExam : IRequest <ExamDTO>
    {
        public DateTime ExamDate { get; set; }
        public int Score { get;  set; }
        public Candidate Candidate { get; set; }
    }
}

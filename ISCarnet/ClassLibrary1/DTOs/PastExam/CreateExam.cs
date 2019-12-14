using DataBaseLibrary.Models;
using MediatR;
using System;


namespace DataBaseLibrary.DTOs.PastExam
{
    public class CreateExam : IRequest<ExamDTO>
    {
        public DateTime ExamDate { get; private set; }
        public int Score { get;private set; }
        public Candidate candidate { get; private set; }

        public Examinator Examinator { get; private set; }

    }
}

using DataBaseLibrary.Models;
using MediatR;
using System;

namespace DataBaseLibrary.DTOs.PastExam
{
    public class UpdateExam : IRequest <ExamDTO>
    {
        public Guid ExamId { get; set; }
        public DateTime ExamDate { get;  set; }
        public int Score { get;  set; }
        public Candidate Candidate { get; set; }
        public Examinator Examinator { get;  set; }

    }
}

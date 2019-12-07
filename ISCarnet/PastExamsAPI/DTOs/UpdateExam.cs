using DataBaseLibrary;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastExamsAPI.DTOs
{
    public class UpdateExam : IRequest <Exam>
    {
        public Guid ExamId { get; set; }
        public DateTime ExamDate { get;  set; }
        public int Score { get;  set; }
        public Candidate Candidate { get; set; }

    }
}

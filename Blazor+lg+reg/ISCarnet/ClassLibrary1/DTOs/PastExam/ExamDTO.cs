using MediatR;
using System;

namespace DataBaseLibrary.DTOs.PastExam
{
    public class ExamDTO : IRequest<ExamDTO>
    {
        public DateTime ExamDate { get; private set; }
        public int Score { get; private set; }
        public string Result { get; private set; }

        public ExamDTO(Exam e)
        {
            this.ExamDate = e.ExamDate;
            this.Score = e.Score;
            this.Result = e.Result;
        }
    }
}

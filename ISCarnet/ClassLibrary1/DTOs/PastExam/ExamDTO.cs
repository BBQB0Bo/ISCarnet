using DataBaseLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;

namespace DataBaseLibrary.DTOs.PastExam
{
    public class ExamDTO : IRequest<ExamDTO>
    {
        public DateTime ExamDate { get; private set; }
        public int Score { get; private set; }
        public string Result { get; private set; }
        public Examinator Examinator { get; private set; }
        public List<Mistake> Mistakes { get; private set; }

        public ExamDTO(Exam e)
        {
            this.ExamDate = e.ExamDate;
            this.Score = e.Score;
            this.Result = e.Result;
            this.Examinator = e.Examinator;
            this.Mistakes = e.Mistakes;
        }
        public ExamDTO(DateTime examDate,int score, string result)
        {
            this.ExamDate = examDate;
            this.Score = score;
            this.Result = result;
        }
    }
}

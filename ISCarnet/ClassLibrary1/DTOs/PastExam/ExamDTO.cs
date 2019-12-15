using DataBaseLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;

namespace DataBaseLibrary.DTOs.PastExam
{
    public class ExamDTO : IRequest<ExamDTO>
    {
	public string Driver { get; set; }
        public DateTime ExamDate { get; set; }
        public int Score { get; set; }
        public string Result { get; set; }
        public Examinator Examinator { get; set; }
        public List<Mistake> Mistakes { get; set; }
	
	  public ExamDTO()
        {
        }

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

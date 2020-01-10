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
        public string Examinator { get; set; }
        public LocationDTO Location { get; set; }
        public List<MistakeDTO> Mistakes { get; set; }

        public ExamDTO()
        {
            this.Mistakes = new List<MistakeDTO>();
        }

        public ExamDTO(Exam e)
        {
            this.Driver = e.Candidate.LastName + " " + e.Candidate.FirstName;
            this.ExamDate = e.ExamDate;
            this.Score = e.Score;
            this.Result = e.Result;
            this.Examinator = e.Examinator.LastName + " " + e.Examinator.FirstName;
            this.Location = new LocationDTO(e.Location);
            this.Mistakes = new List<MistakeDTO>();
            foreach (Mistake m in e.Mistakes)
                this.Mistakes.Add(new MistakeDTO(m));
        }
        public ExamDTO(DateTime examDate, int score, string result)
        {
            this.ExamDate = examDate;
            this.Score = score;
            this.Result = result;
        }
    }
}

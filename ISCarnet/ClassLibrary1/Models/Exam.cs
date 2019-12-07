using System;

namespace DataBaseLibrary
{
    public class Exam
    {
        public Guid ExamId { get; private set; }
        public DateTime ExamDate { get; private set; }
        public int Score { get; private set; }
        public string Result { get; private set; }
        public Candidate Candidate { get; private set; }
        private Exam() { }

        public static Exam Create(DateTime examdate, int score, Candidate candidate)
        {
            Exam e = new Exam();
            e.ExamId = Guid.NewGuid();
            e.ExamDate = examdate;
            e.Score = score;
            e.Result = score < 21 ? "Passed" : "Failed";
            //e.Candidate = candidate;
          //  candidate.AttachExam(e);
            return e;
        }

        public void Update(DateTime examdate, int score, Candidate candidate)
        {
            ExamDate = examdate;
            Score = score;
            Result = score < 21 ? "Passed" : "Failed";
            //delete the exam from old candidate in case it's changing
         //   if(this.Candidate!=null)
          //  this.Candidate.RemoveExam(this);
           // Candidate = candidate;
           // candidate.AttachExam(this);
        }
    }
}

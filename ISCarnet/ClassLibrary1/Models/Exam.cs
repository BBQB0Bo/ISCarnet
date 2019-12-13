using DataBaseLibrary.Models;
using System;
using System.Collections.Generic;

namespace DataBaseLibrary
{
    public class Exam
    {
        public Guid ExamId { get; private set; }
        public DateTime ExamDate { get; private set; }
        public int Score { get; private set; }
        public string Result { get; private set; }
        public Candidate Candidate { get; private set; }

        public Examinator Examinator { get; private set; }

        public List<Mistake> Mistakes { get; private set; }
        private Exam() { }

        public static Exam Create(DateTime examdate, int score, Candidate candidate, Examinator examinator)
        {
            Exam e = new Exam();
            e.ExamId = Guid.NewGuid();
            e.ExamDate = examdate;
            e.Score = score;
            e.Result = score < 21 ? "Passed" : "Failed";
            e.Candidate = candidate;
            e.Examinator = examinator;
            candidate.AttachExam(e);
            examinator.AttachExam(e);
            return e;
        }

        public static Exam CreateFutureExam(DateTime examdate, Candidate candidate, Examinator examinator)
        {
            Exam e = new Exam();
            e.ExamId = Guid.NewGuid();
            e.ExamDate = examdate;
            e.Score = 0;
            e.Result = "Incoming";
            e.Candidate = candidate;
            e.Examinator = examinator;
            candidate.AttachExam(e);
            examinator.AttachExam(e);
            return e;
        }

        public void Update()
        {
            this.Score = 0;
            foreach (Mistake m in Mistakes)
            {
                this.Score += m.Score;
            }
            if (this.Score <= 21)
                this.Result = "Passed";
            else
                this.Result = "Failed";

        }

        public void AbsentCandidate()
        {
            this.Score = -1;
            this.Result = "AbsentCandidate";
        }
        public void AttachMistake(Mistake m)
        {
            this.Mistakes.Add(m);
        }
    }
}

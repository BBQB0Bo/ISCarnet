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
        public virtual Candidate Candidate { get; private set; }

        public virtual Examinator Examinator { get; private set; }

        public virtual Location Location { get; private set; }

        public virtual List<Mistake> Mistakes { get; private set; }
        public Exam()
        {
            this.Mistakes = new List<Mistake>();
        }

        public static Exam Create(DateTime examdate, int score, Candidate candidate, Examinator examinator, Location location)
        {
            Exam e = new Exam();
            e.ExamId = Guid.NewGuid();
            e.ExamDate = examdate;
            e.Score = score;
            e.Result = score < 21 ? "Passed" : "Failed";
            e.Candidate = candidate;
            e.Examinator = examinator;
            e.Location = location;
            candidate.AttachExam(e);
            examinator.AttachExam(e);
            location.AttachExam(e);
            return e;
        }

        public static Exam CreateFutureExam(DateTime examdate, Candidate candidate, Examinator examinator, Location location)
        {
            Exam e = new Exam();
            e.ExamId = Guid.NewGuid();
            e.ExamDate = examdate;
            e.Score = 0;
            e.Result = "Incoming";
            e.Candidate = candidate;
            e.Examinator = examinator;
            e.Location = location;
            candidate.AttachExam(e);
            examinator.AttachExam(e);
            location.AttachExam(e);
            return e;
        }

        public void DeleteMistakes()
        {
            this.Score = 0;
            this.Mistakes.Clear();
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
            this.Examinator.updatePercentage();

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

        public void UpdateExam(DateTime examdate, Candidate candidate, Examinator examinator)
        {
            if (examdate != null)
                this.ExamDate = examdate;
            if (candidate != null)
                this.Candidate = candidate;
            if (examinator != null)
                this.Examinator = examinator;

        }
    }
}

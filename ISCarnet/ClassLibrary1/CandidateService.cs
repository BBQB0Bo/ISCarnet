using System;
using System.Linq;

namespace DataBaseLibrary
{
    public class CandidateService
    {
        private CandidateContext context = new CandidateContext();

        public void RegisterCandidate(string firstname, string lastname, DateTime birthdate, string cnp,
            string accountpassword)
        {
            Candidate c = Candidate.Create(firstname, lastname, birthdate, cnp, accountpassword);
            context.Candidates.Add(c);
            context.Accounts.Add(c.UserAccount);
            context.SaveChanges();
        }

        public Candidate FindCandidate(string cnp)
        {
            return context.Candidates.FirstOrDefault(c => c.CNP == cnp);
        }

        public void AddExam(DateTime examdate, int score, Candidate candidate)
        {
            Exam e = Exam.Create(examdate, score, candidate);
            context.Exams.Add(e);
            context.SaveChanges();
        }
    }
}

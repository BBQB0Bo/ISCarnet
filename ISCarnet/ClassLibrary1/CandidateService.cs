using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseLibrary
{
    public class CandidateService : ICandidateService
    {
        private readonly CandidateContext context;

        public CandidateService(CandidateContext context)
        {
            this.context = context;
        }

        // private CandidateContext context;

        public Guid RegisterCandidate(string firstname, string lastname, DateTime birthdate, string cnp,
            string accountpassword)
        {
            Candidate c = Candidate.Create(firstname, lastname, birthdate, cnp, accountpassword);
            context.Candidates.Add(c);
            context.Accounts.Add(c.UserAccount);
            context.SaveChanges();
            return c.CandidateId;
        }

        public Candidate FindCandidateByCNP(string cnp)
        {
            return context.Candidates.FirstOrDefault(c => c.CNP == cnp);
        }

        public Candidate FindCandidateById(Guid id)
        {
            return context.Candidates.FirstOrDefault(c => c.CandidateId == id);
        }


        public bool DeleteCandidateAndAccount(Guid id)
        {
            Candidate candidate = this.FindCandidateById(id);
            if (candidate == null)
            {
                return false;
            }

            context.Candidates.Remove(candidate);
            context.Accounts.Remove(candidate.UserAccount);
            context.SaveChangesAsync();
            return true;
        }

        public List<Account> GetAccounts()
           {
            List<Account> accounts =  context.Accounts.ToList();

            if (accounts == null)
            {
                return null;
             }

            return  accounts;
        }

        public bool UpdateCandidate(Candidate candidate)
        {
            context.Entry(candidate).State = EntityState.Modified;

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (FindCandidateById(candidate.CandidateId ) == null)
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
            return true;
        }

        public void AddExam(DateTime examdate, int score, Candidate candidate)
        {
            Exam e = Exam.Create(examdate, score, candidate);
            context.Exams.Add(e);
            context.SaveChanges();
        }
    }
}

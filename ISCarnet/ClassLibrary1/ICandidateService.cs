using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataBaseLibrary
{
    public interface ICandidateService
    {
        Guid RegisterCandidate(string firstname, string lastname, DateTime birthdate, string cnp,string accountpassword);

        public Candidate FindCandidateByCNP(string cnp);

        public Candidate FindCandidateById(Guid id);

        public bool DeleteCandidateAndAccount(Guid id);

        public List<Account> GetAccounts();

        public bool UpdateCandidate(Candidate candidate);

        void AddExam(DateTime examdate, int score, Candidate candidate);
    }
}
using System;

namespace DataBaseLibrary
{
    public interface ICandidateService
    {
        void RegisterCandidate(string firstname, string lastname, DateTime birthdate, string cnp,
            string accountpassword);

        Candidate FindCandidate(string cnp);
        void AddExam(DateTime examdate, int score, Candidate candidate);
    }
}
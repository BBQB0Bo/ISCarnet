﻿using System;
using System.Collections.Generic;

namespace DataBaseLibrary
{
    public class Candidate
    {
        public Guid CandidateId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string CNP { get; private set; }

        public Account UserAccount { get; private set; }

        public List<Exam> PastExams { get; private set; }
        public static Candidate Create(string firstname, string lastname, DateTime birthdate, string cnp,
            string accountpassword, int usernamenumber)
        {
            Candidate candidate = new Candidate
            {
                CandidateId = Guid.NewGuid(),
                FirstName = firstname,
                LastName = lastname,
                BirthDate = birthdate,
                CNP = cnp,
                PastExams = new List<Exam>()
            };
            candidate.UserAccount = Account.Create(candidate, accountpassword, usernamenumber);
            return candidate;
        }

        public void AttachExam(Exam e)
        {
            PastExams = new List<Exam>();
            this.PastExams.Add(e);
        }
        public void RemoveExam(Exam e)
        {
            PastExams.Remove(e);
        }

    }
}

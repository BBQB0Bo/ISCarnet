using System;

namespace DataBaseLibrary
{
    public class Account
    {
        public Guid AccountId { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public Guid CandidateForeignKey { get; private set; }
        public Candidate AccountOwner { get; private set; }
        private Account() { }
        public static Account Create(Candidate candidate, string password, int usernamenumber)
        {
            Account account = new Account
            {
                AccountId = Guid.NewGuid(),
                UserName = candidate.LastName + candidate.FirstName[0] + usernamenumber,
                Password = password,
                AccountOwner = candidate,
                CandidateForeignKey = candidate.CandidateId
            };
            return account;
        }
        public void SetUserName(String name)
        {
            if (name != null)
                UserName = name;
        }

    }
}

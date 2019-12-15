using DataBaseLibrary.DTOs;
using DataBaseLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseLibrary
{
    public class CandidateService : ICandidateService
    {
        public readonly CandidateContext context;

        public CandidateService(CandidateContext context)
        {
            this.context = context;
        }

        public CandidateService()
        {
            this.context = new CandidateContext();
        }

        // private CandidateContext context;

        public AccountDTO RegisterCandidate(RegisterCandidateDTO dto)
        {
            int accountnumber = context.Candidates.Where(c => c.LastName == dto.LastName).ToList().Count();
            Candidate c = Candidate.Create(dto.FirstName, dto.LastName, dto.BirthDate, dto.CNP, dto.Password, accountnumber);
            context.Candidates.Add(c);
            context.Accounts.Add(c.UserAccount);
            context.SaveChanges();
            AccountDTO accDTO = new AccountDTO();
            accDTO.UserName = c.UserAccount.UserName;
            accDTO.Password = c.UserAccount.Password;
            return accDTO;
        }
        public ExaminatorDTO RegisterExaminator(ExaminatorDTO dto)
        {
            Examinator examinator = Examinator.Create(dto.FirstName, dto.LastName);
            context.Examinators.Add(examinator);
            context.SaveChanges();
            dto = new ExaminatorDTO(examinator);
            return dto;
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
            List<Account> accounts = context.Accounts.ToList();

            if (accounts == null)
            {
                return null;
            }

            return accounts;
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
                if (FindCandidateById(candidate.CandidateId) == null)
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

        public void AddExam(DateTime examdate, int score, Candidate candidate, Examinator examinator)
        {
            Exam e = Exam.Create(examdate, score, candidate, examinator);
            context.Exams.Add(e);
            context.SaveChanges();
        }

        public void AddFutureExam(DateTime examdate, string candidateUserName, string examinatorName)
        {
            var c = context.Candidates.FirstOrDefault(c => c.UserAccount.UserName == candidateUserName);
            var ex = context.Examinators.FirstOrDefault(ex => ex.FirstName + " " + ex.LastName == examinatorName);
            Exam e = Exam.CreateFutureExam(examdate, c, ex);
            context.Exams.Add(e);
            context.SaveChanges();
        }

        public Account GetAccountByUserName(string username)
        {
            var account = context.Accounts.FirstOrDefault(a => a.UserName == username);
            return account;
        }

        public Account GetAccountByCredentials(string username, string password)
        {
            var account = context.Accounts.FirstOrDefault(a => a.UserName == username && a.Password == password);
            return account;
        }

        public List<ExaminatorDTO> GetExaminatorDTOs()
        {
            List<ExaminatorDTO> dtos = new List<ExaminatorDTO>();
            foreach (Examinator examinator in context.Examinators.ToList())
            {
                dtos.Add(new ExaminatorDTO(examinator));
            }
            return dtos;
        }

        public ExaminatorDTO GetExaminatorByName(string fullName)
        {
            Examinator ex = context.Examinators.FirstOrDefault(e => e.FirstName + e.LastName == fullName);
            ExaminatorDTO dto = new ExaminatorDTO(ex);
            return dto;
        }
    }
}

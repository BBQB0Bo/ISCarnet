﻿using DataBaseLibrary.DTOs;
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



        public Candidate FindCandidateByCNP(string cnp)
        {
            return context.Candidates.FirstOrDefault(c => c.CNP == cnp);
        }

        public Candidate FindCandidateById(Guid id)
        {
            return context.Candidates.FirstOrDefault(c => c.CandidateId == id);
        }
        public bool CNPAlreadyExists(string cnp)
        {
            var candidate = context.Candidates.FirstOrDefault(c => c.CNP == cnp);
            if (candidate == null)
                return false;
            else
                return true;
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

        public void AddExam(DateTime examdate, int score, Candidate candidate, Examinator examinator, Location location)
        {
            Exam e = Exam.Create(examdate, score, candidate, examinator, location);
            context.Exams.Add(e);
            context.SaveChanges();
        }

        public void AddFutureExam(DateTime examdate, string candidateUserName, string examinatorName, string locationName)
        {
            var c = context.Candidates.FirstOrDefault(c => c.UserAccount.UserName == candidateUserName);
            var ex = context.Examinators.FirstOrDefault(ex => ex.FirstName + " " + ex.LastName == examinatorName);
            var l = context.Locations.FirstOrDefault(l => l.LocationName == locationName);
            Exam e = Exam.CreateFutureExam(examdate, c, ex, l);
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


    }
}

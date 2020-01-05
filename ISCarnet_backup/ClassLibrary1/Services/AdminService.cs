using DataBaseLibrary.DTOs;
using DataBaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBaseLibrary.Services
{
    public class AdminService : IAdminService
    {
        public readonly AdminContext context;

        public AdminService(AdminContext context)
        {
            this.context = context;
        }

        public AdminService()
        {
            this.context = new AdminContext();
        }

        public List<AccountDTO> GetAccounts()
        {
            List<AccountDTO> accountDTOs = new List<AccountDTO>();
            List<AdminAccount> accounts = context.AdminAccounts.ToList();
            foreach (AdminAccount acc in accounts)
            {
                AccountDTO dto = new AccountDTO
                {
                    UserName = acc.UserName,
                    Password = acc.Password
                };
                accountDTOs.Add(dto);
            }
            return accountDTOs;
        }
        public AdminAccount GetAccountByCredentials(string username, string password)
        {
            var account = context.AdminAccounts.FirstOrDefault(a => a.UserName == username && a.Password == password);
            return account;
        }

        public AdminAccount RegisterAdmin(AccountDTO dto)
        {
            AdminAccount account = AdminAccount.Create(dto.UserName, dto.Password);
            context.AdminAccounts.Add(account);
            context.SaveChanges();
            return account;
        }

        public AdminAccount GetAccountByUsername(string username)
        {
            var account = context.AdminAccounts.FirstOrDefault(a => a.UserName == username);
            return account;
        }
    }
}

using DataBaseLibrary.DTOs;
using DataBaseLibrary.Models;
using System.Collections.Generic;

namespace DataBaseLibrary.Services
{
    public interface IAdminService
    {
        List<AccountDTO> GetAccounts();
        AdminAccount GetAccountByCredentials(string username, string password);
        public AdminAccount RegisterAdmin(AccountDTO dto);
        public AdminAccount GetAccountByUsername(string username);
    }
}
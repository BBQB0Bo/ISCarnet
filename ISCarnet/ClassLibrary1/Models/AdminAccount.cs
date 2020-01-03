using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBaseLibrary.Models
{
    public class AdminAccount
    {
        [Key]
        public Guid AccountId { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        private AdminAccount() { }
        public static AdminAccount Create(string UserName, string Password)
        {
            AdminAccount account = new AdminAccount();
            account.AccountId = Guid.NewGuid();
            account.UserName = UserName;
            account.Password = Password;
            return account;
        }
    }
}

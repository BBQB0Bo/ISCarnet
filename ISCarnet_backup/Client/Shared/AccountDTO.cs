using System.ComponentModel.DataAnnotations;

namespace Client.Shared
{
    public class AccountDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

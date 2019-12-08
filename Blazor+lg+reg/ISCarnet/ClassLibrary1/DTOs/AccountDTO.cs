using System.ComponentModel.DataAnnotations;

namespace DataBaseLibrary.DTOs
{
    public class AccountDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

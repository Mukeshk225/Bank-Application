using System.ComponentModel.DataAnnotations;

namespace BankService.ResourceModel
{
    public class UserModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
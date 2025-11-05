using BusinessLayer.DTOs.Account;
using System.ComponentModel.DataAnnotations;

namespace EcomercePresentationLayer.ActionRequest
{
    public class RegisterUserActionRequest
    {
        [Required]
        [MaxLength(250)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
     
    
    }

    public static class RegisterAccountExtensions
    {
        public static RegisterDto ToDto(this RegisterUserActionRequest newAccount)
            => new RegisterDto
            {
                UserName = newAccount.UserName,
                Email = newAccount.Email,
                Password = newAccount.Password,
                ConfirmPassword = newAccount.ConfirmPassword,
            };
    }
}

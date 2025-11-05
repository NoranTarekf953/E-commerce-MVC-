using BusinessLayer.DTOs.Account;
using System.ComponentModel.DataAnnotations;

namespace EcomercePresentationLayer.ActionRequest
{
    public class LoginUserActionRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public static class UserExtensions
    {
        public static LogInDto ToDto(this LoginUserActionRequest request)
            => new LogInDto
            {
                Username = request.UserName,
                Email = request.Email,
                Password = request.Password,
                
            };
    }
}

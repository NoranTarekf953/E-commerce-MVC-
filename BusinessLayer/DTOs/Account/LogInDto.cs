using DataAccessLayer.Entities.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs.Account
{
    public class LogInDto
    {
        [Required(ErrorMessage = "Please enter UserName")]

        public string Username { get; set; } = string.Empty;
        [Required(ErrorMessage ="Please enter Email")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage ="Please enter Password")]
        public string Password { get; set; } = string.Empty;




    }
    public static class LoginUserDtoExtension
    {
        public static ApplicationUser ToEntity(this LogInDto dto)
            => new ApplicationUser
            {
                UserName = dto.Username,
                Email = dto.Email,
                //PasswordHash = dto.Password
            };
    }

}

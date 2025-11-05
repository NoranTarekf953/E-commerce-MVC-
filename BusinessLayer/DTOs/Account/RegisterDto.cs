using DataAccessLayer.Entities.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs.Account
{
    public class RegisterDto
    {
        [Required(ErrorMessage ="Please Enter User name")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { set; get; } = string.Empty;
        [Required(ErrorMessage ="please Enter Password")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "please Enter Confirm Password")]

        public string ConfirmPassword {  get; set; } = string.Empty;
    }

    public static class RegisterUserDtoExtension
    {
        public static ApplicationUser ToEntity(this RegisterDto dto)
            => new ApplicationUser
            {
                UserName = dto.UserName,
                Email = dto.Email,
                
                
                //PasswordHash = dto.Password,
            };
    }
}

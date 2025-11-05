using BusinessLayer.DTOs.Account;
using DataAccessLayer.Entities.Account;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface IUserService
    {
        Task<bool> CheckPassword(ApplicationUser user, string Password);


        Task<ApplicationUser?> FindUserByUserName(string UserName);


        Task<IdentityResult> RegisterUser(RegisterDto User);


        Task Signin(LogInDto user, bool IsCookiePersistant);


        Task SignOut();
        
    }
}

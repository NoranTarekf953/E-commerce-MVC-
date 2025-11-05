using BusinessLayer.Contracts;
using BusinessLayer.DTOs.Account;
using DataAccessLayer.Entities.Account;
using Microsoft.AspNetCore.Identity;


namespace BusinessLayer.Managers
{
    public class UserService:IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public UserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> CheckPassword (ApplicationUser user, string Password)
        {
            var isPasswordValid = await _userManager.CheckPasswordAsync (user, Password);
            return isPasswordValid;
        }
        
        public async Task<ApplicationUser?> FindUserByUserName(string UserName)
        {
            return await _userManager.FindByNameAsync (UserName);
        }

        public async Task<IdentityResult> RegisterUser(RegisterDto User)
        {
            var userEntity = User.ToEntity ();
            IdentityResult result = await _userManager.CreateAsync(
                userEntity,
                User.Password
                );
            if (result.Succeeded) { 
                if(!await _userManager.IsInRoleAsync(userEntity, "Customer"))
                {
                    await _userManager.AddToRoleAsync(userEntity, "Customer");
                }
            }
            return result;
        }

        public async Task Signin (LogInDto user, bool IsCookiePersistant)
        {
            //var userEntity = await _userManager.FindByEmailAsync(user.Email);
            //var result =
            //if(userEntity != null)
                await _signInManager.PasswordSignInAsync(
                user.Username,
                user.Password,
                IsCookiePersistant,
                lockoutOnFailure: false

                );
           
            //await _signInManager.SignInAsync(userEntity, IsCookiePersistant);
            //return result.Succeeded;
        }

        public async Task SignOut()
        {
            await _signInManager.SignOutAsync();
        }

    }
}

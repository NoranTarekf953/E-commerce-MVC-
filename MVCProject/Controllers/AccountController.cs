using BusinessLayer.Contracts;
using BusinessLayer.DTOs.Account;
using BusinessLayer.Managers;
using DataAccessLayer.Entities;
using EcomercePresentationLayer.ActionRequest;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace PresentationLayer.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult Login([FromQuery] string? ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginUserActionRequest request, string? ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.FindUserByUserName(request.UserName);
                if (user != null)
                {
                    var isPasswordValid = await _userService.CheckPassword(user, request.Password);
                    if (isPasswordValid)
                    {
                        await _userService.Signin(request.ToDto(), request.RememberMe);

                        return RedirectToAction("ShowAllProducts", "Product");
                        


                    }
                }
                // The User doesnot exist ❌
                ModelState.AddModelError("Invalid Credentials", "Invalid UserName or Password");

            }
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserActionRequest request)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await _userService.RegisterUser(request.ToDto());
                if (result.Succeeded)
                {
                    var loginUserDto = new LogInDto
                    {
                        Username = request.UserName,
                        Email = request.Email,
                        Password = request.Password,

                    };
                    await _userService.Signin(loginUserDto, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            }
            return View(request);
            }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _userService.SignOut();

            return RedirectToAction("Index", "Home");
        }
    }
}

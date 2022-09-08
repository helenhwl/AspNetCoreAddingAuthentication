﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WishList.Models;
using WishList.Models.AccountViewModels;

namespace WishList.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IActionResult Index()
        {
            return View();
        }

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInUser)
        {
            _userManager = userManager;
            _signInManager = signInUser;
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult HttpGetRegister()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult HttpPostRegister(RegisterViewModel register)
        {
            return View();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using WishList.Models;

namespace WishList.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInUser)
        {
            _userManager = userManager;
            _signInManager = signInUser; 
        }
    }
}

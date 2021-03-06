using HoliDayRental.Handlers;
using HoliDayRental.Infrastructure.Helpers;
using HoliDayRental.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace HoliDayRental.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IHttpContextAccessor _httpContext;
        private readonly RegisterManager register;

        public AccountController(ILogger<AccountController> logger, IHttpContextAccessor httpContext)
        {
            _logger = logger;
            _httpContext = httpContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            if (register.IsConnected) return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterForm form)
        {
            //ValidateLoginForm
            if (!ModelState.IsValid) return View();
            register.SetUser(form);
            return RedirectToAction("Index", "Home");
        }


        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public IActionResult PartiallyLogOut()
        {
            //HttpContext.Session.Remove("user");
            register.ForgetUser();
            return RedirectToAction("Login");
        }
    }
}

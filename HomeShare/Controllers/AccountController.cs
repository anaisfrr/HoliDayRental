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

        public AccountController(ILogger<AccountController> logger, IHttpContextAccessor httpContext)
        {
            _logger = logger;
            _httpContext = httpContext;
        }
        public IActionResult Index()
        {
            return View(service.Get().Select(s => s.ToListItem()));
        }

        public IActionResult Register()
        {
            if (logger.IsConnected) return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterForm form)
        {
            //ValidateLoginForm(form, ModelState);
            if (!ModelState.IsValid) return View();
            logger.SetUser(form);
            return RedirectToAction("Index", "Home");
        }

        //Exemple d'ajout de valeur pour une session permettant de spécifier que l'utilisateur est connecté
        //[HttpPost]
        //public IActionResult Register()
        //{
        //    _httpContext.HttpContext.Session.SetObjectAsJson("IsLogged", true);
        //    return View();
        //}
    }
}

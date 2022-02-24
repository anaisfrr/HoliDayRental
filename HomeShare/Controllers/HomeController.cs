using HoliDayRental.Handlers;
using HoliDayRental.Infrastructure.Helpers;
using HoliDayRental.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContext;
        private readonly RegisterManager register;
        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContext )
        {
            _logger = logger; 
            _httpContext=httpContext;
        }

        public IActionResult Index()
        {
            _httpContext.HttpContext.Session.SetObjectAsJson("Titre", "Welcome");
            return View();
        }        

    }
}

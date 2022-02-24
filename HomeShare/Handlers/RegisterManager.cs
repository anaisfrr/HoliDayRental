using HoliDayRental.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Handlers
{
    public class RegisterManager
    {
        private readonly ISession _register;
        public RegisterManager(IHttpContextAccessor httpContextAccessor)
        {
            _register = httpContextAccessor.HttpContext.Session;
        }

        public bool IsConnected { get { return _register.GetString("user") != null; } }

        public int? ValeurInt
        {
            get
            {
                return _register.GetInt32(nameof(ValeurInt));
            }
            set
            {
                _register.SetInt32(nameof(ValeurInt), value.Value);
            }
        }

        public string ValeurText
        {
            get
            {
                return _register.GetString(nameof(ValeurText));
            }
            set
            {
                _register.SetString(nameof(ValeurText), value);
            }
        }


        public void SetUser(RegisterForm form)
        {
            _register.SetString("user", form.Email);
        }
        public void ForgetUser()
        {
            _register.Remove("user");
        }
    }
}

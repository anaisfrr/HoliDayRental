using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Handlers
{
    public class RegisterManager
    {
        private readonly IRegister _register;
        public RegisterManager(IHttpContextAccessor httpContextAccessor)
        {
            _register = httpContextAccessor.HttpContext.Register;
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
        public byte[] MonTableauDeByte
        {
            get
            {
                return _register.Get(nameof(MonTableauDeByte));
            }
            set
            {
                _register.Set(nameof(MonTableauDeByte), value);
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

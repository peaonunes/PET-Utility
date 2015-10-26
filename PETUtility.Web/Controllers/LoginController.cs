using PETUtility.Data.Fundamentals.Filters;
using PETUtility.Data.Fundamentals.Localizations;
using PETUtility.Data.Fundamentals.Models;
using PETUtility.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;

namespace PETUtility.Web.Controllers
{
    public class LoginController : Controller
    {
        IPETianoService _PETianoService;

        public LoginController(IPETianoService petianoService)
        {
            this._PETianoService = petianoService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(PETiano user)
        {
            if (_IsValid(user.Login, user.Password))
            {
                FormsAuthentication.SetAuthCookie(user.Login, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData[Localization.Global.Error.LoginFail] = Localization.Global.Error.LoginFail;
                return View(user);
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        private bool _IsValid(string login, string password)
        {
            PETianoFilter petianoFilter = new PETianoFilter()
            {
                Login = login
            };

            PETiano user = _PETianoService.GetPETiano(petianoFilter);

            if (user != null && Crypto.VerifyHashedPassword(user.Password, password))
                return true;
            else
                return false;
        }
    }
}
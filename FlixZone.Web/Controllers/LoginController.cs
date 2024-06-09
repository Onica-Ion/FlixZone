using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlixZone.Web.Models;
using System.Web.Security;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using FlixZone.Domain.Entities.User;
using FlixZone.BusinessLogic.DBContext;
using FlixZone.BusinessLogic.Interface;
using FlixZone.BusinessLogic;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;

namespace FlixZone.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;

        public LoginController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ULogin _userLogin)
        {
            if (ModelState.IsValid) 
            {
                ULoginData data = new ULoginData
                {
                    Credential = _userLogin.Credential,
                    Password = _userLogin.Password,
                    LoginIp = Request.UserHostAddress,
                    LoginDateTime = DateTime.Now
                };

                var userLogin = _session.UserLogin(data);
                if (userLogin.Status) 
                {
                    HttpCookie cookie = _session.GenCookie(_userLogin.Credential);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                    Session["Username"] = data.Credential;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userLogin.StatusMsg);
                    return View();
                }
            }

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
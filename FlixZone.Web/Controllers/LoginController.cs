using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlixZone.BusinessLogic;
using FlixZone.BusinessLogic.Interfaces;
using FlixZone.Domain.Entities.User;
using FlixZone.Domain.Entities.User.Responses;
using FlixZone.Web.Models.User;

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

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                ULoginData data = new ULoginData
                {
                    Credential = login.Credential,
                    Password = login.Password,
                    LoginIp = Request.UserHostAddress,
                    LoginDateTime = DateTime.Now
                };

                ULoginResp userResp = _session.UserLoginAcion(data);
                ViewBag.LogSuccess = userResp.Status;

                if (userResp.Status)
                {
                    //ADD COOKIE

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userResp.StatusMsg);
                    return View();
                }
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
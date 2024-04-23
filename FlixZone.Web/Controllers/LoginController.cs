using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlixZone.BusinessLogic.Interface;
using FlixZone.BusinessLogic;
using FlixZone.Domain.Entities.User;
using AutoMapper;
using FlixZone.Web.Models;

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
        /*public ActionResult Index()
        {
            return View();
        }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserLogin data)
        {
            /*if (ModelState.IsValid)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<UserLogin, ULoginData>());
                var data = Mapper.Map<ULoginData>(login);

                data.LoginIp = Request.UserHostAddress;
                data.LoginDateTime = DateTime.Now;

                var userLogin = _session.UserLogin(data);
                if (userLogin.Status)
                {
                    HttpCookie cookie = _session.GenCookie(login.Credential);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userLogin.StatusMsg);
                    return View();
                }
            }*/

            if (ModelState.IsValid)
            {
                ULoginData uData = new ULoginData
                {
                    Credential = data.Credential,
                    Password = data.Password,
                    LoginIp = Request.UserHostAddress,
                    LoginDateTime = DateTime.Now
                };

                ULoginResp resp = _session.UserLogin(uData);
                ViewBag.LogSuccess = resp.Status;
                if (resp.Status)
                {
                    //ADD COOKIE
                    //coogie
                    HttpCookie cookie = _session.GenCookie(uData.Credential);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", resp.StatusMsg);
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
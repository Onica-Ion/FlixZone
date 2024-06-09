using FlixZone.BusinessLogic.Interface;
using FlixZone.BusinessLogic;
using FlixZone.Domain.Entities.Responce;
using FlixZone.Domain.Entities.User;
using FlixZone.Domain.Entities.User.Register;
using FlixZone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlixZone.Web.Controllers
{
    public class Sign_upController : Controller
    {
        private readonly ISession _session;

        public Sign_upController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(URegister _userRegister )
        {
            if (ModelState.IsValid)
            {

                URegisterData uData = new URegisterData
                {
                    Email = _userRegister.Credential,
                    Password = _userRegister.Password,
                    Username = _userRegister.Username,
                    LastLogin = DateTime.Now
                };

                ULoginResp loginResp = _session.UserRegister(uData);

                if (loginResp.Status)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", loginResp.StatusMsg);
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
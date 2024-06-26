﻿using FlixZone.BusinessLogic.DBContext;
using FlixZone.Domain.Entities.Anime;
using FlixZone.Domain.Entities.Responce;
using FlixZone.Domain.Entities.User;
using FlixZone.Domain.Entities.User.DBModel;
using FlixZone.Domain.Entities.User.Register;
using FlixZone.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;

namespace FlixZone.BusinessLogic.Core
{
    public class UserApi
    {
        internal ULoginResp UserRegisterAction(URegisterData data)
        {
            UserLogin user;
            var validate = new EmailAddressAttribute();
            if (validate.IsValid(data.Email))
            {
                //var pass = LoginHelper.HashGen(data.Password);
                using (var db = new UserContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Email == data.Email);
                }
                if (user != null)
                {
                    return new ULoginResp { Status = false, StatusMsg = "This user already exists" };
                }
                var newUser = new UserLogin()
                {
                    Email = data.Email,
                    Username = data.Username,
                    Password = data.Password,
                    LastLogin = data.LastLogin,
                    Level = URole.User,

                };

                using (var todo = new UserContext())
                {
                    /*user.Email = data.Email;
                    user.Username = data.Username;
                    user.Password = data.Password;
                    user.LastLogin = data.LastLogin;
                    user.Level = URole.User;*/
                    todo.Users.Add(newUser);
                    todo.SaveChanges();
                }
                return new ULoginResp { Status = true };

            }
            else
            {
                return new ULoginResp { Status = false, StatusMsg = "Email is not valid" };
            }
        }
        internal List<UserLogin> GetUsersFromDb()
        {
            var user = new List<UserLogin>();
            using (var db = new UserContext())
            {
                user = db.Users
                    .ToList();
            }
            return user;
        }
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            UserLogin status;
            var validate = new EmailAddressAttribute();
            if (validate.IsValid(data.Credential))
            {
                var pass = LoginHelper.HashGen(data.Password);
                using (var _userContext = new UserContext())
                {
                    status = _userContext.Users.Where(u => u.Email == data.Credential && u.Password == data.Password).FirstOrDefault();
                }

                if (status == null)
                {
                    return new ULoginResp { Status = false, StatusMsg = "The Username or Password is Incorrect" };
                }

                using (var todo = new UserContext())
                {
                    status.LasIp = data.LoginIp;
                    status.LastLogin = data.LoginDateTime;
                    todo.Entry(status).State = EntityState.Modified;
                    todo.SaveChanges();
                }

                return new ULoginResp { Status = true };
            }
            else
            {
                var pass = LoginHelper.HashGen(data.Password);
                using (var db = new UserContext())
                {
                    status = db.Users.FirstOrDefault(u => u.Username == data.Credential && u.Password == data.Password);
                }

                if (status == null)
                {
                    return new ULoginResp { Status = false, StatusMsg = "The Username or Password is Incorrect" };
                }

                using (var todo = new UserContext())
                {
                    status.LasIp = data.LoginIp;
                    status.LastLogin = data.LoginDateTime;
                    todo.Entry(status).State = EntityState.Modified;
                    todo.SaveChanges();
                }

                return new ULoginResp { Status = true };
            }
        }

        internal HttpCookie Cookie(string loginCredential)
        {
            var apiCookie = new HttpCookie("X-KEY")
            {
                Value = CookieGenerator.Create(loginCredential)
            };

            using (var db = new SessionContext())
            {
                Session curent;
                var validate = new EmailAddressAttribute();
                if (validate.IsValid(loginCredential))
                {
                    curent = (from e in db.Sessions where e.Username == loginCredential select e).FirstOrDefault();
                }
                else
                {
                    curent = (from e in db.Sessions where e.Username == loginCredential select e).FirstOrDefault();
                }

                if (curent != null)
                {
                    curent.CookieString = apiCookie.Value;
                    curent.ExpireTime = DateTime.Now.AddMinutes(60);
                    using (var todo = new SessionContext())
                    {
                        todo.Entry(curent).State = EntityState.Modified;
                        todo.SaveChanges();
                    }
                }
                else
                {
                    db.Sessions.Add(new Session
                    {
                        Username = loginCredential,
                        CookieString = apiCookie.Value,
                        ExpireTime = DateTime.Now.AddMinutes(60)
                    });
                    db.SaveChanges();
                }
            }

            return apiCookie;
        }

        internal UserMinimal UserCookie(string cookie)
        {
            Session session;
            UserLogin curentUser;

            using (var db = new SessionContext())
            {
                session = db.Sessions.FirstOrDefault(s => s.CookieString == cookie && s.ExpireTime > DateTime.Now);
            }

            if (session == null) return null;
            using (var db = new UserContext())
            {
                var validate = new EmailAddressAttribute();
                if (validate.IsValid(session.Username))
                {
                    curentUser = db.Users.FirstOrDefault(u => u.Email == session.Username);
                }
                else
                {
                    curentUser = db.Users.FirstOrDefault(u => u.Username == session.Username);
                }
            }

            if (curentUser == null) return null;

            UserMinimal userminimal = new UserMinimal
            {
                Id = curentUser.Id,
                Username = curentUser.Username,
                Email = curentUser.Email,
                LastLogin = curentUser.LastLogin,
                LasIp = curentUser.LasIp,
                Level = curentUser.Level
            };

            return userminimal;
        }
    }
}

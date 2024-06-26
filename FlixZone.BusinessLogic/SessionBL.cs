﻿using FlixZone.BusinessLogic.Core;
using FlixZone.BusinessLogic.Interface;
using FlixZone.Domain.Entities.Responce;
using FlixZone.Domain.Entities.User;
using FlixZone.Domain.Entities.User.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FlixZone.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }
        public HttpCookie GenCookie(string loginCredential)
        {
            return Cookie(loginCredential);
        }

        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }

        public List<UserLogin> GetUsers()
        {
            return GetUsersFromDb();
        }

        public ULoginResp UserRegister(URegisterData data)
        {
            return UserRegisterAction(data);
        }
    }
}

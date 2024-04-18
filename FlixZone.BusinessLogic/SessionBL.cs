using FlixZone.BusinessLogic.Core;
using FlixZone.BusinessLogic.Interfaces;
using FlixZone.Domain.Entities.User;
using FlixZone.Domain.Entities.User.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.BusinessLogic
{
    public class SessionBL : UserApi , ISession
    {
        public ULoginResp UserLoginAction(ULoginData _login)
        {
            return base.UserLoginAction(_login);
        }
    }
}

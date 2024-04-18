using FlixZone.Domain.Entities.User.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ULoginResp UserLoginAcion(ULoginResp data);
    }
}

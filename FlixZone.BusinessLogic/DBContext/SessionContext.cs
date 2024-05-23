using FlixZone.Domain.Entities.User.DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.BusinessLogic.DBContext
{
    public class SessionContext : DbContext
    {
        public SessionContext() : base("name=flixZone")
        {
        }

        public virtual DbSet<Session> Sessions { get; set; }
    }
}

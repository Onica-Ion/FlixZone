using FlixZone.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.BusinessLogic.DBContext
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("name=flixZone")
        {
            Database.SetInitializer<UserContext>(null);
        }

        public virtual DbSet<UserLogin> Users { get; set; }
    }
}

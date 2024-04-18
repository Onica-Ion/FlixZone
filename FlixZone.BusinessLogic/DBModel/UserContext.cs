using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlixZone.Domain.Entities.User;


namespace FlixZone.BusinessLogic.DBModel
{
    class UserContext : DbContext
    {
        public UserContext() :
            base("name=FlixZone")
        {
        }
        public virtual DbSet<UDbTable> Users {  get; set; }
    }
}

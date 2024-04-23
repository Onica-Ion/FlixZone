﻿using FlixZone.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.BusinessLogic.DBModel
{
    public class MainContext : DbContext
    {
        public MainContext() : base("name=flixZone")
        {   
        }

        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<UDbTable> Users { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlixZone.Web.Models
{
    public class URegister
    {
        public string Credential { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
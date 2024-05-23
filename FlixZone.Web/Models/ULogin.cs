using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FlixZone.Web.Models
{
    public class ULogin
    {
        public string Credential { get; set; }
        public string Password { get; set; }
    }
}
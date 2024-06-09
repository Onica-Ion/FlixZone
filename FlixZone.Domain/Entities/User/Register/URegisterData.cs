using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixZone.Domain.Entities.User.Register
{
    public class URegisterData
    {
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public URole Level { get; set; }
        public DateTime LastLogin { get; set; }
    }
}

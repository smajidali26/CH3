using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3.Core.Domain
{
    public partial class UserLogin : BaseEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string PasswordHash { get; set; }

        public bool Active { get; set; }

    }
}

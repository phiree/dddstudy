using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDB.Domain.IdentityAccess.Models
{
    public class Identity
    {
        public string Id { get; protected set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDB.Application.IdentityAccess.Memberships
{
   public  interface IMembershipService
    {
        MembershipDto Register(MembershipDto membership);
        
    }
}

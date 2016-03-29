using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YDB.Domain.Model.IdentityAccess;
using FluentNHibernate.Mapping;
 

namespace YDB.InfrastructureLayer.NHibernateImpl.Mapping
{
   public  class MembershipMap:EntityMap<Membership>
    {
        public MembershipMap()
        {
            Map(x => x.UserName);
            Map(x => x.Password);
        }
    }
}

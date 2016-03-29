using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDB.Domain.Model.IdentityAccess
{
    public class Membership : Common.Domain.IDomainEntity
    {
        public virtual string Id
        {
            get;protected set;

          
        }
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Membership Create(string username, string password)
        {
            Membership m = new Membership { Id=Guid.NewGuid().ToString(), UserName=username,Password=password};
            return m;
        }
        public virtual string UserName { get; protected set; }
        public virtual string Password { get; protected set; }
       
    }
}

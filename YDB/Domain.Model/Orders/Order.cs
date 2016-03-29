using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDB.Domain.Model.Orders
{
    public class Order:Common.Domain.IDomainEntity
    {
        public virtual string Id
        {
            get;set;
        }

        public   static Order Create()
        {
            return new Order { Id = Guid.NewGuid().ToString() };
        }

        

    }
}

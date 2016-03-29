using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YDB.Domain.Model.Orders;
using FluentNHibernate.Mapping;
 

namespace YDB.InfrastructureLayer.NHibernateImpl.Mapping
{
   public  class OrderMap:EntityMap<Order>
    {
        public OrderMap()
        {
           
        }
    }
}

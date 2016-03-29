using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YDB.Domain.Model.IdentityAccess;
using YDB.Domain.Model.Orders;
namespace YDB.InfrastructureLayer
{
  public  class OrderRepository
    {
        Common.Repository.IRepository<Order > repository;

        public OrderRepository(Common.Repository.IRepository<Order> repository)
        {
            this.repository = repository;
        }
        public void Add(Order order)
        {
            this.repository.Add(order);
        }
    }
}

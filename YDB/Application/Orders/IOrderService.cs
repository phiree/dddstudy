using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDB.Application.Orders
{
    public interface IOrderService
    {
        void Create(YDB.Domain.Model.Orders.Order order);
    }
}

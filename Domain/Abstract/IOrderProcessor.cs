using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uh365898_db.Domain.Entities;

namespace uh365898_db.Domain.Abstract
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, Shipping shipping, Order order);
    }
}

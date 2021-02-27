using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {

        public List<OrderDetailsDto> GetOrderDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from o in context.Orders
                             join c in context.Customers on o.CustomerId equals c.CustomerId
                             select new OrderDetailsDto
                             {
                                 OrderId = o.OrderId,
                                 ContactName = c.ContactName,
                                 OrderDate = o.OrderDate,
                                 ShipCity = o.ShipCity

                             };
                return result.ToList();
            }
        }
    }
}

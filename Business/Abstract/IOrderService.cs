using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IResult Add(Order order);
        IDataResult<Order> GetById(int orderId);
        IDataResult<List<OrderDetailsDto>> GetOrderDetails();
    }
}

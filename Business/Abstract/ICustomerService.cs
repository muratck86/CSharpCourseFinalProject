using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IResult Add(Customer customer);
        IDataResult<Customer> GetById(string customerId);
        IResult Update(Customer customer);
        IResult Remove(string customerId);
    }
}

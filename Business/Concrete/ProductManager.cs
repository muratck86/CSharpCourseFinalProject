using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal inMemoryProductDal)
        {
            _productDal = inMemoryProductDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}

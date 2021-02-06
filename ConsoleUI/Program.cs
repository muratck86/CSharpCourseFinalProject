using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            ProductDetailsTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GetByUnitPrice(30, 100))
            {
                Console.WriteLine("{0}\t{1}\t{2}", product.ProductName, product.CategoryId, product.UnitPrice);
            }
        }

        private static void ProductDetailsTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine("{0}-------{1}-------{2}", product.ProductId, product.ProductName, product.CategoryName);
            }
        }
    }
}

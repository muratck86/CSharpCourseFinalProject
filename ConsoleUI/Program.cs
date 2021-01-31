using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());


            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }


            InMemoryProductDal dene = new InMemoryProductDal();
            ProductManager pm1 = new ProductManager(dene);
            dene.Update(new Entities.Concrete.Product() { ProductId = 1, ProductName = "Tabak", CategoryId = 8 });

            Console.WriteLine();
            foreach (var product in pm1.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}

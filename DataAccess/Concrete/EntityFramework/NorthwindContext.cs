using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: to link relations in db to classes of our code.
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@ means don't use \ of escape characters
            //In a normal program, We write server url/ip addresss instead of (localdb)\mssqllocaldb
            //Trusted_Connection = true, don't write passwords, usernames here...
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; database = Northwind; Trusted_Connection = true");
        }
        //Connect our classes to the relations (tables) of the database
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}

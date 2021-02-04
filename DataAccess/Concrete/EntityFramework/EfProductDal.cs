using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //ORM: Object Relational Mapping
    //NuGet: install packages of C#
    public class EfProductDal : IProductDal
    {
        public void Add(Product t)
        {
            //using: this using is not the same as at the top of the file.
            //This is a C# special structure, to tell garbage collector to
            //immediately collect after it is done with it...
            //IDisposable pattern implementation of C#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(t); //get the reference of t, as addedEntry.
                addedEntity.State = EntityState.Added; //Tell what to do with this addedEntry...
                context.SaveChanges(); //Do the job. (add the product t to the database.)
            }
        }

        public void Delete(Product t)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(t); //get the reference of t, as deletedEntry.
                deletedEntity.State = EntityState.Deleted; //Tell what to do with this deletedEntry...
                context.SaveChanges(); //Do the job. (add the product t to the database.)
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Product>().ToList() //Without filter (means get all)
                    : context.Set<Product>().Where(filter).ToList(); //Use filter
            }
        }

        public void Update(Product t)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(t);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

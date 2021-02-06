using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()
        where TContext: DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //using: this using is not the same as at the top of the file.
            //This is a C# special structure, to tell garbage collector to
            //immediately collect after it is done with it...
            //IDisposable pattern implementation of C#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //get the reference of t, as addedEntry.
                addedEntity.State = EntityState.Added; //Tell what to do with this addedEntry...
                context.SaveChanges(); //Do the job. (add the product t to the database.)
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //get the reference of t, as deletedEntry.
                deletedEntity.State = EntityState.Deleted; //Tell what to do with this deletedEntry...
                context.SaveChanges(); //Do the job. (add the product t to the database.)
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList() //Without filter (means get all)
                    : context.Set<TEntity>().Where(filter).ToList(); //Use filter
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

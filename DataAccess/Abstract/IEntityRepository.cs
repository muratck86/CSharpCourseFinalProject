using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    public interface IEntityRepository<T> where T : class, IEntity, new() //it is like <? extends IEntity> in java
    {
        //Predicate
        //Delegate
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);
        void Add(T t);
        void Update(T t);
        void Delete(T t);
    }
}

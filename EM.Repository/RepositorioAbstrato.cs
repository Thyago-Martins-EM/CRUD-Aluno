using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EM.Domain;

namespace EM.Repository
{

    public abstract class RepositorioAbstrato<T> where T : IEntidade
    {
        public virtual void Add(T objeto)
        {
    
        }

        public virtual void Remove(T objeto)
        {
        }

        public virtual void Update(T objeto)
        {
            
        }

        public virtual IEnumerable<T> GetAll()
        {
            return GetAll();
        }

        public virtual IEnumerable<T> Get(Expression<Func<T, bool> > predicate)
        {   
            return Get(predicate);
        }
        
    }
}

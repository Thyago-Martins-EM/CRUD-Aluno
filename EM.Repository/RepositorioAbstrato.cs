using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EM.Domain;

namespace EM.Repository
{
    public abstract class RepositorioAbstrato<T> where T : IEntidade
    {
        public void Add(T objeto)
        {

        }
        public void Remove(T objeto)
        {

        }
        public void Update(T objeto)
        {

        }
        
    }
}

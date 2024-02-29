using Quiz.DataAccess.Database;
using Quiz.DomainModel.Models;
using Quiz.DomainModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.DataAccess
{
    public class GenericAbstract<T> : IRepositoryBase<T> where T : EntityBase
    {
        ContextoDB ctx;
        public GenericAbstract(ContextoDB contextoDB) 
        {
            ctx = contextoDB;
        }

        public void Excluir(T entity)
        {
            ctx.Set<T>().Remove(entity);
        }

        public T ObterPorID(int id)
        {
            return ctx.Set<T>().FirstOrDefault(x => x.ID == id)!;
        }

        public IList<T> ObterTodos()
        {
            return ctx.Set<T>().ToList();
        }

        public void Salvar(T entity)
        {
            if(entity.ID.Equals(0))
                ctx.Set<T>().Add(entity);
        }
    }
}

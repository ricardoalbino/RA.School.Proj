using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RA.School.Proj.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity :  class
    {
        Task adicionar(TEntity  entity);
        Task Atualizar(TEntity entity);
        Task Remover(TEntity entity);
        Task<List<TEntity>> ObterTodos();
        Task<TEntity> ObterPorId(Guid id);
        Task<IEnumerable<TEntity>> buscar(Expression<Func<TEntity, bool>> predicate);

    }
}

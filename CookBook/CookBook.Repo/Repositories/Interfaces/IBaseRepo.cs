using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Repo.Repositories.Interfaces
{
    public interface IBaseRepo<TEntity, TId>
    {
        void Create(TEntity entity);

        Task<TEntity> GetById(TId id, Func<IQueryable<TEntity>, IQueryable<TEntity>>? queryFunction = null);

        Task<List<TEntity>> GetAll(Func<IQueryable<TEntity>, IQueryable<TEntity>>? queryFunction = null);

        void Update(TEntity entity);

        void Delete(TEntity entity);


    }
}

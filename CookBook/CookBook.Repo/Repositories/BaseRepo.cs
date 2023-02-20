using CookBook.Models.Entities;
using CookBook.Models.Entities.Interface;
using CookBook.Repo.Repositories.Interfaces;
using CookBook.Shared.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Repo.Repositories
{
    public class BaseRepo<TEntity,TId, TName, TDbContext> : IBaseRepo<TEntity, TId>
        where TEntity : notnull, BaseEntity<TId ,TName>
        where TDbContext :notnull, DbContext
        where TId : notnull
    {
        protected DbSet<TEntity> _entityDbSet;

        public BaseRepo(TDbContext context)
        {
            _entityDbSet = context.Set<TEntity>();
        }
        //creating a new listing 
        public void Create(TEntity entity)
        {

            //add the created date
            if (ImplementsInterface<IDated>())
                ((IDated)entity).Created = DateTime.UtcNow;

            // perform the add in memory
            _entityDbSet.Add(entity);
        }
        // get a single existing listing by Id 

        public async Task<TEntity> GetById(TId id, Func<IQueryable<TEntity>, IQueryable<TEntity>>? queryFunction = null)
        {
            // get the entity 
            TEntity? result;
            if (queryFunction == null)
                result = await _entityDbSet.FirstOrDefaultAsync(item => item.Id.Equals(id));
            else
                result = await queryFunction(_entityDbSet).FirstOrDefaultAsync(item => item.Id.Equals(id));

            if (result == null)
                throw new NotFoundException("The requested item could not be found");

            // return the retrieved entity
            return result;
        }


        public async Task<List<TEntity>> GetAll(Func<IQueryable<TEntity>, IQueryable<TEntity>>? queryFunction = null)
        {
            List<TEntity> results;
            if (queryFunction == null)
                results = await _entityDbSet.ToListAsync();
            else
                results = await queryFunction(_entityDbSet).ToListAsync();

            // return the retrieved entities
            return results;
        }

        // Update the existing entity 
        public void Update(TEntity entity)
        {
            // Update the entity(entity passed in has changes already applied)
            _entityDbSet.Update(entity);
        }

        // Delete the Entity

        public void Delete(TEntity entity)
        {
            // deleting the entity 
            _entityDbSet.Remove(entity);
        }


        protected bool ImplementsInterface<TInterface>()
        {
            return (typeof(TEntity).GetInterfaces().Contains(typeof(TInterface)));
        }
    }
}

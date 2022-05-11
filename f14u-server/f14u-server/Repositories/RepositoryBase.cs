using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace f14u_server.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public IMongoCollection<T> Collection { get; set; }

        public RepositoryBase(IMongoCollection<T> collection)
        {
            Collection = collection;
        }

        public IQueryable<T> GetAll()
        {
            return Collection.AsQueryable();
        }

        public async Task InsertOneAsync(T entity)
        {
            await Collection.InsertOneAsync(entity);
        }

        public async Task InsertManyAsync(IEnumerable<T> entities)
        {
            await Collection.InsertManyAsync(entities);
        }

        public async Task UpdateOneAsync(string filter, string editableEntityJson)
        {
            await Collection.UpdateOneAsync(filter, editableEntityJson);
        }

        public async Task ReplaceOneAsync(string filter, T replaceableEntity)
        {
            await Collection.ReplaceOneAsync(filter, replaceableEntity);
        }

        public async Task DeleteManyAsync(string filter)
        {
            await Collection.DeleteManyAsync(filter);
        }
        public async Task ReplaceOneAsync(Expression<Func<T, bool>> filter, T replaceableEntity)
        {
            await Collection.ReplaceOneAsync(filter, replaceableEntity);
        }
        public async Task DeleteManyAsync(Expression<Func<T, bool>> filter)
        {
            await Collection.DeleteManyAsync(filter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace f14u_server.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        public IQueryable<T> GetAll();
        public Task InsertOneAsync(T entity);
        public Task InsertManyAsync(IEnumerable<T> entities);
        public Task UpdateOneAsync(string filter, string editableEntityJson);
        public Task ReplaceOneAsync(string filter, T replaceableEntity);
        public Task DeleteManyAsync(string filter);
        public Task ReplaceOneAsync(Expression<Func<T, bool>> filter, T replaceableEntity);
        public Task DeleteManyAsync(Expression<Func<T, bool>> filter);
    }
}

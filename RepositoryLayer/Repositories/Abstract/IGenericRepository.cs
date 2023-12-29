using System.Linq.Expressions;
using CoreLayer.BaseEntities;

namespace RepositoryLayer.Repositories.Abstract;

public interface IGenericRepository<T> where T :class, IBaseEntity
{
    Task AddEntityAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    IQueryable<T> GetAllList();
    IQueryable<T> Where(Expression<Func<T,bool>> predicate);
    Task<T> GetById(int id);


}
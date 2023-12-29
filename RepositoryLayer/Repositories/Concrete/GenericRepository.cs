using System.Linq.Expressions;
using CoreLayer.BaseEntities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using RepositoryLayer.Repositories.Abstract;

namespace RepositoryLayer.Repositories.Concrete;

public class GenericRepository<T>: IGenericRepository<T> where T : class , IBaseEntity,new()
{
    private readonly AppDbContext _context;
    private DbSet<T> _dbSet;
    public GenericRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task AddEntityAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        

    }

    public void Delete(T entity)
    {
        _dbSet.Update(entity);
    }

    public IQueryable<T> GetAllList()
    {
        return _dbSet.AsNoTracking().AsQueryable();
    }

    public async  Task<T> GetById(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public void Update(T entity)
    {
        _dbSet.Remove(entity);
    }
    public IQueryable<T>Where(Expression<Func<T,bool>>predicate)
    {
        return _dbSet.Where(predicate);
    }

   
}
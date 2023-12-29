using RepositoryLayer.Context;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.Repositories.Concrete;
using RepositoryLayer.UnitOfWork.Abstract;

namespace RepositoryLayer.UnitOfWork.Concrete;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }

    IGenericRepository<T> IUnitOfWork.GetGenericRepository<T>()
    {
        return new GenericRepository<T>(_context);
    }

    public ValueTask DisposeAsync()
    {
        return _context.DisposeAsync();
    }
}
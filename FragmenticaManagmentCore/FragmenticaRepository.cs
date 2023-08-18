using FragmenticaManagmentCore;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1;

public class FragmenticaRepository : IRepository<FragmenticaContext>
{
    private readonly DbContext _dbContext;
    public FragmenticaRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IQueryable<FragmenticaContext> GetAll()
    {
        return _dbContext.Set<FragmenticaContext>();
    }

    public IQueryable<FragmenticaContext> GetAllAsNoTracking()
    {
        return _dbContext.Set<FragmenticaContext>().AsNoTracking();
    }

    public void Add(FragmenticaContext entity)
    {
        _dbContext.Set<FragmenticaContext>().Add(entity);
    }

    public void Delete(FragmenticaContext entity)
    {
        _dbContext.Set<FragmenticaContext>().Remove(entity);
    }

    public void Save()
    {
        _dbContext.SaveChanges();
    }

    public async Task SaveAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
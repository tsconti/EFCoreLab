using Microsoft.EntityFrameworkCore;

namespace EFCoreLab.GenericRepository;

public class RepositoryBase<T> : IDbRepository<T> where T : class
{
    protected DbSet<T> DbSet;
    protected DbContext DbContext;

    public RepositoryBase(DataContext dbContext)
    {
        DbContext = dbContext;
        DbSet = DbContext.Set<T>();
    }

    public async Task<T> GetAsync<T1>(T1 id)
    {
        return await DbSet.FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return
            await DbSet
                .AsNoTracking()
                .ToListAsync();
    }

    public async Task<GetPagedResult<T>> GetPagedAsync(int limit, int offset)
    {
        var rows = await DbSet
            .AsNoTracking()
            .Skip(offset)
            .Take(limit)
            .ToListAsync();

        var count = await DbSet.CountAsync();

        return new GetPagedResult<T>
        {
            Result = rows,
            Count = count
        };
    }

    public async Task<T> AddAsync(T entity)
    {
        await DbSet.AddAsync(entity);
        await DbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        DbSet.Update(entity);
        await DbContext.SaveChangesAsync();
        return entity;
    }

    public async Task DeleteAsync<T1>(T1 id)
    {
        var entity = await DbSet.FindAsync(id);
        if (entity != null)
        {
            DbSet.Remove(entity);
            await DbContext.SaveChangesAsync();
        }
    } 
}

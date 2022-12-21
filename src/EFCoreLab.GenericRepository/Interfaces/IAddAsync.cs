namespace EFCoreLab.GenericRepository;

public interface IAddAsync<T>
{
    Task<T> AddAsync(T entity);
}

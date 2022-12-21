namespace EFCoreLab.GenericRepository;

public interface IUpdateAsync<T>
{
    Task<T> UpdateAsync(T entity);
}

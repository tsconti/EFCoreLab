namespace EFCoreLab.GenericRepository;

public interface IGetPagedAsync<T>
{
    Task<GetPagedResult<T>> GetPagedAsync(int limit, int offset);
}

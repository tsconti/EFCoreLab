namespace EFCoreLab.GenericRepository;

public interface IGetAllAsync<T>
{
    Task<IEnumerable<T>> GetAllAsync();
}

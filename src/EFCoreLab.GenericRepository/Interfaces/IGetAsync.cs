namespace EFCoreLab.GenericRepository;

public interface IGetAsync<T>
{
    Task<T> GetAsync<T1>(T1 id);
}

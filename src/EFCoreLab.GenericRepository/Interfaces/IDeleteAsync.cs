namespace EFCoreLab.GenericRepository;

public interface IDeleteAsync<T>
{
    Task DeleteAsync<T1>(T1 id);
}

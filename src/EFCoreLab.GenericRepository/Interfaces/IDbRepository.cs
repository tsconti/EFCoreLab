namespace EFCoreLab.GenericRepository;

public interface IDbRepository<T> :
    IGetAsync<T>,
    IGetAllAsync<T>,
    IGetPagedAsync<T>,
    IUpdateAsync<T>,
    IAddAsync<T>,
    IDeleteAsync<T>
{ }

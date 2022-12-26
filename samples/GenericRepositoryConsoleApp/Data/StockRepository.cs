using EFCoreLab.GenericRepository;
using GenericRepositoryConsoleApp.Entities;

namespace GenericRepositoryConsoleApp.Data;

public class StockRepository : IStockRepository
{
    private readonly IDbRepository<Stock> _repository;

    public StockRepository(IDbRepository<Stock> repository)
    {
        _repository = repository;
    }

    public async Task<Stock> AddAsync(Stock entity)
    {
        return await _repository.AddAsync(entity);
    }

    public async Task<Stock> GetAsync<T1>(T1 id)
    {
        return await _repository.GetAsync(id);
    }
}

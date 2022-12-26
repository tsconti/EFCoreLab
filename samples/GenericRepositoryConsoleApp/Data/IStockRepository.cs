using EFCoreLab.GenericRepository;
using GenericRepositoryConsoleApp.Entities;

namespace GenericRepositoryConsoleApp.Data;

public interface IStockRepository : IAddAsync<Stock>, IGetAsync<Stock>
{
}

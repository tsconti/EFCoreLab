using EFCoreLab.GenericRepository.Mapping;
using GenericRepositoryConsoleApp.Entities;

namespace GenericRepositoryConsoleApp.Data.Mapping;

public class StockMapping : EntityMappingBase
{
    public StockMapping()
    {
        EntityType = typeof(Stock);
        TableName = "EFCORELAB_STOCK";

        Navigations.Add(new EntityNavigation(nameof(Stock.Sector)));

        Columns.Add(new EntityProperty("ID", nameof(Stock.Id)));
        Columns.Add(new EntityProperty("STOCK_TICKER", nameof(Stock.Ticker)));
        Columns.Add(new EntityProperty("STOCK_NAME", nameof(Stock.Name)));
        Columns.Add(new EntityProperty("SECTOR_ID", nameof(Stock.SectorId)));
    }
}

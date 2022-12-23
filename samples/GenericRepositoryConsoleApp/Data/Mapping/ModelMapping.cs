using EFCoreLab.GenericRepository;
using EFCoreLab.GenericRepository.Mapping;

namespace GenericRepositoryConsoleApp.Data.Mapping;

public class ConsoleAppModelMapping : IModelMapping
{
    public List<EntityMappingBase> Entities { get; set; }

    public ConsoleAppModelMapping()
    {
        Entities = new List<EntityMappingBase>
        {
            new StockMapping(),
            new SectorMapping()
        };
    }
}

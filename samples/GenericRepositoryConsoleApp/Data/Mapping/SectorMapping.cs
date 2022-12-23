using EFCoreLab.GenericRepository.Mapping;
using GenericRepositoryConsoleApp.Entities;

namespace GenericRepositoryConsoleApp.Data.Mapping;

public class SectorMapping : EntityMappingBase
{
    public SectorMapping()
    {
        EntityType = typeof(Sector);
        TableName = "EFCORELAB_SECTOR";

        Columns.Add(new EntityProperty("ID", nameof(Sector.Id)));
        Columns.Add(new EntityProperty("SECTOR_NAME", nameof(Sector.Name)));
    }
}

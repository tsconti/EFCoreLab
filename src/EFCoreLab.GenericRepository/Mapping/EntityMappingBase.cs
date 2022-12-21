namespace EFCoreLab.GenericRepository.Mapping;

public class EntityMappingBase
{
    public Type EntityType { get; set; }
    public string TableName { get; set; }
    public bool HasNoKey { get; set; }
    public IList<Navigation> Navigations { get; set; }
    public IList<EntityProperty> Columns { get; set; }

    public EntityMappingBase()
    {
        Navigations = new List<Navigation>();
        Columns = new List<EntityProperty>();
    }
}

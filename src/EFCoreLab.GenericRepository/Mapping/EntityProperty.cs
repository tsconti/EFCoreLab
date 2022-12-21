namespace EFCoreLab.GenericRepository.Mapping;

public class EntityProperty
{
    public string ColumnName { get; set; }
    public string PropertyName { get; set; }

    public EntityProperty(string columnName, string propertyName)
    {
        ColumnName = columnName;
        PropertyName = propertyName;
    }
}

namespace EFCoreLab.GenericRepository.Mapping;

public class EntityNavigation
{
    public string NavigationName { get; set; }

    public EntityNavigation(string navigationName)
    {
        NavigationName = navigationName;
    }
}

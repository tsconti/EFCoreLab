using EFCoreLab.GenericRepository.Mapping;

namespace EFCoreLab.GenericRepository;

public interface IModelMapping
{
    List<EntityMappingBase> Entities { get; }
}

using EFCoreLab.GenericRepository.Enums;
using EFCoreLab.GenericRepository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace EFCoreLab.GenericRepository;

public class DataContext : DbContext
{
    private readonly IDbConnectionConfig _config;
    private readonly IModelMapping _modelMapping;

    public DataContext(IDbConnectionConfig config, IModelMapping modelMapping)
    {
        _config = config;
        _modelMapping = modelMapping;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (_config.Type == DbProvider.MsSql)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString());
        }
        else
        {
            optionsBuilder.UseNpgsql(_config.GetConnectionString());
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var entity in _modelMapping.Entities)
        {
            BuildMapping(modelBuilder, entity);
        }
    }

    private void BuildMapping(ModelBuilder modelBuilder, EntityMappingBase entity)
    {
        modelBuilder.Entity(entity.EntityType).ToTable(entity.TableName);

        if (entity.HasNoKey)
            modelBuilder.Entity(entity.EntityType).HasNoKey();

        foreach (var navigation in entity.Navigations)
        {
            modelBuilder.Entity(entity.EntityType)
               .Navigation(navigation.NavigationName)
               .AutoInclude();
        }

        foreach (var column in entity.Columns)
        {
            modelBuilder.Entity(entity.EntityType)
               .Property(column.PropertyName)
               .HasColumnName(column.ColumnName);
        }
    }
}
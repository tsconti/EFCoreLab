using EFCoreLab.GenericRepository.Enums;

namespace EFCoreLab.GenericRepository;

public interface IDbConnectionConfig
{
    public string Database { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Host { get; set; }
    public string Port { get; set; }
    public DbProvider Type { get; }
    public string GetConnectionString();
}

using EFCoreLab.GenericRepository;
using EFCoreLab.GenericRepository.Enums;

namespace GenericRepositoryConsoleApp;

public class DbConnectionConfig : IDbConnectionConfig
{    
    public string Database { get; set; } 
    public string Username { get; set; }    
    public string Password { get; set; }    
    public string Host { get; set; }    
    public string Port { get; set; }    
    public DbProvider Type => DbProvider.MsSql;

    public string GetConnectionString()
    {
        return  $"Server={Host};Database={Database};User={Username};Password={Password}";
    }
}

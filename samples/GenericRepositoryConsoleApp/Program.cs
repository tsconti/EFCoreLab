using EFCoreLab.GenericRepository;
using GenericRepositoryConsoleApp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Generic Repository ConsoleApp!");

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices(services => {
    //services.AddSingleton<IDbConnectionConfig>();
    //Load configuration in your way, this is only for this sample app
    services.AddSingleton<IDbConnectionConfig>(serviceProvider =>
    {
        var appConfiguration = new DbConnectionConfig
        {
            Host = "localhost",
            Database = "stock",
            Username = "username",
            Password = "password"
        };
        return appConfiguration;
    });
});





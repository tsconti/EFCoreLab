using EFCoreLab.GenericRepository;
using GenericRepositoryConsoleApp;
using GenericRepositoryConsoleApp.Data;
using GenericRepositoryConsoleApp.Data.Mapping;
using GenericRepositoryConsoleApp.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Generic Repository ConsoleApp!");

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices(services => {
    // Load configuration in your way, this is only for this sample app
    services.AddSingleton<IDbConnectionConfig>(serviceProvider =>
    {
        var appConfiguration = new DbConnectionConfig
        {
            Host = "localhost",
            Database = "efcorelab",
            Username = "user",
            Password = "password"
        };
        return appConfiguration;
    });
    services.AddPersonalFrameworkDatabaseRepositoryServices(typeof(ConsoleAppModelMapping));
    services.AddScoped<StockRepository>();
});

var host = builder.Build();

var rep = host.Services.GetRequiredService<StockRepository>();

//await AddAsync();
var stock = GetAsync(2).Result;
Console.WriteLine($"Found {stock.Name}");

async Task<Stock> AddAsync()
{
    var newStock = new Stock
    {
        Ticker = "ITSA4",
        Name = "Itausa",
    };

    newStock.Sector = new Sector
    {
        Name = "Financial"
    };

    await rep.AddAsync(newStock);

    var getByIdNew = await rep.GetAsync(newStock.Id);

    return getByIdNew;
}

async Task<Stock> GetAsync(int id)
{
    var getById = await rep.GetAsync(id);

    return getById;
}

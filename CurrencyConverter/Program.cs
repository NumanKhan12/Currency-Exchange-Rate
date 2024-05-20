using CurrencyConverter.BusinessLogicLayer;
using CurrencyConverter.Data;
using CurrencyConverter.IData;
using CurrencyConverter.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration= new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json",optional:false,reloadOnChange:true).AddEnvironmentVariables().Build() ;
builder.Services.AddControllers();

var frankFurterHeaderInfo = configuration.GetSection("FrankFurterHeaderInfo").Get<FrankFurterHeaderInfo>();

if (frankFurterHeaderInfo != null)
    builder.Services.AddSingleton<FrankFurterHeaderInfo>(frankFurterHeaderInfo);

builder.Services.AddTransient<ICurrencyExchangeCore, CurrencyExchangeCore>();
builder.Services.AddTransient<IApiClient, ApiClient>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

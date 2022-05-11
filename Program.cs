using Microsoft.OpenApi.Models;
using singleFileAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setup => setup.SwaggerDoc("v1", new OpenApiInfo()
{
    Description = "Simple Example using Single Page API",
    Title = "Single File API",
    Version = "v1",
    Contact = new OpenApiContact()
    {
        Name = "simon-whale",
        Url = new Uri("https://github.com/Simon-whale")
    }
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/weatherforecast", () =>
{
    var weatherData = new WeatherForecastData();
    return weatherData.GetData();
});

app.MapGet("/Health", () =>
{
    return true;
});

app.Run();
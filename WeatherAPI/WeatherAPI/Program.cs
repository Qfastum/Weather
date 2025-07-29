using OpenWeartherClient;
using WeatherAPI.Configurations;
using WeatherAPI.Services;
using WeatherAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var settings = new AppSettings(builder.Configuration);

builder.Services.AddSingleton<IAppSettings>(settings);
builder.Services.AddSingleton<IWeatherClient,  WeatherClient>();

builder.Services.AddScoped<IWeatherService, WeatherService>();
builder.Services.AddHealthChecks();

builder.Services.AddCors(options => { 
    options.AddPolicy("AllowFrontend",
        policy => policy
          .WithOrigins("http://localhost:3000")
          .AllowAnyMethod()

          .AllowAnyHeader());
});
 
var app = builder.Build();

//app.UseHealthChecks("/health");

app.UseCors("AllowFrontend");

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

using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.PropertyNameCaseInsensitive = false; // Disable case-insensitive parsing
    options.SerializerOptions.PropertyNamingPolicy = null; // Keep property names as defined
});


// Since I seperate Backend and Frontend, I need define CORS, which allow other website call this API service.
// Allow CORS for any origin. If you want a specific website you need to define it's domain. Google it :D
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

// Apply CORS policy added about
app.UseCors("AllowAll");

app.MapControllers();

app.Run();

// Program.cs
using TodoApi.Services; // Ensure this namespace matches your folder structure

var builder = WebApplication.CreateBuilder(args);

// 1. 【CORE】Register controller services into the DI container
builder.Services.AddControllers(); 

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Register the custom TodoService for Dependency Injection
builder.Services.AddScoped<ITodoService, TodoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// 2. 【CORE】Map attribute-routed controllers to the request pipeline
app.MapControllers(); 

app.Run();
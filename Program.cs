using Microsoft.EntityFrameworkCore;
using WerkProfiAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Register the DbContext and SQL Server connection string
builder.Services.AddDbContext<WerkProfiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WerkProfiDb")));

// Add Swagger/OpenAPI for testing your API endpoints
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS to allow the front end to connect to this API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
        policy.WithOrigins("http://localhost:5000") // Replace with your React front end URL if different
              .AllowAnyHeader()
              .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use CORS
app.UseCors("AllowReactApp");

app.UseHttpsRedirection();

app.UseAuthorization();

// Map controllers (API endpoints)
app.MapControllers();

app.Run();
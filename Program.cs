using Microsoft.EntityFrameworkCore;
using ContosoPizza.Data;

var builder = WebApplication.CreateBuilder(args);

//将自定义 DbContext（此处是CarDbContext） 添加到 DI 容器
builder.Services.AddDbContext<PizzaContext>(opt => opt.UseMySql(
  builder.Configuration.GetConnectionString("MySqlConnection"),
  new MySqlServerVersion(new Version("8.0.30"))));

// Add services to the container.
builder.Services.AddControllers();
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

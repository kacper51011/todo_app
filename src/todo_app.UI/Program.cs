

using Microsoft.EntityFrameworkCore;
using todo_app.Core.Services;
using todo_app.Infrastructure.DatabaseContext;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddSingleton<TodoServices>();
builder.Services.AddSingleton<UserServices>();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer());

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

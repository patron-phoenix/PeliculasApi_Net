using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PeliculasApi.Data;
using PeliculasApi.PeliculasMapper;
using PeliculasApi.Repository;
using PeliculasApi.Repository.IRepository;

var builder = WebApplication.CreateBuilder(args);

// configuramos la conxion a sql server
builder.Services.AddDbContext<ApplicationDbContext>(opcion=> opcion.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSql")));

// agregamos los repositorios
builder.Services.AddScoped<ICategoriaRepository,CategoriaRepository>();


// agregar el automapper
builder.Services.AddAutoMapper(typeof(PeliculasMapper));

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

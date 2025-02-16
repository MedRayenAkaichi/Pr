using Projet.BLL.Contract;
using Projet.BLL;
using Projet.Context;
using Projet.DAL;
using Projet.DAL.Contracts;
using Projet.Entities;
using Projet.Services.Interfaces;
using Projet.DAL.Repos;
using Microsoft.EntityFrameworkCore;
using Projet.Services;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

var Cnx = builder.Configuration.GetConnectionString("ConnectionString");
builder.Services.AddDbContext<DataContext>(options =>
                     options.UseSqlServer(Cnx, b => b.MigrationsAssembly("API")));

builder.Services.AddControllers();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<DataContext>();

builder.Services.AddScoped<IUtilisateurService,UtilisateurService>();
builder.Services.AddScoped<IGenericBLL<Utilisateur>, GenericBLL<Utilisateur>>();
builder.Services.AddScoped<IRepository<Utilisateur>, UtilisateurRepository>();
//builder.Services.AddScoped<IRepository<Client>, ClientRepository>();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Projet DOTNET" });
});
var app = builder.Build();
app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());


// Configure the HTTP request pipeline.
app.UseAuthorization();
app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V2");
});

app.Run();


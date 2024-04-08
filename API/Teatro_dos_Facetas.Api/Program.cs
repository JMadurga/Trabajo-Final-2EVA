using Teatro_dos_facetas.Business;
using Teatro_dos_facetas.Data;
using Microsoft.EntityFrameworkCore;
using Teatro_dos_Facetas.Business;
using Teatro_dos_Facetas.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<UserService>();
builder.Services.AddControllers();
builder.Services.AddScoped<ObraService>();
builder.Services.AddControllers();
builder.Services.AddScoped<AsientoService>();
builder.Services.AddControllers();
builder.Services.AddScoped<SesionService>();
builder.Services.AddControllers();
builder.Services.AddScoped<PedidosService>();
builder.Services.AddControllers();
builder.Services.AddScoped<AuthService>();

var connectionString = builder.Configuration.GetConnectionString("ServerDB");
builder.Services.AddDbContext<TeatroContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IObrasRepository, ObrasRepository>();
builder.Services.AddScoped<IAsientoRepository, AsientosRepository>();
builder.Services.AddScoped<ISesionRepository, SesionRepository>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



// builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();

app.UseAuthorization();
app.UseCors(options =>
{
    options.WithOrigins("http://localhost:5173")  
           .AllowAnyMethod()
           .AllowAnyHeader()
           .AllowCredentials();
});
app.MapControllers();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

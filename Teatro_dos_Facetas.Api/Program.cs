using Teatro_dos_facetas.Business;
using Teatro_dos_facetas.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<UserService>();
builder.Services.AddControllers();
builder.Services.AddScoped<ObraService>();
builder.Services.AddControllers();
builder.Services.AddScoped<AsientoService>();
var connectionString = builder.Configuration.GetConnectionString("ServerDB");
builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<ObrasContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<AsientoContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IObrasRepository, ObrasRepository>();
builder.Services.AddScoped<IAsientoRepository, AsientosRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

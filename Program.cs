using Residencial;
using Residencial.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<Residencialcontext>("Data Source=localhost; Initial Catalog=libreriaDB;user id=sa;password=Programaci0n$;Encrypt=False");
builder.Services.AddScoped<IcasaService, casaService>();
builder.Services.AddScoped<IhabitantecasaService, habitantecasaService>();
builder.Services.AddScoped<IresidenteService, residenteService>();
builder.Services.AddScoped<IvisitanteService, visitanteService>();
builder.Services.AddScoped<IvisitaService, visitaService>();





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

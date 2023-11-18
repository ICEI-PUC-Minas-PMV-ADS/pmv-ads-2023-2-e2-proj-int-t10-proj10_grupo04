using LavaADomicilio.API.Domain.Entities;
using LavaADomicilio.API.Domain.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AgendamentoLavagemDbContext>(o => o.UseInMemoryDatabase("LavagemDomicilioDb"));
builder.Services.AddDbContext<UsuarioDbContext>(o => o.UseInMemoryDatabase("LavagemDomicilioDb"));

builder.Services.AddControllers();
builder.Services.AddScoped<UsuarioService>();
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

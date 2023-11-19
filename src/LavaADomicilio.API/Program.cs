using LavaADomicilio.API.Domain.Entities;
using LavaADomicilio.API.Domain.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add contexts to the container.
builder.Services.AddDbContext<AgendamentoLavagemDbContext>(o => o.UseInMemoryDatabase("LavagemDomicilioDb"));
builder.Services.AddDbContext<UsuarioDbContext>(o => o.UseInMemoryDatabase("LavagemDomicilioDb"));
builder.Services.AddDbContext<FuncionarioDbContext>(o => o.UseInMemoryDatabase("LavagemDomicilioDb"));
builder.Services.AddDbContext<TipoDeLavagemDbContext>(o => o.UseInMemoryDatabase("LavagemDomicilioDb"));


// Add services to the container.
builder.Services.AddScoped<AgendamentoLavagemService>();
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<FuncionarioService>();
builder.Services.AddScoped<TipoDeLavagemService>();

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

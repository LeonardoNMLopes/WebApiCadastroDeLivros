using Microsoft.EntityFrameworkCore;
using WebApi8CadastroDeLivros.Data;
using WebApi8CadastroDeLivros.Services.Autor;
using WebApi8CadastroDeLivros.Services.Livro;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAutorInterface, AutorService>();
// builder para a comunicação da interface Autor para o Service Autor
builder.Services.AddScoped<ILivroInterface, LivroService>();
// builder para a comunicação da interface Livro para o Service Livro

builder.Services.AddDbContext<AppDbContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Antes de iniciar a construção o programa deve pegar a string de conexão, "DefaultConnectio",
// e mandar para a classe AppDbContext.

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

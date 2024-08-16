using Microsoft.EntityFrameworkCore;
using WebApi8CadastroDeLivros.Models;

namespace WebApi8CadastroDeLivros.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base( options ) 
        {           
        }

        //Construtor da classe que serve para fazer o meio de campo entre o programa e o banco de dados.
        //O construtor precisa de recer algumas "opções" (options) para fazer esse meio de campo.

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }

        // DbSet serve para pegar um modelo <> e setar uma tabela do mesmo dentro do banco de dados
    }
}

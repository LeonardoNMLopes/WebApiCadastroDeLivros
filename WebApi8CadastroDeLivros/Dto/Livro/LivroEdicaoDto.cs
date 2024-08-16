using WebApi8CadastroDeLivros.Dto.Vinculo;
using WebApi8CadastroDeLivros.Models;

namespace WebApi8CadastroDeLivros.Dto.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
    //Classe que serve para facilitar a edição de um objeto Livro dentro do banco de dados.
}

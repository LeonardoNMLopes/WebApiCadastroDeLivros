using Microsoft.AspNetCore.Hosting.Server;
using WebApi8CadastroDeLivros.Dto.Vinculo;
using WebApi8CadastroDeLivros.Models;

namespace WebApi8CadastroDeLivros.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
    //Classe que serve para facilitar a criação de um objeto Livro dentro do banco de dados.
}

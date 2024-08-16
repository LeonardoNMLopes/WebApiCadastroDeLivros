using Microsoft.AspNetCore.Hosting.Server;

namespace WebApi8CadastroDeLivros.Dto.Autor
{
    public class AutorEdicaoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
    //Classe que serve para facilitar a edição de um objeto autor dentro do banco de dados.
}

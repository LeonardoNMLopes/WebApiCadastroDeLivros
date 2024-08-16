namespace WebApi8CadastroDeLivros.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorModel Autor { get; set; }

    }

    //Modela para a tabela de livros no banco de dados.
}

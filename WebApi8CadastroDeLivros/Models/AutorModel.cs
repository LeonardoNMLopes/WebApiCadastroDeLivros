using System.Text.Json.Serialization;

namespace WebApi8CadastroDeLivros.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [JsonIgnore]
        public ICollection<LivroModel> Livros { get; set; }

    }

    // Modelo para a tabela de Autores no banco de dados.
}

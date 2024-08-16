namespace WebApi8CadastroDeLivros.Models
{
    public class ResponseModel<T>
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Status { get; set; } = true;
    }
}

// Classe responsavel por passar a mensagem e mostrar os dados quando é solicitada uma busca no banco de dados.
// Propriedade Dados e de um tipo <T> pois pode receber um objeto do tipo Autor ou de um tipo Livro,
// ou pode ser nulo (T?) quando não é encontrado nada no banco.

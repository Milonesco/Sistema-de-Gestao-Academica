namespace TransformeseApp2.DTO
{
    // Classe base com propriedades comuns
    public abstract class PessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public string? UrlFoto { get; set; }

        // Método abstrato > Exemplo de abstração
        public abstract void ExibirInfo();
    }
}

namespace TransformeseApp2.DTO
{
    // Classe base com propriedades comuns
    public abstract class PessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        // Método abstrato > Exemplo de abstração
        public abstract void ExibirInfo();
    }
}

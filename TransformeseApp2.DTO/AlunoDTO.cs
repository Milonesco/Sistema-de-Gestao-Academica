namespace TransformeseApp2.DTO
{
    public class AlunoDTO : PessoaDTO
    {
        public CursoDTO? Curso { get; set; }
        public UnidadeDTO? Unidade { get; set; }
        public int CursoId { get; set; }
        public int UnidadeId { get; set; }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Aluno: {Nome}, Curso: {Curso.Nome}, Unidade: {Unidade.Nome}");
        }
    }
}

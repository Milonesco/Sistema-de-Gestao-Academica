namespace TransformeseApp2.DTO
{
    public class AlunoDTO : PessoaDTO
    {
        public int CursoId { get; set; }
        public int UnidadeId { get; set; }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Aluno: {Nome}, Curso: NomeDoCurso, Unidade: NomeDaUnidade");
        }
    }
}

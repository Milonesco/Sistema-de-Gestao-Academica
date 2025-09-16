using TransformeseApp2.DTO;

namespace TransformeseApp2.DAL
{
    //Simulação do banco de dados em memória
    public static class Database
    {
        public static List<AlunoDTO> Alunos { get; } = new();
        public static List<CursoDTO> Cursos { get; } = new();
        public static List<UnidadeDTO> Unidades { get; } = new();
    }
}
